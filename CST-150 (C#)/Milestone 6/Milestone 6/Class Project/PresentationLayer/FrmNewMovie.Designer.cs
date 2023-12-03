namespace Class_Project.PresentationLayer
{
    partial class FrmNewMovie
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
            lblName = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtRuntime = new TextBox();
            lblRuntime = new Label();
            lblRating = new Label();
            txtReleaseYear = new TextBox();
            lblReleaseYear = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            lblDescription = new Label();
            txtScore = new TextBox();
            lblAudienceScore = new Label();
            cbRating = new ComboBox();
            gbMovieAttributes = new GroupBox();
            lblErrorName = new Label();
            lblErrorRating = new Label();
            lblErrorScore = new Label();
            lblErrorReleaseYear = new Label();
            lblErrorQuantity = new Label();
            lblErrorRuntime = new Label();
            lblErrorPrice = new Label();
            txtDescription = new TextBox();
            btnClearForm = new Button();
            btnSubmit = new Button();
            gbMovieAttributes.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(28, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(129, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Movie Title";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(163, 18);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Movie name";
            txtName.Size = new Size(129, 22);
            txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(163, 76);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price in dollars";
            txtPrice.Size = new Size(129, 22);
            txtPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(93, 76);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(64, 23);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRuntime
            // 
            txtRuntime.Location = new Point(163, 141);
            txtRuntime.Name = "txtRuntime";
            txtRuntime.PlaceholderText = "Length in minutes";
            txtRuntime.Size = new Size(129, 22);
            txtRuntime.TabIndex = 5;
            // 
            // lblRuntime
            // 
            lblRuntime.AutoSize = true;
            lblRuntime.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRuntime.Location = new Point(55, 141);
            lblRuntime.Name = "lblRuntime";
            lblRuntime.Size = new Size(102, 23);
            lblRuntime.TabIndex = 4;
            lblRuntime.Text = "Runtime";
            lblRuntime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRating.Location = new Point(76, 311);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(81, 23);
            lblRating.TabIndex = 10;
            lblRating.Text = "Rating";
            lblRating.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(163, 257);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.PlaceholderText = "Year of release";
            txtReleaseYear.Size = new Size(129, 22);
            txtReleaseYear.TabIndex = 9;
            // 
            // lblReleaseYear
            // 
            lblReleaseYear.AutoSize = true;
            lblReleaseYear.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblReleaseYear.Location = new Point(6, 257);
            lblReleaseYear.Name = "lblReleaseYear";
            lblReleaseYear.Size = new Size(151, 23);
            lblReleaseYear.TabIndex = 8;
            lblReleaseYear.Text = "Release Year";
            lblReleaseYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(163, 200);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Amount in stock";
            txtQuantity.Size = new Size(129, 22);
            txtQuantity.TabIndex = 7;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(53, 200);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(104, 23);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity";
            lblQuantity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescription.Location = new Point(561, 17);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(133, 23);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description";
            lblDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(163, 368);
            txtScore.Name = "txtScore";
            txtScore.PlaceholderText = "Score from 1-10";
            txtScore.Size = new Size(129, 22);
            txtScore.TabIndex = 14;
            // 
            // lblAudienceScore
            // 
            lblAudienceScore.AutoSize = true;
            lblAudienceScore.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAudienceScore.Location = new Point(87, 368);
            lblAudienceScore.Name = "lblAudienceScore";
            lblAudienceScore.Size = new Size(70, 23);
            lblAudienceScore.TabIndex = 13;
            lblAudienceScore.Text = "Score";
            lblAudienceScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbRating
            // 
            cbRating.FormattingEnabled = true;
            cbRating.Items.AddRange(new object[] { "G", "PG", "PG-13", "R", "NR" });
            cbRating.Location = new Point(163, 315);
            cbRating.Name = "cbRating";
            cbRating.Size = new Size(129, 22);
            cbRating.TabIndex = 15;
            // 
            // gbMovieAttributes
            // 
            gbMovieAttributes.Controls.Add(lblErrorName);
            gbMovieAttributes.Controls.Add(lblErrorRating);
            gbMovieAttributes.Controls.Add(lblErrorScore);
            gbMovieAttributes.Controls.Add(lblErrorReleaseYear);
            gbMovieAttributes.Controls.Add(lblErrorQuantity);
            gbMovieAttributes.Controls.Add(lblErrorRuntime);
            gbMovieAttributes.Controls.Add(lblErrorPrice);
            gbMovieAttributes.Controls.Add(txtDescription);
            gbMovieAttributes.Controls.Add(lblName);
            gbMovieAttributes.Controls.Add(lblDescription);
            gbMovieAttributes.Controls.Add(cbRating);
            gbMovieAttributes.Controls.Add(txtName);
            gbMovieAttributes.Controls.Add(txtScore);
            gbMovieAttributes.Controls.Add(lblPrice);
            gbMovieAttributes.Controls.Add(lblAudienceScore);
            gbMovieAttributes.Controls.Add(txtPrice);
            gbMovieAttributes.Controls.Add(lblRuntime);
            gbMovieAttributes.Controls.Add(lblRating);
            gbMovieAttributes.Controls.Add(txtRuntime);
            gbMovieAttributes.Controls.Add(txtReleaseYear);
            gbMovieAttributes.Controls.Add(lblQuantity);
            gbMovieAttributes.Controls.Add(lblReleaseYear);
            gbMovieAttributes.Controls.Add(txtQuantity);
            gbMovieAttributes.Location = new Point(12, 12);
            gbMovieAttributes.Name = "gbMovieAttributes";
            gbMovieAttributes.Size = new Size(890, 396);
            gbMovieAttributes.TabIndex = 16;
            gbMovieAttributes.TabStop = false;
            gbMovieAttributes.Text = "New Movie Fields";
            // 
            // lblErrorName
            // 
            lblErrorName.AutoSize = true;
            lblErrorName.ForeColor = Color.IndianRed;
            lblErrorName.Location = new Point(298, 21);
            lblErrorName.Name = "lblErrorName";
            lblErrorName.Size = new Size(88, 14);
            lblErrorName.TabIndex = 24;
            lblErrorName.Text = "lblErrorName";
            lblErrorName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblErrorRating
            // 
            lblErrorRating.AutoSize = true;
            lblErrorRating.ForeColor = Color.IndianRed;
            lblErrorRating.Location = new Point(298, 318);
            lblErrorRating.Name = "lblErrorRating";
            lblErrorRating.Size = new Size(92, 14);
            lblErrorRating.TabIndex = 23;
            lblErrorRating.Text = "lblErrorRating";
            lblErrorRating.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblErrorScore
            // 
            lblErrorScore.AutoSize = true;
            lblErrorScore.ForeColor = Color.IndianRed;
            lblErrorScore.Location = new Point(298, 371);
            lblErrorScore.Name = "lblErrorScore";
            lblErrorScore.Size = new Size(87, 14);
            lblErrorScore.TabIndex = 22;
            lblErrorScore.Text = "lblErrorScore";
            lblErrorScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblErrorReleaseYear
            // 
            lblErrorReleaseYear.AutoSize = true;
            lblErrorReleaseYear.ForeColor = Color.IndianRed;
            lblErrorReleaseYear.Location = new Point(298, 260);
            lblErrorReleaseYear.Name = "lblErrorReleaseYear";
            lblErrorReleaseYear.Size = new Size(129, 14);
            lblErrorReleaseYear.TabIndex = 21;
            lblErrorReleaseYear.Text = "lblErrorReleaseYear";
            lblErrorReleaseYear.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblErrorQuantity
            // 
            lblErrorQuantity.AutoSize = true;
            lblErrorQuantity.ForeColor = Color.IndianRed;
            lblErrorQuantity.Location = new Point(298, 203);
            lblErrorQuantity.Name = "lblErrorQuantity";
            lblErrorQuantity.Size = new Size(106, 14);
            lblErrorQuantity.TabIndex = 20;
            lblErrorQuantity.Text = "lblErrorQuantity";
            lblErrorQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblErrorRuntime
            // 
            lblErrorRuntime.AutoSize = true;
            lblErrorRuntime.ForeColor = Color.IndianRed;
            lblErrorRuntime.Location = new Point(298, 144);
            lblErrorRuntime.Name = "lblErrorRuntime";
            lblErrorRuntime.Size = new Size(103, 14);
            lblErrorRuntime.TabIndex = 19;
            lblErrorRuntime.Text = "lblErrorRuntime";
            lblErrorRuntime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblErrorPrice
            // 
            lblErrorPrice.AutoSize = true;
            lblErrorPrice.ForeColor = Color.IndianRed;
            lblErrorPrice.Location = new Point(298, 79);
            lblErrorPrice.Name = "lblErrorPrice";
            lblErrorPrice.Size = new Size(82, 14);
            lblErrorPrice.TabIndex = 18;
            lblErrorPrice.Text = "lblErrorPrice";
            lblErrorPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(561, 43);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Enter movie description";
            txtDescription.Size = new Size(323, 347);
            txtDescription.TabIndex = 17;
            // 
            // btnClearForm
            // 
            btnClearForm.Enabled = false;
            btnClearForm.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearForm.Location = new Point(573, 414);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(133, 32);
            btnClearForm.TabIndex = 17;
            btnClearForm.Text = "Clear Form";
            btnClearForm.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(771, 414);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(125, 32);
            btnSubmit.TabIndex = 18;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += BtnSubmit_ClickEventHandler;
            // 
            // FrmNewMovie
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 477);
            Controls.Add(btnSubmit);
            Controls.Add(btnClearForm);
            Controls.Add(gbMovieAttributes);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmNewMovie";
            Text = "Create New Movie";
            gbMovieAttributes.ResumeLayout(false);
            gbMovieAttributes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtRuntime;
        private Label lblRuntime;
        private Label lblRating;
        private TextBox txtReleaseYear;
        private Label lblReleaseYear;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private Label lblDescription;
        private TextBox txtScore;
        private Label lblAudienceScore;
        private ComboBox cbRating;
        private GroupBox gbMovieAttributes;
        private TextBox txtDescription;
        private Button btnClearForm;
        private Button btnSubmit;
        private Label lblErrorName;
        private Label lblErrorRating;
        private Label lblErrorScore;
        private Label lblErrorReleaseYear;
        private Label lblErrorQuantity;
        private Label lblErrorRuntime;
        private Label lblErrorPrice;
    }
}