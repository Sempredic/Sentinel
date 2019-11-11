﻿using System;
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

            areaComboBox.Items.Add("Outbound Area");

            caseTextBox.Enabled = false;

            serialTextBox.Enabled = false;


            
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
                List<SerialInfo> list = MongoCRUD.GetInstance().LoadRecords<SerialInfo>("Serial", "Serial",serialInfoTextBox.Text);


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

        private void areaLocationBox_KeyDown(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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
        }

        private void caseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                

                List<SerialInfo> list = MongoCRUD.GetInstance().LoadRecords<SerialInfo>("Serial", "Case",caseTextBox.Text);


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
                else if (serialTextBox.Text == "CLEARLIST" || serialTextBox2.Text.ToUpper() == "CLEARLIST")
                {
                    serialListBox.Items.Clear();
                    serialListView.Clear();
                    
                    numScannedLabel.Text = serialListBox.Items.Count.ToString();
                    numUnitsLabel.Text = "0";


                    if (validateInputTabs.SelectedTab == validateInputTabs.TabPages["VerifyTab"])
                    {
                        serialTextBox.Clear();
                        serialTextBox.Focus();
                    }
                    else
                    {
                        serialTextBox2.Clear();
                        serialTextBox2.Focus();
                    }
                    
                }
                else if (serialTextBox.Text == "CLEARCASE" || serialTextBox2.Text.ToUpper() == "CLEARCASE")
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
                else if (serialTextBox2.Text == "ADD")
                {

                    foreach (string item in serialListBox.Items)
                    {
                        SerialInfo si = new SerialInfo();

                        si.serial = item;

                        LocationData d = new LocationData();
                        d.curCase = caseTextBox2.Text;
                        d.date = DateTime.UtcNow.Date.ToString("dd/MM/yyyy");
                        d.time = DateTime.Now.ToString("h:mm:ss tt");
                        d.location = areaLocationBox2.Text;
                        d.lastLocation = true;
                        d.userID = "311015";
                        

                        si.locationData.Add(d);

                        if (MongoCRUD.GetInstance().RecordExists<SerialInfo>("Serial", item))
                        {
                            MongoCRUD.GetInstance().AppendRecord<SerialInfo>("Serial", item, d);
                        }
                        else
                        {
                            

                            MongoCRUD.GetInstance().InsertRecord("Serial", si,item,caseTextBox2.Text);
                        }
                        
                    }


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
                    if (validateInputTabs.SelectedTab == validateInputTabs.TabPages["VerifyTab"])
                    {
                        serialListBox.Items.Add(serialTextBox.Text);

                        numScannedLabel.Text = serialListBox.Items.Count.ToString();

                        for (int i = 0; i < serialListView.Items.Count; i++)
                        {
                            if (serialTextBox.Text == serialListView.Items[i].Text)
                            {
                                serialListView.Items[i].BackColor = Color.Green;

                            }
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
    }
}