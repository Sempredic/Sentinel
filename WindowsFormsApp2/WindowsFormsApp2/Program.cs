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
            /*
            SerialInfo si = new SerialInfo();

            si.serial = "345345345345";

            LocationData d = new LocationData();
            d.curCase = "asdfasdf";
            d.date = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
            d.time = DateTime.Now.ToString("h:mm:ss tt");
            d.location = "Outbound";
            d.lastLocation = false;
            d.userID = "311015";

            si.locationData.Add(d);
            
            MongoCRUD.GetInstance().InsertRecord("Serial", si);

    */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            

        }
    }

    public class MongoCRUD
    {
        private IMongoDatabase db;

        private static MongoCRUD instance = null;


        public MongoCRUD()
        {
            
        }

        public void ConnectToDB(string dbConnString)
        {
            var client = new MongoClient();
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

        public bool RecordExists<T>(string table, string id)
        {
            List<T> list = null;
            bool exists = false;
            var collection = db.GetCollection<T>(table);

            var filter = Builders<T>.Filter.Eq("serial", id);
            list = collection.Find(filter).ToList();

            if (list.Count!=0)
            {
                exists = true;
            }

            return exists;
        }

        public void InsertRecord <T> (string table, T record, string id , string caseID)
        {
            var collection = db.GetCollection<T>(table);
            var serialCollection = db.GetCollection<SerialInfo>("Serial");

            collection.InsertOne(record);

            serialCollection.FindOneAndUpdate(c => c.serial == id,
                            Builders<SerialInfo>.Update.Set(c => c.caseID, caseID));
        }

        public void AppendRecord<T>(string table, string id, LocationData ld)
        {
            var collection = db.GetCollection<T>(table);

            var filter = Builders<T>.Filter.Eq("serial", id);
            var update = Builders<T>.Update.Push("locationData",ld);
            var result = collection.UpdateOne(filter, update);

            
            UpdateLastLocations(ld.ID, id);
        }

        public void UpdateLastLocations(string id, string serial)
        {
            if (RecordExists<SerialInfo>("Serial",serial))
            {
                SerialInfo list = LoadRecords<SerialInfo>("Serial", "Serial", serial)[0];
                var collection = db.GetCollection<SerialInfo>("Serial");


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
                            Builders<SerialInfo>.Update.Set(c => c.locationData[-1].lastLocation,true));

                        collection.FindOneAndUpdate(c => c.serial == serial,
                            Builders<SerialInfo>.Update.Set(c => c.caseID, ld.curCase));
                    }
                    
                }
                

            }


        }

        public List<T> LoadRecords<T>(string table, string type,string item)
        {

            List<T> list = null;

            if (db!=null)
            {
                var collection = db.GetCollection<T>(table);

                if (type == "Case")
                {
                    var filter = Builders<T>.Filter.Eq("caseID", item);
                    list = collection.Find(filter).ToList();

                }
                else if (type == "Serial")
                {
                    var filter = Builders<T>.Filter.Eq("serial", item);
                    list = collection.Find(filter).ToList();
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
}
