namespace CST_150_DogClass.PresentationLayer
{
    partial class FrmMain
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
            btnAddDog = new Button();
            lblName = new Label();
            lblNeck = new Label();
            lblSitting = new Label();
            lblColor = new Label();
            txtName = new TextBox();
            txtNeck = new TextBox();
            cmbSit = new ComboBox();
            txtColor = new TextBox();
            lblInches = new Label();
            grbAttributes = new GroupBox();
            lblPounds = new Label();
            txtWeight = new TextBox();
            lblWeight = new Label();
            gvShowDogs = new DataGridView();
            lblErrorMessage = new Label();
            grbAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvShowDogs).BeginInit();
            SuspendLayout();
            // 
            // btnAddDog
            // 
            btnAddDog.AutoSize = true;
            btnAddDog.Location = new Point(171, 76);
            btnAddDog.Name = "btnAddDog";
            btnAddDog.Size = new Size(116, 28);
            btnAddDog.TabIndex = 0;
            btnAddDog.Text = "Add New Dog";
            btnAddDog.UseVisualStyleBackColor = true;
            btnAddDog.Click += BtnAddNewDogClickEvent;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(21, 79);
            lblName.Name = "lblName";
            lblName.Size = new Size(88, 18);
            lblName.TabIndex = 1;
            lblName.Text = "Dog Name:";
            // 
            // lblNeck
            // 
            lblNeck.AutoSize = true;
            lblNeck.Location = new Point(8, 128);
            lblNeck.Name = "lblNeck";
            lblNeck.Size = new Size(101, 18);
            lblNeck.TabIndex = 2;
            lblNeck.Text = "Neck Radius:";
            // 
            // lblSitting
            // 
            lblSitting.AutoSize = true;
            lblSitting.Location = new Point(53, 174);
            lblSitting.Name = "lblSitting";
            lblSitting.Size = new Size(56, 18);
            lblSitting.TabIndex = 3;
            lblSitting.Text = "Sitting:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(59, 215);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(50, 18);
            lblColor.TabIndex = 4;
            lblColor.Text = "Color:";
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 26);
            txtName.TabIndex = 5;
            // 
            // txtNeck
            // 
            txtNeck.Location = new Point(115, 125);
            txtNeck.Name = "txtNeck";
            txtNeck.Size = new Size(121, 26);
            txtNeck.TabIndex = 6;
            // 
            // cmbSit
            // 
            cmbSit.FormattingEnabled = true;
            cmbSit.Items.AddRange(new object[] { "Yes", "No" });
            cmbSit.Location = new Point(115, 174);
            cmbSit.Name = "cmbSit";
            cmbSit.Size = new Size(121, 26);
            cmbSit.TabIndex = 7;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(115, 215);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(121, 26);
            txtColor.TabIndex = 8;
            // 
            // lblInches
            // 
            lblInches.AutoSize = true;
            lblInches.Location = new Point(242, 128);
            lblInches.Name = "lblInches";
            lblInches.Size = new Size(53, 18);
            lblInches.TabIndex = 9;
            lblInches.Text = "inches";
            // 
            // grbAttributes
            // 
            grbAttributes.Controls.Add(lblPounds);
            grbAttributes.Controls.Add(txtWeight);
            grbAttributes.Controls.Add(lblWeight);
            grbAttributes.Controls.Add(txtColor);
            grbAttributes.Controls.Add(lblInches);
            grbAttributes.Controls.Add(lblName);
            grbAttributes.Controls.Add(lblNeck);
            grbAttributes.Controls.Add(cmbSit);
            grbAttributes.Controls.Add(lblSitting);
            grbAttributes.Controls.Add(txtNeck);
            grbAttributes.Controls.Add(lblColor);
            grbAttributes.Controls.Add(txtName);
            grbAttributes.Location = new Point(51, 110);
            grbAttributes.Name = "grbAttributes";
            grbAttributes.Size = new Size(303, 308);
            grbAttributes.TabIndex = 10;
            grbAttributes.TabStop = false;
            grbAttributes.Text = "Dog Attributes";
            // 
            // lblPounds
            // 
            lblPounds.AutoSize = true;
            lblPounds.Location = new Point(242, 260);
            lblPounds.Name = "lblPounds";
            lblPounds.Size = new Size(32, 18);
            lblPounds.TabIndex = 12;
            lblPounds.Text = "lbs.";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(115, 257);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(121, 26);
            txtWeight.TabIndex = 11;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(48, 260);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(61, 18);
            lblWeight.TabIndex = 10;
            lblWeight.Text = "Weight:";
            // 
            // gvShowDogs
            // 
            gvShowDogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvShowDogs.Location = new Point(391, 76);
            gvShowDogs.Name = "gvShowDogs";
            gvShowDogs.RowTemplate.Height = 25;
            gvShowDogs.Size = new Size(600, 342);
            gvShowDogs.TabIndex = 11;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(41, 421);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(324, 18);
            lblErrorMessage.TabIndex = 12;
            lblErrorMessage.Text = "Please Fix Incorrect Data Entry and Try Again.";
            lblErrorMessage.Visible = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 540);
            Controls.Add(lblErrorMessage);
            Controls.Add(gvShowDogs);
            Controls.Add(grbAttributes);
            Controls.Add(btnAddDog);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMainLoadEventHandler;
            grbAttributes.ResumeLayout(false);
            grbAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvShowDogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddDog;
        private Label lblName;
        private Label lblNeck;
        private Label lblSitting;
        private Label lblColor;
        private TextBox txtName;
        private TextBox txtNeck;
        private ComboBox cmbSit;
        private TextBox txtColor;
        private Label lblInches;
        private GroupBox grbAttributes;
        private DataGridView gvShowDogs;
        private Label lblPounds;
        private TextBox txtWeight;
        private Label lblWeight;
        private Label lblErrorMessage;
    }
}