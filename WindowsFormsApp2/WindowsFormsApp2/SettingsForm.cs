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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            RefreshAreasList();
        }

        private void RefreshAreasList()
        {
            List<AreaInfo> areas = MongoCRUD.GetInstance().LoadRecords<AreaInfo>("Areas", null, null);

            if (areas.Count != 0)
            {
                settingsAreaListView.Items.Clear();

                foreach (AreaInfo a in areas)
                {
                    settingsAreaListView.Items.Add(a.areaName);
                }

            }
        }

        private void RefreshLocationsList(string areaName)
        {
            List<AreaInfo> areas = MongoCRUD.GetInstance().LoadRecords<AreaInfo>("Areas", "areaName", areaName);

            if (areas.Count != 0)
            {
                settingsLocationsListView.Items.Clear();

                foreach (AreaInfo a in areas)
                {
                    foreach (LocationObject loc in a.locationsList)
                    {
                        settingsLocationsListView.Items.Add(loc.locName);
                    }
                }

            }
        }

        private void settingsAreaAddButton_Click(object sender, EventArgs e)
        {
            string areaName = ShowDialog("Enter Area Name", "New Add Area", true);

            if (areaName.Length > 0)
            {

                AreaInfo area = new AreaInfo();
                area.areaName = areaName;

                if (!MongoCRUD.GetInstance().RecordExists<AreaInfo>("Areas", areaName, "areaName"))
                {
                    MongoCRUD.GetInstance().InsertRecord("Areas", area, areaName, null);
                    RefreshAreasList();
                }
            }

        }

        private void settingsLocAddButton_Click(object sender, EventArgs e)
        {
            string locName = ShowDialog("Enter Location Name", "New Add Location", true);
            string areaName = settingsAreaListView.SelectedItems[0].Text;

            if (locName.Length > 0)
            {
                LocationObject lo = new LocationObject();
                lo.locName = locName;

                if (MongoCRUD.GetInstance().RecordExists<AreaInfo>("Areas", areaName, "areaName"))
                {
                    MongoCRUD.GetInstance().AppendRecord<AreaInfo>("Areas", areaName, lo);
                    RefreshLocationsList(settingsAreaListView.SelectedItems[0].Text);
                }
            }

        }

        private void settingsAreaListView_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo HI = settingsAreaListView.HitTest(e.Location);

            settingsAreaListView.Select();
            settingsAreaListView.HideSelection = false;

            settingsAreaLabel.Text = HI.Item.Text;

            RefreshLocationsList(HI.Item.Text);

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
                textBox = new TextBox() { Left = 40,Top = 75, Width = 250 };
                
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

            

            return prompt.ShowDialog() == DialogResult.OK ? textBox!=null ? textBox.Text : "" : "";
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }

    
}
