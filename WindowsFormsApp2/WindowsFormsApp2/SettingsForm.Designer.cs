namespace WindowsFormsApp2
{
    partial class SettingsForm
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
            this.settingsAreaListView = new System.Windows.Forms.ListView();
            this.Areas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.settingsAddAreaButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.settingsLocRemoveButton = new System.Windows.Forms.Button();
            this.settingsLocAddButton = new System.Windows.Forms.Button();
            this.settingsLocationsListView = new System.Windows.Forms.ListView();
            this.settingsOkButton = new System.Windows.Forms.Button();
            this.settingsAreaLabel = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsAreaListView
            // 
            this.settingsAreaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Areas});
            this.settingsAreaListView.Location = new System.Drawing.Point(23, 56);
            this.settingsAreaListView.Name = "settingsAreaListView";
            this.settingsAreaListView.Size = new System.Drawing.Size(138, 259);
            this.settingsAreaListView.TabIndex = 0;
            this.settingsAreaListView.UseCompatibleStateImageBehavior = false;
            this.settingsAreaListView.View = System.Windows.Forms.View.Details;
            this.settingsAreaListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.settingsAreaListView_MouseClick);
            // 
            // Areas
            // 
            this.Areas.Text = "Areas";
            this.Areas.Width = 130;
            // 
            // settingsAddAreaButton
            // 
            this.settingsAddAreaButton.Location = new System.Drawing.Point(167, 56);
            this.settingsAddAreaButton.Name = "settingsAddAreaButton";
            this.settingsAddAreaButton.Size = new System.Drawing.Size(75, 23);
            this.settingsAddAreaButton.TabIndex = 1;
            this.settingsAddAreaButton.Text = "Add";
            this.settingsAddAreaButton.UseVisualStyleBackColor = true;
            this.settingsAddAreaButton.Click += new System.EventHandler(this.settingsAreaAddButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remove Area";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.settingsLocRemoveButton);
            this.groupBox1.Controls.Add(this.settingsLocAddButton);
            this.groupBox1.Controls.Add(this.settingsLocationsListView);
            this.groupBox1.Location = new System.Drawing.Point(261, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 259);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locations";
            // 
            // settingsLocRemoveButton
            // 
            this.settingsLocRemoveButton.Location = new System.Drawing.Point(114, 221);
            this.settingsLocRemoveButton.Name = "settingsLocRemoveButton";
            this.settingsLocRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.settingsLocRemoveButton.TabIndex = 2;
            this.settingsLocRemoveButton.Text = "Remove";
            this.settingsLocRemoveButton.UseVisualStyleBackColor = true;
            // 
            // settingsLocAddButton
            // 
            this.settingsLocAddButton.Location = new System.Drawing.Point(15, 221);
            this.settingsLocAddButton.Name = "settingsLocAddButton";
            this.settingsLocAddButton.Size = new System.Drawing.Size(75, 23);
            this.settingsLocAddButton.TabIndex = 1;
            this.settingsLocAddButton.Text = "Add";
            this.settingsLocAddButton.UseVisualStyleBackColor = true;
            this.settingsLocAddButton.Click += new System.EventHandler(this.settingsLocAddButton_Click);
            // 
            // settingsLocationsListView
            // 
            this.settingsLocationsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.settingsLocationsListView.Location = new System.Drawing.Point(15, 19);
            this.settingsLocationsListView.Name = "settingsLocationsListView";
            this.settingsLocationsListView.Size = new System.Drawing.Size(174, 196);
            this.settingsLocationsListView.TabIndex = 0;
            this.settingsLocationsListView.UseCompatibleStateImageBehavior = false;
            this.settingsLocationsListView.View = System.Windows.Forms.View.Details;
            // 
            // settingsOkButton
            // 
            this.settingsOkButton.Location = new System.Drawing.Point(375, 332);
            this.settingsOkButton.Name = "settingsOkButton";
            this.settingsOkButton.Size = new System.Drawing.Size(75, 23);
            this.settingsOkButton.TabIndex = 6;
            this.settingsOkButton.Text = "Ok";
            this.settingsOkButton.UseVisualStyleBackColor = true;
            // 
            // settingsAreaLabel
            // 
            this.settingsAreaLabel.AutoSize = true;
            this.settingsAreaLabel.Location = new System.Drawing.Point(340, 40);
            this.settingsAreaLabel.Name = "settingsAreaLabel";
            this.settingsAreaLabel.Size = new System.Drawing.Size(0, 13);
            this.settingsAreaLabel.TabIndex = 7;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 170;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 367);
            this.Controls.Add(this.settingsAreaLabel);
            this.Controls.Add(this.settingsOkButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.settingsAddAreaButton);
            this.Controls.Add(this.settingsAreaListView);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView settingsAreaListView;
        private System.Windows.Forms.Button settingsAddAreaButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button settingsLocRemoveButton;
        private System.Windows.Forms.Button settingsLocAddButton;
        private System.Windows.Forms.ListView settingsLocationsListView;
        private System.Windows.Forms.Button settingsOkButton;
        private System.Windows.Forms.ColumnHeader Areas;
        private System.Windows.Forms.Label settingsAreaLabel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}