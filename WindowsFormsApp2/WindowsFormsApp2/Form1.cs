using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            LoadAreaComboBox();

            caseTextBox.Enabled = false;

            serialTextBox.Enabled = false;



        }

        private void LoadAreaComboBox()
        {
   
            List<AreaInfo> areas = MongoCRUD.GetInstance().LoadRecords<AreaInfo>("Areas", null, null);

            if (areas.Count != 0)
            {
                areaComboBox.Items.Clear();

                foreach (AreaInfo a in areas)
                {
                    areaComboBox.Items.Add(a.areaName);
                }

            }

        }

        private void ResizeListViewColumns(ListView lv)
        {
            for (int i = 0; i < lv.Columns.Count; i++)
            {
                //column.AutoResize(ColumnHeaderAutoResizeStyle.None);

                if (i == 6)
                {
                    lv.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lv.Columns[i].Width += 60;
                } else if (i != 0)
                {
                    lv.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lv.Columns[i].Width += 20;
                }
                else
                {
                    lv.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                }


            }
        }

        private void serialInfoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                serialInfoListView.Items.Clear();
                List<SerialInfo> list = MongoCRUD.GetInstance().LoadRecords<SerialInfo>("Serial", "serial", serialInfoTextBox.Text);


                if (list.Count != 0)
                {
                    foreach (SerialInfo si in list)
                    {
                        List<LocationData> tempLD = si.locationData;

                        foreach (LocationData ld in tempLD)
                        {
                            ListViewItem item = new ListViewItem(list[0].ID.ToString());
                            item.SubItems.Add(ld.date);
                            item.SubItems.Add(ld.curCase);
                            item.SubItems.Add(ld.location);
                            item.SubItems.Add(ld.userID);
                            item.SubItems.Add(ld.time);
                            item.SubItems.Add(ld.lastLocation.ToString());

                            serialInfoListView.Items.Add(item);
                        }


                    }

                }

                ResizeListViewColumns(serialInfoListView);
            }
        }

        private void areaLocationBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool locationExists = false;
                string areaName = (string)areaComboBox.SelectedItem;

                List<AreaInfo> areas = MongoCRUD.GetInstance().LoadRecords<AreaInfo>("Areas", "areaName", areaName);


                if (areas.Count != 0)
                {

                    foreach (LocationObject lo in areas[0].locationsList)
                    {
                        if (lo.locName == areaLocationBox.Text)
                        {
                            locationExists = true;

                            
                        }else if (lo.locName == areaLocationBox2.Text)
                        {
                            locationExists = true;
                        }
                    }

                    if (locationExists)
                    {
                        if (validateInputTabs.SelectedTab == validateInputTabs.TabPages["VerifyTab"])
                        {
                            caseTextBox.Enabled = true;

                            this.SelectNextControl(ActiveControl, true, true, true, true);
                            areaLocationBox.Enabled = false;
                        }
                        else
                        {
                            caseTextBox2.Enabled = true;

                            this.SelectNextControl(ActiveControl, true, true, true, true);
                            areaLocationBox2.Enabled = false;
                        }
                    }
                    else
                    {
                        areaLocationBox.Clear();
                        areaLocationBox2.Clear();
                        Console.WriteLine("Nobody here wrong again man");
                    }

                }

                
            }
        }

        private void caseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                List<SerialInfo> list = MongoCRUD.GetInstance().LoadRecords<SerialInfo>("Serial", "caseID", caseTextBox.Text);


                if (list.Count != 0)
                {
                    numUnitsLabel.Text = list.Count.ToString();

                    foreach (SerialInfo item in list)
                    {
                        serialListView.Items.Add(item.serial);

                    }


                    if (validateInputTabs.SelectedTab == validateInputTabs.TabPages["VerifyTab"])
                    {
                        serialTextBox.Enabled = true;

                        this.SelectNextControl(ActiveControl, true, true, true, true);
                        caseTextBox.Enabled = false;
                    }
                    else
                    {
                        serialTextBox2.Enabled = true;

                        this.SelectNextControl(ActiveControl, true, true, true, true);
                        caseTextBox2.Enabled = false;
                        serialTextBox2.Focus();
                    }



                }
                else
                {
                    if (validateInputTabs.SelectedTab == validateInputTabs.TabPages["VerifyTab"])
                    {
                        caseTextBox.Clear();
                        numUnitsLabel.Text = list.Count.ToString();
                    }
                    else
                    {
                        serialTextBox2.Enabled = true;

                        this.SelectNextControl(ActiveControl, true, true, true, true);
                        caseTextBox2.Enabled = false;
                        serialTextBox2.Focus();
                    }

                }


            }
        }

        private void serialTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (serialTextBox.Text.ToUpper() == "CLEAR" || serialTextBox2.Text.ToUpper() == "CLEAR")
                {
                    serialListBox.Items.Clear();
                    serialListView.Clear();

                    numScannedLabel.Text = serialListBox.Items.Count.ToString();
                    numUnitsLabel.Text = "0";

                    if (validateInputTabs.SelectedTab == validateInputTabs.TabPages["VerifyTab"])
                    {
                        serialTextBox.Clear();

                        serialTextBox.Enabled = false;
                        caseTextBox.Enabled = false;
                        areaLocationBox.Enabled = true;

                        caseTextBox.Clear();
                        areaLocationBox.Clear();

                        areaLocationBox.Focus();
                    }
                    else
                    {
                        serialTextBox2.Clear();

                        serialTextBox2.Enabled = false;
                        caseTextBox2.Enabled = false;
                        areaLocationBox2.Enabled = true;

                        caseTextBox2.Clear();
                        areaLocationBox2.Clear();

                        areaLocationBox2.Focus();
                    }

                }
                else if (serialTextBox.Text.ToUpper() == "CLEARLIST" || serialTextBox2.Text.ToUpper() == "CLEARLIST")
                {
                    serialListBox.Items.Clear();
                    serialListView.Clear();

                    numScannedLabel.Text = serialListBox.Items.Count.ToString();
                    numUnitsLabel.Text = "0";

                    if (validateInputTabs.SelectedTab == validateInputTabs.TabPages["VerifyTab"])
                    {
                        List<SerialInfo> list = MongoCRUD.GetInstance().LoadRecords<SerialInfo>("Serial", "caseID", caseTextBox.Text);


                        if (list.Count != 0)
                        {
                            numUnitsLabel.Text = list.Count.ToString();

                            foreach (SerialInfo item in list)
                            {
                                serialListView.Items.Add(item.serial);

                            }
                        }

                        serialTextBox.Clear();
                        serialTextBox.Focus();
                    }
                    else
                    {
                        serialTextBox2.Clear();
                        serialTextBox2.Focus();
                    }

                }
                else if (serialTextBox.Text.ToUpper() == "CLEARCASE" || serialTextBox2.Text.ToUpper() == "CLEARCASE")
                {

                    serialListBox.Items.Clear();
                    serialListView.Clear();

                    numScannedLabel.Text = serialListBox.Items.Count.ToString();
                    numUnitsLabel.Text = "0";

                    if (validateInputTabs.SelectedTab == validateInputTabs.TabPages["VerifyTab"])
                    {
                        serialTextBox.Clear();

                        serialTextBox.Enabled = false;
                        caseTextBox.Enabled = true;
                        caseTextBox.Clear();
                        caseTextBox.Focus();
                    }
                    else
                    {

                        serialTextBox2.Clear();

                        serialTextBox2.Enabled = false;
                        caseTextBox2.Enabled = true;
                        caseTextBox2.Clear();
                        caseTextBox2.Focus();
                    }

                }
                else if (serialTextBox.Text.ToUpper() == "VALIDATE")
                {
                    bool isBad = false;

                    List<SerialInfo> list = MongoCRUD.GetInstance().LoadRecords<SerialInfo>("Serial", "caseID", caseTextBox.Text);
                    List<string> serialList = new List<string>();

                    if (list.Count != 0)
                    {

                        foreach (SerialInfo serial in list)
                        {
                            serialList.Add(serial.serial);
                        }

                        foreach (string item in serialListBox.Items)
                        {
                            if (!serialList.Contains(item))
                            {
                                isBad = true;
                            }

                        }
                    } 
                    

                    if (isBad)
                    {
                        ShowDialog("Unable to commit case, try again", "Cannot Validate", false);

                        serialListBox.Items.Clear();
                        serialListView.Clear();

                        numScannedLabel.Text = serialListBox.Items.Count.ToString();
                        numUnitsLabel.Text = "0";

                        if (validateInputTabs.SelectedTab == validateInputTabs.TabPages["VerifyTab"])
                        {
                            serialTextBox.Clear();

                            serialTextBox.Enabled = false;
                            caseTextBox.Enabled = true;
                            caseTextBox.Clear();
                            caseTextBox.Focus();
                        }

                    }
                    else
                    {
                        
                        foreach (string item in serialListBox.Items)
                        {
                            SerialInfo si = new SerialInfo();

                            si.serial = item;

                            LocationData d = new LocationData();
                            d.curCase = caseTextBox.Text;
                            d.date = DateTime.UtcNow.Date.ToString("MM/dd/yyyy");
                            d.time = DateTime.Now.ToString("h:mm:ss tt");
                            d.location = areaLocationBox.Text;
                            d.lastLocation = true;
                            d.userID = "311015";

                            si.locationData.Add(d);

                            if (MongoCRUD.GetInstance().RecordExists<SerialInfo>("Serial", item, "serial"))
                            {
                                MongoCRUD.GetInstance().AppendRecord<SerialInfo>("Serial", item, d);
                            }

                        }

                        CaseInfo ci = new CaseInfo();
                        ci.caseID = caseTextBox.Text;
                        ci.curLoc = areaLocationBox.Text;
                        ci.ageInfo = DateTime.Now.ToString("MM-dd-yyyy hh: mm tt");


                        MongoCRUD.GetInstance().InsertRecord("Cases", ci, caseTextBox.Text, null);

                        UpdateAreaLocCases(ci, areaComboBox.SelectedItem.ToString());

                        ShowDialog("Case Passed", "Case Validated", false);

                        serialListBox.Items.Clear();
                        serialListView.Clear();
                        serialTextBox.Clear();

                        numScannedLabel.Text = serialListBox.Items.Count.ToString();
                        numUnitsLabel.Text = "0";

                        serialTextBox.Enabled = false;
                        caseTextBox.Enabled = true;
                        caseTextBox.Clear();
                        caseTextBox.Focus();
                    }

                }
                else if (serialTextBox2.Text.ToUpper() == "ADD")
                {

                    foreach (string item in serialListBox.Items)
                    {
                        SerialInfo si = new SerialInfo();

                        si.serial = item;

                        LocationData d = new LocationData();
                        d.curCase = caseTextBox2.Text;
                        d.date = DateTime.UtcNow.Date.ToString("MM/dd/yyyy");
                        d.time = DateTime.Now.ToString("h:mm:ss tt");
                        d.location = areaLocationBox2.Text;
                        d.lastLocation = true;
                        d.userID = "311015";


                        si.locationData.Add(d);



                        if (MongoCRUD.GetInstance().RecordExists<SerialInfo>("Serial", item, "serial"))
                        {
                            MongoCRUD.GetInstance().AppendRecord<SerialInfo>("Serial", item, d);
                        }
                        else
                        {


                            MongoCRUD.GetInstance().InsertRecord("Serial", si, item, caseTextBox2.Text);
                        }

                    }

                    CaseInfo ci = new CaseInfo();
                    ci.caseID = caseTextBox2.Text;
                    ci.curLoc = areaLocationBox2.Text;
                    ci.ageInfo = DateTime.Now.ToString("MM-dd-yyyy hh: mm tt");
            

                    MongoCRUD.GetInstance().InsertRecord("Cases", ci, caseTextBox2.Text, null);

                    UpdateAreaLocCases(ci, areaComboBox.SelectedItem.ToString());

                    serialListBox.Items.Clear();
                    serialListView.Clear();
                    serialTextBox2.Clear();

                    numScannedLabel.Text = serialListBox.Items.Count.ToString();
                    numUnitsLabel.Text = "0";

                    serialTextBox2.Enabled = false;
                    caseTextBox2.Enabled = true;
                    caseTextBox2.Clear();
                    caseTextBox2.Focus();

                    

                }
                else
                {
                    List<string> serialsList = new List<string>();

                    if (validateInputTabs.SelectedTab == validateInputTabs.TabPages["VerifyTab"])
                    {
                        serialListBox.Items.Add(serialTextBox.Text);

                        numScannedLabel.Text = serialListBox.Items.Count.ToString();

                        for (int i = 0; i < serialListView.Items.Count; i++)
                        {
                            serialsList.Add(serialListView.Items[i].Text);

                            if (serialTextBox.Text == serialListView.Items[i].Text)
                            {
                                serialListView.Items[i].BackColor = Color.Green;

                            }
                        }

                        if (!serialsList.Contains(serialTextBox.Text))
                        {
                            serialListView.Items.Add(serialTextBox.Text).BackColor = Color.Red;
                        }

                        serialTextBox.Clear();
                        serialTextBox.Focus();
                    }
                    else
                    {
                        serialListBox.Items.Add(serialTextBox2.Text);

                        numScannedLabel.Text = serialListBox.Items.Count.ToString();

                        for (int i = 0; i < serialListView.Items.Count; i++)
                        {
                            if (serialTextBox2.Text == serialListView.Items[i].Text)
                            {
                                serialListView.Items[i].BackColor = Color.Green;

                            }
                        }


                        serialTextBox2.Clear();
                        serialTextBox2.Focus();
                    }

                }

            }
        }

        private AgeInfo CalculateAgeInfo(DateTime startDT, DateTime endDT)
        {
            AgeInfo ai = new AgeInfo();
            DateTime currentDT = DateTime.UtcNow.Date;
            int days = (endDT - startDT).Days;
            int hours = (endDT - startDT).Hours;
            int min = (endDT - startDT).Minutes;

            ai.days = days;
            ai.hours = hours;
            ai.minute = min;

            return ai;
        }

        private void UpdateAreaLocCases(CaseInfo ci, string areaID)
        {

            List<AreaInfo> areas = MongoCRUD.GetInstance().LoadRecords<AreaInfo>("Areas", "areaName", areaID);

            if (areas.Count != 0)
            {

                foreach (LocationObject lo in areas[0].locationsList)
                {
                    if (lo.locName == ci.curLoc)
                    {
                        if (!lo.casesList.Contains(ci))
                        {
                            MongoCRUD.GetInstance().UpdateLocationCases(lo, areas[0], ci);
                        }
                    }
                    
                }

            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["AgeReportTab"])
            {
                List<AreaInfo> areas = MongoCRUD.GetInstance().LoadRecords<AreaInfo>("Areas", null, null);

                if (areas.Count!=0)
                {
                    ageReportAreaListView.Items.Clear();

                    foreach (AreaInfo a in areas)
                    {

                        ageReportAreaListView.Items.Add(a.areaName);
                        
                    }
                    
                }
            }
        }

        private void ageReportAreaListView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo HI = ageReportAreaListView.HitTest(e.Location);

            List<AreaInfo> areas = MongoCRUD.GetInstance().LoadRecords<AreaInfo>("Areas", "areaName", HI.Item.Text);

            if (areas.Count != 0)
            {
                ageReportMainListView.Items.Clear();

                foreach (LocationObject loc in areas[0].locationsList)
                {
                    foreach (CaseInfo ci in loc.casesList)
                    {
                        DateTime dt = DateTime.Parse(ci.ageInfo);

                        ListViewItem item = new ListViewItem(ci.ageInfo);
                        item.SubItems.Add(ci.caseID);
                        AgeInfo cai = CalculateAgeInfo(dt,MongoCRUD.GetInstance().GetServerTime());
                        item.SubItems.Add("Days: " + cai.days + "  Hours: " + cai.hours + "  Min: " + cai.minute);
                        item.SubItems.Add(ci.curLoc);

                        ageReportMainListView.Items.Add(item);
                    }
                }

            }

        }

        private void areaMgrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new SettingsForm();
            myForm.Show();

        }

        private void validateInputTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialListBox.Items.Clear();
            serialListView.Clear();
            serialTextBox.Clear();
            serialTextBox2.Clear();

            numScannedLabel.Text = serialListBox.Items.Count.ToString();
            numUnitsLabel.Text = "0";

            serialTextBox.Enabled = false;
            caseTextBox.Enabled = false;
            serialTextBox2.Enabled = false;
            caseTextBox2.Enabled = false;

            areaLocationBox.Enabled = true;
            areaLocationBox2.Enabled = true;

            caseTextBox.Clear();
            areaLocationBox.Clear();
            caseTextBox2.Clear();
            areaLocationBox2.Clear();

            areaLocationBox.Focus();
            areaLocationBox2.Focus();
        }

        public static string ShowDialog(string text, string caption, bool textInput)
        {
            TextBox textBox = null;

            Form prompt = new Form()
            {
                Width = 350,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            if (textInput)
            {
                textBox = new TextBox() { Left = 40, Top = 75, Width = 250 };

                prompt.Controls.Add(textBox);

            }

            Label textLabel = new Label() { Text = text };
            textLabel.AutoSize = false;
            textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            textLabel.Dock = DockStyle.Fill;

            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;



            return prompt.ShowDialog() == DialogResult.OK ? textBox != null ? textBox.Text : "" : "";
        }
    }
}
