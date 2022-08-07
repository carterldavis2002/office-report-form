namespace OfficeReportForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioQuit = new System.Windows.Forms.RadioButton();
            this.radioPrintList = new System.Windows.Forms.RadioButton();
            this.radioSearchOffice = new System.Windows.Forms.RadioButton();
            this.radioSortList = new System.Windows.Forms.RadioButton();
            this.radioSearchName = new System.Windows.Forms.RadioButton();
            this.radioSearchTelephone = new System.Windows.Forms.RadioButton();
            this.radioChangeOffice = new System.Windows.Forms.RadioButton();
            this.radioAddEntry = new System.Windows.Forms.RadioButton();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.OfficeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.InputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OutputListView = new System.Windows.Forms.ListView();
            this.ChangeFileButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioQuit);
            this.groupBox1.Controls.Add(this.radioPrintList);
            this.groupBox1.Controls.Add(this.radioSearchOffice);
            this.groupBox1.Controls.Add(this.radioSortList);
            this.groupBox1.Controls.Add(this.radioSearchName);
            this.groupBox1.Controls.Add(this.radioSearchTelephone);
            this.groupBox1.Controls.Add(this.radioChangeOffice);
            this.groupBox1.Controls.Add(this.radioAddEntry);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose an action w/ text as input";
            // 
            // radioQuit
            // 
            this.radioQuit.AutoSize = true;
            this.radioQuit.Location = new System.Drawing.Point(6, 236);
            this.radioQuit.Name = "radioQuit";
            this.radioQuit.Size = new System.Drawing.Size(58, 24);
            this.radioQuit.TabIndex = 1;
            this.radioQuit.TabStop = true;
            this.radioQuit.Text = "Quit";
            this.radioQuit.UseVisualStyleBackColor = true;
            this.radioQuit.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioPrintList
            // 
            this.radioPrintList.AutoSize = true;
            this.radioPrintList.Location = new System.Drawing.Point(6, 26);
            this.radioPrintList.Name = "radioPrintList";
            this.radioPrintList.Size = new System.Drawing.Size(108, 24);
            this.radioPrintList.TabIndex = 0;
            this.radioPrintList.TabStop = true;
            this.radioPrintList.Text = "Print the list";
            this.radioPrintList.UseVisualStyleBackColor = true;
            this.radioPrintList.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioSearchOffice
            // 
            this.radioSearchOffice.AutoSize = true;
            this.radioSearchOffice.Location = new System.Drawing.Point(6, 116);
            this.radioSearchOffice.Name = "radioSearchOffice";
            this.radioSearchOffice.Size = new System.Drawing.Size(214, 24);
            this.radioSearchOffice.TabIndex = 1;
            this.radioSearchOffice.TabStop = true;
            this.radioSearchOffice.Text = "Search for an office number";
            this.radioSearchOffice.UseVisualStyleBackColor = true;
            this.radioSearchOffice.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioSortList
            // 
            this.radioSortList.AutoSize = true;
            this.radioSortList.Location = new System.Drawing.Point(6, 206);
            this.radioSortList.Name = "radioSortList";
            this.radioSortList.Size = new System.Drawing.Size(176, 24);
            this.radioSortList.TabIndex = 4;
            this.radioSortList.TabStop = true;
            this.radioSortList.Text = "Sort the list (by name)";
            this.radioSortList.UseVisualStyleBackColor = true;
            this.radioSortList.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioSearchName
            // 
            this.radioSearchName.AutoSize = true;
            this.radioSearchName.Location = new System.Drawing.Point(6, 86);
            this.radioSearchName.Name = "radioSearchName";
            this.radioSearchName.Size = new System.Drawing.Size(150, 24);
            this.radioSearchName.TabIndex = 2;
            this.radioSearchName.TabStop = true;
            this.radioSearchName.Text = "Search for a name";
            this.radioSearchName.UseVisualStyleBackColor = true;
            this.radioSearchName.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioSearchTelephone
            // 
            this.radioSearchTelephone.AutoSize = true;
            this.radioSearchTelephone.Location = new System.Drawing.Point(6, 146);
            this.radioSearchTelephone.Name = "radioSearchTelephone";
            this.radioSearchTelephone.Size = new System.Drawing.Size(235, 24);
            this.radioSearchTelephone.TabIndex = 1;
            this.radioSearchTelephone.TabStop = true;
            this.radioSearchTelephone.Text = "Search for a telephone number";
            this.radioSearchTelephone.UseVisualStyleBackColor = true;
            this.radioSearchTelephone.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioChangeOffice
            // 
            this.radioChangeOffice.AutoSize = true;
            this.radioChangeOffice.Location = new System.Drawing.Point(6, 176);
            this.radioChangeOffice.Name = "radioChangeOffice";
            this.radioChangeOffice.Size = new System.Drawing.Size(197, 24);
            this.radioChangeOffice.TabIndex = 3;
            this.radioChangeOffice.TabStop = true;
            this.radioChangeOffice.Text = "Change an office number";
            this.radioChangeOffice.UseVisualStyleBackColor = true;
            this.radioChangeOffice.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // radioAddEntry
            // 
            this.radioAddEntry.AutoSize = true;
            this.radioAddEntry.Location = new System.Drawing.Point(6, 56);
            this.radioAddEntry.Name = "radioAddEntry";
            this.radioAddEntry.Size = new System.Drawing.Size(115, 24);
            this.radioAddEntry.TabIndex = 1;
            this.radioAddEntry.TabStop = true;
            this.radioAddEntry.Text = "Add an entry";
            this.radioAddEntry.UseVisualStyleBackColor = true;
            this.radioAddEntry.CheckedChanged += new System.EventHandler(this.RadioButtons_CheckedChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(263, 35);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(120, 27);
            this.NameTextBox.TabIndex = 1;
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Location = new System.Drawing.Point(263, 158);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(120, 27);
            this.TelephoneTextBox.TabIndex = 2;
            // 
            // OfficeTextBox
            // 
            this.OfficeTextBox.Location = new System.Drawing.Point(263, 98);
            this.OfficeTextBox.Name = "OfficeTextBox";
            this.OfficeTextBox.Size = new System.Drawing.Size(120, 27);
            this.OfficeTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Office #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telephone #";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(557, 41);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(159, 89);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // InputFileDialog
            // 
            this.InputFileDialog.Filter = "Text files (*txt)|*.txt";
            this.InputFileDialog.Title = "Open a text data file";
            this.InputFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.InputFileDialog_FileOk);
            // 
            // OutputListView
            // 
            this.OutputListView.Location = new System.Drawing.Point(12, 317);
            this.OutputListView.Name = "OutputListView";
            this.OutputListView.Size = new System.Drawing.Size(776, 121);
            this.OutputListView.TabIndex = 10;
            this.OutputListView.UseCompatibleStateImageBehavior = false;
            this.OutputListView.View = System.Windows.Forms.View.Details;
            this.OutputListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.OutputListView_ColumnWidthChanging);
            // 
            // ChangeFileButton
            // 
            this.ChangeFileButton.Location = new System.Drawing.Point(557, 158);
            this.ChangeFileButton.Name = "ChangeFileButton";
            this.ChangeFileButton.Size = new System.Drawing.Size(159, 89);
            this.ChangeFileButton.TabIndex = 11;
            this.ChangeFileButton.Text = "Change Data File";
            this.ChangeFileButton.UseVisualStyleBackColor = true;
            this.ChangeFileButton.Click += new System.EventHandler(this.ChangeFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeFileButton);
            this.Controls.Add(this.OutputListView);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OfficeTextBox);
            this.Controls.Add(this.TelephoneTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Office Reporter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioQuit;
        private RadioButton radioSortList;
        private RadioButton radioChangeOffice;
        private RadioButton radioSearchTelephone;
        private RadioButton radioSearchOffice;
        private RadioButton radioSearchName;
        private RadioButton radioAddEntry;
        private RadioButton radioPrintList;
        private TextBox NameTextBox;
        private TextBox TelephoneTextBox;
        private TextBox OfficeTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ClearButton;
        private OpenFileDialog InputFileDialog;
        private ListView OutputListView;
        private Button ChangeFileButton;
    }
}