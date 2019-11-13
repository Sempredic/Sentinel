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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Center);
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
            this.ValidateTab = new System.Windows.Forms.TabPage();
            this.validateInputTabs = new System.Windows.Forms.TabControl();
            this.VerifyTab = new System.Windows.Forms.TabPage();
            this.CheckInTab = new System.Windows.Forms.TabPage();
            this.caseTextBox2 = new System.Windows.Forms.TextBox();
            this.serialTextBox2 = new System.Windows.Forms.TextBox();
            this.areaLocationBox2 = new System.Windows.Forms.TextBox();
            this.ToolsTab = new System.Windows.Forms.TabPage();
            this.SerialInfoTab = new System.Windows.Forms.TabPage();
            this.serialInfoListView = new System.Windows.Forms.ListView();
            this.IDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CaseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurLocHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serialInfoTextBox = new System.Windows.Forms.TextBox();
            this.AgeReportTab = new System.Windows.Forms.TabPage();
            this.AgeReportMainListView = new System.Windows.Forms.ListView();
            this.ageDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ageCaseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ageAgeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ageLocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AgeReportAreaListView = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.ValidateTab.SuspendLayout();
            this.validateInputTabs.SuspendLayout();
            this.VerifyTab.SuspendLayout();
            this.CheckInTab.SuspendLayout();
            this.SerialInfoTab.SuspendLayout();
            this.AgeReportTab.SuspendLayout();
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
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup3.Name = "listViewGroup1";
            this.serialListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
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
            this.tabControl1.Controls.Add(this.ValidateTab);
            this.tabControl1.Controls.Add(this.ToolsTab);
            this.tabControl1.Controls.Add(this.SerialInfoTab);
            this.tabControl1.Controls.Add(this.AgeReportTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 569);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ValidateTab
            // 
            this.ValidateTab.Controls.Add(this.validateInputTabs);
            this.ValidateTab.Controls.Add(this.label2);
            this.ValidateTab.Controls.Add(this.serialListBox);
            this.ValidateTab.Controls.Add(this.numScannedLabel);
            this.ValidateTab.Controls.Add(this.serialListView);
            this.ValidateTab.Controls.Add(this.numUnitsLabel);
            this.ValidateTab.Controls.Add(this.areaComboBox);
            this.ValidateTab.Location = new System.Drawing.Point(4, 22);
            this.ValidateTab.Name = "ValidateTab";
            this.ValidateTab.Padding = new System.Windows.Forms.Padding(3);
            this.ValidateTab.Size = new System.Drawing.Size(885, 543);
            this.ValidateTab.TabIndex = 0;
            this.ValidateTab.Text = "Validate";
            this.ValidateTab.UseVisualStyleBackColor = true;
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
            // caseTextBox2
            // 
            this.caseTextBox2.Location = new System.Drawing.Point(19, 148);
            this.caseTextBox2.Name = "caseTextBox2";
            this.caseTextBox2.Size = new System.Drawing.Size(154, 20);
            this.caseTextBox2.TabIndex = 5;
            this.caseTextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.caseTextBox_KeyDown);
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
            // ToolsTab
            // 
            this.ToolsTab.Location = new System.Drawing.Point(4, 22);
            this.ToolsTab.Name = "ToolsTab";
            this.ToolsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ToolsTab.Size = new System.Drawing.Size(885, 543);
            this.ToolsTab.TabIndex = 1;
            this.ToolsTab.Text = "Tools";
            this.ToolsTab.UseVisualStyleBackColor = true;
            // 
            // SerialInfoTab
            // 
            this.SerialInfoTab.Controls.Add(this.serialInfoListView);
            this.SerialInfoTab.Controls.Add(this.serialInfoTextBox);
            this.SerialInfoTab.Location = new System.Drawing.Point(4, 22);
            this.SerialInfoTab.Name = "SerialInfoTab";
            this.SerialInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.SerialInfoTab.Size = new System.Drawing.Size(885, 543);
            this.SerialInfoTab.TabIndex = 2;
            this.SerialInfoTab.Text = "Serial Info";
            this.SerialInfoTab.UseVisualStyleBackColor = true;
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
            // serialInfoTextBox
            // 
            this.serialInfoTextBox.Location = new System.Drawing.Point(74, 31);
            this.serialInfoTextBox.Name = "serialInfoTextBox";
            this.serialInfoTextBox.Size = new System.Drawing.Size(265, 20);
            this.serialInfoTextBox.TabIndex = 0;
            this.serialInfoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serialInfoTextBox_KeyDown);
            // 
            // AgeReportTab
            // 
            this.AgeReportTab.Controls.Add(this.AgeReportMainListView);
            this.AgeReportTab.Controls.Add(this.AgeReportAreaListView);
            this.AgeReportTab.Location = new System.Drawing.Point(4, 22);
            this.AgeReportTab.Name = "AgeReportTab";
            this.AgeReportTab.Padding = new System.Windows.Forms.Padding(3);
            this.AgeReportTab.Size = new System.Drawing.Size(885, 543);
            this.AgeReportTab.TabIndex = 3;
            this.AgeReportTab.Text = "Age Report";
            this.AgeReportTab.UseVisualStyleBackColor = true;
            // 
            // AgeReportMainListView
            // 
            this.AgeReportMainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ageDateHeader,
            this.ageCaseHeader,
            this.ageAgeHeader,
            this.ageLocationHeader});
            this.AgeReportMainListView.Location = new System.Drawing.Point(206, 78);
            this.AgeReportMainListView.Name = "AgeReportMainListView";
            this.AgeReportMainListView.Size = new System.Drawing.Size(662, 433);
            this.AgeReportMainListView.TabIndex = 1;
            this.AgeReportMainListView.UseCompatibleStateImageBehavior = false;
            this.AgeReportMainListView.View = System.Windows.Forms.View.Details;
            // 
            // ageDateHeader
            // 
            this.ageDateHeader.Text = "Date";
            this.ageDateHeader.Width = 111;
            // 
            // ageCaseHeader
            // 
            this.ageCaseHeader.Text = "Case";
            this.ageCaseHeader.Width = 129;
            // 
            // ageAgeHeader
            // 
            this.ageAgeHeader.Text = "Age";
            this.ageAgeHeader.Width = 270;
            // 
            // ageLocationHeader
            // 
            this.ageLocationHeader.Text = "Location";
            this.ageLocationHeader.Width = 360;
            // 
            // AgeReportAreaListView
            // 
            this.AgeReportAreaListView.Location = new System.Drawing.Point(10, 18);
            this.AgeReportAreaListView.Name = "AgeReportAreaListView";
            this.AgeReportAreaListView.Size = new System.Drawing.Size(190, 493);
            this.AgeReportAreaListView.TabIndex = 0;
            this.AgeReportAreaListView.UseCompatibleStateImageBehavior = false;
            this.AgeReportAreaListView.View = System.Windows.Forms.View.List;
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
            this.ValidateTab.ResumeLayout(false);
            this.ValidateTab.PerformLayout();
            this.validateInputTabs.ResumeLayout(false);
            this.VerifyTab.ResumeLayout(false);
            this.VerifyTab.PerformLayout();
            this.CheckInTab.ResumeLayout(false);
            this.CheckInTab.PerformLayout();
            this.SerialInfoTab.ResumeLayout(false);
            this.SerialInfoTab.PerformLayout();
            this.AgeReportTab.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage ValidateTab;
        private System.Windows.Forms.TabPage ToolsTab;
        private System.Windows.Forms.TabPage SerialInfoTab;
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
        private System.Windows.Forms.TabPage AgeReportTab;
        private System.Windows.Forms.ListView AgeReportMainListView;
        private System.Windows.Forms.ColumnHeader ageDateHeader;
        private System.Windows.Forms.ColumnHeader ageCaseHeader;
        private System.Windows.Forms.ColumnHeader ageAgeHeader;
        private System.Windows.Forms.ColumnHeader ageLocationHeader;
        private System.Windows.Forms.ListView AgeReportAreaListView;
    }
}

