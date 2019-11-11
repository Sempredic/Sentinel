namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Center);
            this.areaLocationBox = new System.Windows.Forms.TextBox();
            this.caseTextBox = new System.Windows.Forms.TextBox();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.serialListBox = new System.Windows.Forms.ListBox();
            this.areaComboBox = new System.Windows.Forms.ComboBox();
            this.numUnitsLabel = new System.Windows.Forms.Label();
            this.serialListView = new System.Windows.Forms.ListView();
            this.numScannedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.serialInfoTextBox = new System.Windows.Forms.TextBox();
            this.serialInfoListView = new System.Windows.Forms.ListView();
            this.IDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CaseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurLocHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.validateInputTabs = new System.Windows.Forms.TabControl();
            this.VerifyTab = new System.Windows.Forms.TabPage();
            this.CheckInTab = new System.Windows.Forms.TabPage();
            this.serialTextBox2 = new System.Windows.Forms.TextBox();
            this.areaLocationBox2 = new System.Windows.Forms.TextBox();
            this.caseTextBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.validateInputTabs.SuspendLayout();
            this.VerifyTab.SuspendLayout();
            this.CheckInTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // areaLocationBox
            // 
            this.areaLocationBox.Location = new System.Drawing.Point(20, 95);
            this.areaLocationBox.Name = "areaLocationBox";
            this.areaLocationBox.Size = new System.Drawing.Size(154, 20);
            this.areaLocationBox.TabIndex = 0;
            this.areaLocationBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.areaLocationBox_KeyDown);
            // 
            // caseTextBox
            // 
            this.caseTextBox.Location = new System.Drawing.Point(20, 150);
            this.caseTextBox.Name = "caseTextBox";
            this.caseTextBox.Size = new System.Drawing.Size(154, 20);
            this.caseTextBox.TabIndex = 1;
            this.caseTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.caseTextBox_KeyDown);
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(20, 201);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(154, 20);
            this.serialTextBox.TabIndex = 2;
            this.serialTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serialTextBox_KeyDown);
            // 
            // serialListBox
            // 
            this.serialListBox.FormattingEnabled = true;
            this.serialListBox.Location = new System.Drawing.Point(247, 115);
            this.serialListBox.Name = "serialListBox";
            this.serialListBox.Size = new System.Drawing.Size(165, 277);
            this.serialListBox.TabIndex = 3;
            // 
            // areaComboBox
            // 
            this.areaComboBox.FormattingEnabled = true;
            this.areaComboBox.Location = new System.Drawing.Point(20, 14);
            this.areaComboBox.Name = "areaComboBox";
            this.areaComboBox.Size = new System.Drawing.Size(154, 21);
            this.areaComboBox.TabIndex = 5;
            // 
            // numUnitsLabel
            // 
            this.numUnitsLabel.AutoSize = true;
            this.numUnitsLabel.Location = new System.Drawing.Point(399, 99);
            this.numUnitsLabel.Name = "numUnitsLabel";
            this.numUnitsLabel.Size = new System.Drawing.Size(13, 13);
            this.numUnitsLabel.TabIndex = 7;
            this.numUnitsLabel.Text = "0";
            // 
            // serialListView
            // 
            listViewGroup9.Header = "ListViewGroup";
            listViewGroup9.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup9.Name = "listViewGroup1";
            this.serialListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup9});
            this.serialListView.HideSelection = false;
            this.serialListView.Location = new System.Drawing.Point(499, 116);
            this.serialListView.Name = "serialListView";
            this.serialListView.Size = new System.Drawing.Size(195, 276);
            this.serialListView.TabIndex = 8;
            this.serialListView.UseCompatibleStateImageBehavior = false;
            this.serialListView.View = System.Windows.Forms.View.List;
            // 
            // numScannedLabel
            // 
            this.numScannedLabel.AutoSize = true;
            this.numScannedLabel.Location = new System.Drawing.Point(361, 99);
            this.numScannedLabel.Name = "numScannedLabel";
            this.numScannedLabel.Size = new System.Drawing.Size(13, 13);
            this.numScannedLabel.TabIndex = 9;
            this.numScannedLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "/";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 596);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.validateInputTabs);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.serialListBox);
            this.tabPage1.Controls.Add(this.numScannedLabel);
            this.tabPage1.Controls.Add(this.serialListView);
            this.tabPage1.Controls.Add(this.numUnitsLabel);
            this.tabPage1.Controls.Add(this.areaComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.serialInfoListView);
            this.tabPage3.Controls.Add(this.serialInfoTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(885, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // serialInfoTextBox
            // 
            this.serialInfoTextBox.Location = new System.Drawing.Point(74, 31);
            this.serialInfoTextBox.Name = "serialInfoTextBox";
            this.serialInfoTextBox.Size = new System.Drawing.Size(265, 20);
            this.serialInfoTextBox.TabIndex = 0;
            this.serialInfoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serialInfoTextBox_KeyDown);
            // 
            // serialInfoListView
            // 
            this.serialInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDHeader,
            this.DateHeader,
            this.CaseHeader,
            this.LocationHeader,
            this.UserHeader,
            this.TimeHeader,
            this.CurLocHeader});
            this.serialInfoListView.HideSelection = false;
            this.serialInfoListView.Location = new System.Drawing.Point(74, 108);
            this.serialInfoListView.Name = "serialInfoListView";
            this.serialInfoListView.Size = new System.Drawing.Size(718, 258);
            this.serialInfoListView.TabIndex = 1;
            this.serialInfoListView.UseCompatibleStateImageBehavior = false;
            this.serialInfoListView.View = System.Windows.Forms.View.Details;
            // 
            // IDHeader
            // 
            this.IDHeader.Text = "ID";
            // 
            // DateHeader
            // 
            this.DateHeader.Text = "Date";
            this.DateHeader.Width = 69;
            // 
            // CaseHeader
            // 
            this.CaseHeader.Text = "Case";
            this.CaseHeader.Width = 84;
            // 
            // LocationHeader
            // 
            this.LocationHeader.Text = "Location";
            this.LocationHeader.Width = 109;
            // 
            // UserHeader
            // 
            this.UserHeader.Text = "UserID";
            this.UserHeader.Width = 75;
            // 
            // TimeHeader
            // 
            this.TimeHeader.Text = "Time";
            this.TimeHeader.Width = 70;
            // 
            // CurLocHeader
            // 
            this.CurLocHeader.Text = "CurrentLocation";
            this.CurLocHeader.Width = 228;
            // 
            // validateInputTabs
            // 
            this.validateInputTabs.Controls.Add(this.VerifyTab);
            this.validateInputTabs.Controls.Add(this.CheckInTab);
            this.validateInputTabs.Location = new System.Drawing.Point(6, 115);
            this.validateInputTabs.Name = "validateInputTabs";
            this.validateInputTabs.SelectedIndex = 0;
            this.validateInputTabs.Size = new System.Drawing.Size(200, 277);
            this.validateInputTabs.TabIndex = 11;
            this.validateInputTabs.Tag = "";
            this.validateInputTabs.SelectedIndexChanged += new System.EventHandler(this.validateInputTabs_SelectedIndexChanged);
            // 
            // VerifyTab
            // 
            this.VerifyTab.Controls.Add(this.caseTextBox);
            this.VerifyTab.Controls.Add(this.serialTextBox);
            this.VerifyTab.Controls.Add(this.areaLocationBox);
            this.VerifyTab.Location = new System.Drawing.Point(4, 22);
            this.VerifyTab.Name = "VerifyTab";
            this.VerifyTab.Padding = new System.Windows.Forms.Padding(3);
            this.VerifyTab.Size = new System.Drawing.Size(192, 251);
            this.VerifyTab.TabIndex = 0;
            this.VerifyTab.Text = "Verify";
            this.VerifyTab.UseVisualStyleBackColor = true;
            // 
            // CheckInTab
            // 
            this.CheckInTab.Controls.Add(this.caseTextBox2);
            this.CheckInTab.Controls.Add(this.serialTextBox2);
            this.CheckInTab.Controls.Add(this.areaLocationBox2);
            this.CheckInTab.Location = new System.Drawing.Point(4, 22);
            this.CheckInTab.Name = "CheckInTab";
            this.CheckInTab.Padding = new System.Windows.Forms.Padding(3);
            this.CheckInTab.Size = new System.Drawing.Size(192, 251);
            this.CheckInTab.TabIndex = 1;
            this.CheckInTab.Text = "CheckIn";
            this.CheckInTab.UseVisualStyleBackColor = true;
            // 
            // serialTextBox2
            // 
            this.serialTextBox2.Location = new System.Drawing.Point(19, 201);
            this.serialTextBox2.Name = "serialTextBox2";
            this.serialTextBox2.Size = new System.Drawing.Size(154, 20);
            this.serialTextBox2.TabIndex = 4;
            this.serialTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serialTextBox_KeyDown);
            // 
            // areaLocationBox2
            // 
            this.areaLocationBox2.Location = new System.Drawing.Point(19, 95);
            this.areaLocationBox2.Name = "areaLocationBox2";
            this.areaLocationBox2.Size = new System.Drawing.Size(154, 20);
            this.areaLocationBox2.TabIndex = 3;
            this.areaLocationBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.areaLocationBox_KeyDown);
            // 
            // caseTextBox2
            // 
            this.caseTextBox2.Location = new System.Drawing.Point(19, 148);
            this.caseTextBox2.Name = "caseTextBox2";
            this.caseTextBox2.Size = new System.Drawing.Size(154, 20);
            this.caseTextBox2.TabIndex = 5;
            this.caseTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.caseTextBox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 610);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.validateInputTabs.ResumeLayout(false);
            this.VerifyTab.ResumeLayout(false);
            this.VerifyTab.PerformLayout();
            this.CheckInTab.ResumeLayout(false);
            this.CheckInTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox areaLocationBox;
        private System.Windows.Forms.TextBox caseTextBox;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.ListBox serialListBox;
        private System.Windows.Forms.ComboBox areaComboBox;
        private System.Windows.Forms.Label numUnitsLabel;
        private System.Windows.Forms.ListView serialListView;
        private System.Windows.Forms.Label numScannedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox serialInfoTextBox;
        private System.Windows.Forms.ListView serialInfoListView;
        private System.Windows.Forms.ColumnHeader IDHeader;
        private System.Windows.Forms.ColumnHeader DateHeader;
        private System.Windows.Forms.ColumnHeader CaseHeader;
        private System.Windows.Forms.ColumnHeader LocationHeader;
        private System.Windows.Forms.ColumnHeader UserHeader;
        private System.Windows.Forms.ColumnHeader TimeHeader;
        private System.Windows.Forms.ColumnHeader CurLocHeader;
        private System.Windows.Forms.TabControl validateInputTabs;
        private System.Windows.Forms.TabPage VerifyTab;
        private System.Windows.Forms.TabPage CheckInTab;
        private System.Windows.Forms.TextBox caseTextBox2;
        private System.Windows.Forms.TextBox serialTextBox2;
        private System.Windows.Forms.TextBox areaLocationBox2;
    }
}

