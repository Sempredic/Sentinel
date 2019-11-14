using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            MongoCRUD.GetInstance().ConnectToDB("Serials");


            if (MongoCRUD.GetInstance().DBConnectionStatus()) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                ShowDialog("Cannot Connect To Specified Database", "Error");
            }

        }

        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 350,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Text = text };
            textLabel.AutoSize = false;
            textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            textLabel.Dock = DockStyle.Fill;
            //TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            //prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            //return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            return prompt.ShowDialog() == DialogResult.OK ? "" : "";
        }
    }

    public class MongoCRUD
    {
        private IMongoDatabase db;

        private static MongoCRUD instance = null;


        public MongoCRUD()
        {

        }

        public bool DBConnectionStatus() {

            bool status = true;

            try
            {
                var command = new BsonDocument { { "dbstats", 1 } };
                var result = db.RunCommand<BsonDocument>(command);
            }
            catch (Exception e)
            {
                status = false;
            }

            return status;
        }

        public void ConnectToDB(string dbConnString)
        {
            var client = new MongoClient("mongodb+srv://311015:GErnamS8VyBxir64@cluster0-qvscx.mongodb.net/test?retryWrites=true&w=majority");
            var database = client.GetDatabase(dbConnString);

            //var client = new MongoClient();
            db = client.GetDatabase(dbConnString);


        }

        public static MongoCRUD GetInstance()
        {
            if (instance == null)
            {
                instance = new MongoCRUD();
            }
            return instance;
        }

        public bool RecordExists<T>(string table, string id, string fieldName)
        {
            List<T> list = null;
            bool exists = false;
            var collection = db.GetCollection<T>(table);

            var filter = Builders<T>.Filter.Eq(fieldName, id);
            list = collection.Find(filter).ToList();


            if (list.Count != 0)
            {
                exists = true;
            }

            return exists;
        }

        public void InsertRecord<T>(string table, T record, string id, string caseID)
        {
            var collection = db.GetCollection<T>(table);


            Type typeParameterType = typeof(T);

            if (typeParameterType.Name == "SerialInfo")
            {
                var serialCollection = db.GetCollection<SerialInfo>("Serial");

                collection.InsertOne(record);

                serialCollection.FindOneAndUpdate(c => c.serial == id,
                                Builders<SerialInfo>.Update.Set(c => c.caseID, caseID));

            } else if (typeParameterType.Name == "CaseInfo")
            {
                if (!RecordExists<T>(table, id, "caseID"))
                {
                    var caseCollection = db.GetCollection<CaseInfo>("Cases");

                    collection.InsertOne(record);

                    
                }
                else
                {
                    CaseInfo a = (CaseInfo)(object)record;
                    var caseCollection = db.GetCollection<CaseInfo>("Cases");
                    caseCollection.FindOneAndUpdate(c => c.caseID == id,
                                Builders<CaseInfo>.Update.Set(c => c.curLoc, a.curLoc));
                }
                
            }else if (typeParameterType.Name == "AreaInfo")
            {
                if (!RecordExists<T>(table, id, "areaName"))
                {
                    var caseCollection = db.GetCollection<AreaInfo>("Areas");

                    collection.InsertOne(record);


                }
            }
            
        }

        public void AppendRecord<T>(string table, string id, LocationData ld)
        {
            var collection = db.GetCollection<T>(table);

            var filter = Builders<T>.Filter.Eq("serial", id);
            var update = Builders<T>.Update.Push("locationData", ld);
            var result = collection.UpdateOne(filter, update);


            UpdateLastLocations(ld.ID, id);
        }

        public void AppendRecord<T>(string table, string id, LocationObject ld)
        {
            var collection = db.GetCollection<T>(table);

            var filter = Builders<T>.Filter.Eq("areaName", id);
            var update = Builders<T>.Update.Push("locationsList", ld);
            var result = collection.UpdateOne(filter, update);

        }

        public void UpdateLocationCases(LocationObject lo, AreaInfo ai, CaseInfo ci)
        {
            var collection = db.GetCollection<AreaInfo>("Areas");

            Console.WriteLine(lo.locName + "SHITFUCK");

            collection.FindOneAndUpdate(c => c.areaName == ai.areaName && c.locationsList.Any(s => s.locName == lo.locName),
                            Builders<AreaInfo>.Update.Push(c => c.locationsList[-1].casesList, ci));
        }

        public void UpdateLastLocations(string id, string serial)
        {
            if (RecordExists<SerialInfo>("Serial", serial, "serial"))
            {
                SerialInfo list = LoadRecords<SerialInfo>("Serial", "serial", serial)[0];
                var collection = db.GetCollection<SerialInfo>("Serial");

                
                //loop through each locationData object and if object doesn't match the id of most recent entry then set last location to false, otherwise true
                foreach (LocationData ld in list.locationData)
                {

                    // Save the entire document back to the database
                   
                    if (ld.ID != id)
                    {

                        collection.FindOneAndUpdate(c => c.serial == serial && c.locationData.Any(s => s.ID == ld.ID),
                            Builders<SerialInfo>.Update.Set(c => c.locationData[-1].lastLocation, false));

                    }
                    else
                    {
                        collection.FindOneAndUpdate(c => c.serial == serial && c.locationData.Any(s => s.ID == ld.ID),
                            Builders<SerialInfo>.Update.Set(c => c.locationData[-1].lastLocation, true));

                        collection.FindOneAndUpdate(c => c.serial == serial,
                            Builders<SerialInfo>.Update.Set(c => c.caseID, ld.curCase));
                    }

                }


            }


        }

        public List<T> LoadRecords<T>(string table, string type, string item)
        {

            List<T> list = new List<T>();

            if (db != null)
            {
                var collection = db.GetCollection<T>(table);

                Type typeParameterType = typeof(T);

                if (typeParameterType.Name == "SerialInfo")
                {
                    var filter = Builders<T>.Filter.Eq(type, item);
                    list = collection.Find(filter).ToList();
                }
                else if (typeParameterType.Name == "AreaInfo")
                {
                    if (type!=null)
                    {
                        var filter = Builders<T>.Filter.Eq(type, item);
                        list = collection.Find(filter).ToList();
                    }
                    else
                    {
                        var filter = new BsonDocument();
                        list = collection.Find(filter).ToList();
                    }
                    
                }

            }
            else
            {
                Console.WriteLine("ERROR THIS IS NULL");
            }


            return list;
        }


    }

    public class LocationData
    {

        public string ID;
        public string userID;
        public string location;
        public string time;
        public string date;
        public string curCase;
        public bool lastLocation;

        public LocationData()
        {
            ID = GenerateID();
        }

        string GenerateID()
        {
            long i = 1;

            foreach (byte b in System.Guid.NewGuid().ToByteArray())
            {
                i *= ((int)b + 1);
            }

            return string.Format("{0:x}", i - System.DateTime.Now.Ticks);
        }
    }

    public class SerialInfo
    {
        [BsonId]
        public Guid ID;
        public string serial;
        public string caseID;
        public List<LocationData> locationData;

        public SerialInfo()
        {
            locationData = new List<LocationData>();
        }
    }

    public class AreaInfo
    {
        [BsonId]
        public Guid ID;
        public string areaName;
        public List<LocationObject> locationsList;

        public AreaInfo()
        {
            locationsList = new List<LocationObject>();
        }

    }

    public class LocationObject
    {

        public string locName;
        public List<CaseInfo> casesList;

        public LocationObject()
        {
            casesList = new List<CaseInfo>();
        }
    }

    public class AgeInfo
    {

        public int days;
        public int hours;
        public int minute;
    }
    public class CaseInfo
    {
        [BsonId]
        public Guid ID;
        public string caseID;
        public string ageDays;
        public AgeInfo ageInfo;
        public string curLoc;

        public CaseInfo()
        {
            ageInfo = new AgeInfo();
        }
    }
}
