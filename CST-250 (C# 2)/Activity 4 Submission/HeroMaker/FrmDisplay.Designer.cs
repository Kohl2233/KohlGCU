namespace HeroMaker
{
    partial class FrmDisplay
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
            lblTroops = new Label();
            listBoxTroops = new ListBox();
            txtSummary = new TextBox();
            lblSummary = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTroops
            // 
            lblTroops.AutoSize = true;
            lblTroops.Location = new Point(14, 8);
            lblTroops.Name = "lblTroops";
            lblTroops.Size = new Size(49, 14);
            lblTroops.TabIndex = 0;
            lblTroops.Text = "Troops";
            // 
            // listBoxTroops
            // 
            listBoxTroops.FormattingEnabled = true;
            listBoxTroops.ItemHeight = 14;
            listBoxTroops.Location = new Point(12, 25);
            listBoxTroops.Name = "listBoxTroops";
            listBoxTroops.Size = new Size(166, 382);
            listBoxTroops.TabIndex = 1;
            listBoxTroops.Click += ListBoxTroops_ClickEventHandler;
            // 
            // txtSummary
            // 
            txtSummary.Location = new Point(184, 25);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.Size = new Size(357, 342);
            txtSummary.TabIndex = 2;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(184, 8);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(117, 14);
            lblSummary.TabIndex = 3;
            lblSummary.Text = "Trooper Summary";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(457, 373);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 34);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // FrmDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 420);
            Controls.Add(btnExit);
            Controls.Add(lblSummary);
            Controls.Add(txtSummary);
            Controls.Add(listBoxTroops);
            Controls.Add(lblTroops);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FrmDisplay";
            Text = "Troops";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTroops;
        private ListBox listBoxTroops;
        private TextBox txtSummary;
        private Label lblSummary;
        private Button btnExit;
    }
}