namespace TextFileGUI
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
            lblFirstName = new Label();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtURL = new TextBox();
            lblURL = new Label();
            btnAddNewPerson = new Button();
            lboxPeople = new ListBox();
            btnLoadFromFile = new Button();
            btnSaveToFile = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 6);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(74, 14);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(12, 38);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(74, 14);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(92, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 22);
            txtFirstName.TabIndex = 2;
            txtFirstName.WordWrap = false;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(92, 38);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 22);
            txtLastName.TabIndex = 3;
            txtLastName.WordWrap = false;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(92, 66);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(100, 22);
            txtURL.TabIndex = 4;
            txtURL.WordWrap = false;
            // 
            // lblURL
            // 
            lblURL.AutoSize = true;
            lblURL.Location = new Point(55, 66);
            lblURL.Name = "lblURL";
            lblURL.Size = new Size(31, 14);
            lblURL.TabIndex = 5;
            lblURL.Text = "URL";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.Location = new Point(12, 94);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(180, 23);
            btnAddNewPerson.TabIndex = 6;
            btnAddNewPerson.Text = "Add New Person";
            btnAddNewPerson.UseVisualStyleBackColor = true;
            btnAddNewPerson.Click += btnAddNewPerson_ClickEventHandler;
            // 
            // lboxPeople
            // 
            lboxPeople.FormattingEnabled = true;
            lboxPeople.ItemHeight = 14;
            lboxPeople.Location = new Point(219, 6);
            lboxPeople.Name = "lboxPeople";
            lboxPeople.Size = new Size(268, 270);
            lboxPeople.TabIndex = 7;
            // 
            // btnLoadFromFile
            // 
            btnLoadFromFile.Location = new Point(12, 251);
            btnLoadFromFile.Name = "btnLoadFromFile";
            btnLoadFromFile.Size = new Size(180, 23);
            btnLoadFromFile.TabIndex = 8;
            btnLoadFromFile.Text = "Load from File";
            btnLoadFromFile.UseVisualStyleBackColor = true;
            btnLoadFromFile.Click += FileBtnClicked_EventHandler;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(12, 222);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(180, 23);
            btnSaveToFile.TabIndex = 9;
            btnSaveToFile.Text = "Save to File";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += FileBtnClicked_EventHandler;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 286);
            Controls.Add(btnSaveToFile);
            Controls.Add(btnLoadFromFile);
            Controls.Add(lboxPeople);
            Controls.Add(btnAddNewPerson);
            Controls.Add(lblURL);
            Controls.Add(txtURL);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "People";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtURL;
        private Label lblURL;
        private Button btnAddNewPerson;
        private ListBox lboxPeople;
        private Button btnLoadFromFile;
        private Button btnSaveToFile;
    }
}