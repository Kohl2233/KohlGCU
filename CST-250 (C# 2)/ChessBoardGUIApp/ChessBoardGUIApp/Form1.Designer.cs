namespace ChessBoardGUIApp
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
            lblInstructions = new Label();
            cbChessPiece = new ComboBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(12, 9);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(405, 15);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = "Select a chess piece from the dropdown and I will show you all legal moves.";
            // 
            // cbChessPiece
            // 
            cbChessPiece.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChessPiece.FormattingEnabled = true;
            cbChessPiece.Items.AddRange(new object[] { "Knight", "King", "Rook", "Bishop", "Queen" });
            cbChessPiece.Location = new Point(423, 6);
            cbChessPiece.Name = "cbChessPiece";
            cbChessPiece.Size = new Size(121, 23);
            cbChessPiece.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(34, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 500);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            Controls.Add(panel1);
            Controls.Add(cbChessPiece);
            Controls.Add(lblInstructions);
            Name = "Form1";
            Text = "Chess Board";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstructions;
        private ComboBox cbChessPiece;
        private Panel panel1;
    }
}