namespace TicTacToe
{
    partial class FrmMain
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
            lblTopLeft = new Label();
            lblTopCenter = new Label();
            lblTopRight = new Label();
            lblMiddleRight = new Label();
            lblMiddleCenter = new Label();
            lblMiddleLeft = new Label();
            lblBottomRight = new Label();
            lblBottomCenter = new Label();
            lblBottomLeft = new Label();
            lblResults = new Label();
            btnNewGame = new Button();
            SuspendLayout();
            // 
            // lblTopLeft
            // 
            lblTopLeft.BorderStyle = BorderStyle.FixedSingle;
            lblTopLeft.Font = new Font("Stencil", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopLeft.Location = new Point(12, 9);
            lblTopLeft.Name = "lblTopLeft";
            lblTopLeft.Size = new Size(100, 100);
            lblTopLeft.TabIndex = 0;
            lblTopLeft.Text = "X";
            lblTopLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTopCenter
            // 
            lblTopCenter.BorderStyle = BorderStyle.FixedSingle;
            lblTopCenter.Font = new Font("Stencil", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopCenter.Location = new Point(118, 9);
            lblTopCenter.Name = "lblTopCenter";
            lblTopCenter.Size = new Size(100, 100);
            lblTopCenter.TabIndex = 1;
            lblTopCenter.Text = "X";
            lblTopCenter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTopRight
            // 
            lblTopRight.BorderStyle = BorderStyle.FixedSingle;
            lblTopRight.Font = new Font("Stencil", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblTopRight.Location = new Point(224, 9);
            lblTopRight.Name = "lblTopRight";
            lblTopRight.Size = new Size(100, 100);
            lblTopRight.TabIndex = 2;
            lblTopRight.Text = "X";
            lblTopRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMiddleRight
            // 
            lblMiddleRight.BorderStyle = BorderStyle.FixedSingle;
            lblMiddleRight.Font = new Font("Stencil", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleRight.Location = new Point(224, 118);
            lblMiddleRight.Name = "lblMiddleRight";
            lblMiddleRight.Size = new Size(100, 100);
            lblMiddleRight.TabIndex = 5;
            lblMiddleRight.Text = "X";
            lblMiddleRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMiddleCenter
            // 
            lblMiddleCenter.BorderStyle = BorderStyle.FixedSingle;
            lblMiddleCenter.Font = new Font("Stencil", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleCenter.Location = new Point(118, 118);
            lblMiddleCenter.Name = "lblMiddleCenter";
            lblMiddleCenter.Size = new Size(100, 100);
            lblMiddleCenter.TabIndex = 4;
            lblMiddleCenter.Text = "X";
            lblMiddleCenter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMiddleLeft
            // 
            lblMiddleLeft.BorderStyle = BorderStyle.FixedSingle;
            lblMiddleLeft.Font = new Font("Stencil", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleLeft.Location = new Point(12, 118);
            lblMiddleLeft.Name = "lblMiddleLeft";
            lblMiddleLeft.Size = new Size(100, 100);
            lblMiddleLeft.TabIndex = 3;
            lblMiddleLeft.Text = "X";
            lblMiddleLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBottomRight
            // 
            lblBottomRight.BorderStyle = BorderStyle.FixedSingle;
            lblBottomRight.Font = new Font("Stencil", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblBottomRight.Location = new Point(224, 228);
            lblBottomRight.Name = "lblBottomRight";
            lblBottomRight.Size = new Size(100, 100);
            lblBottomRight.TabIndex = 8;
            lblBottomRight.Text = "X";
            lblBottomRight.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBottomCenter
            // 
            lblBottomCenter.BorderStyle = BorderStyle.FixedSingle;
            lblBottomCenter.Font = new Font("Stencil", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblBottomCenter.Location = new Point(118, 228);
            lblBottomCenter.Name = "lblBottomCenter";
            lblBottomCenter.Size = new Size(100, 100);
            lblBottomCenter.TabIndex = 7;
            lblBottomCenter.Text = "X";
            lblBottomCenter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBottomLeft
            // 
            lblBottomLeft.BorderStyle = BorderStyle.FixedSingle;
            lblBottomLeft.Font = new Font("Stencil", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblBottomLeft.Location = new Point(12, 228);
            lblBottomLeft.Name = "lblBottomLeft";
            lblBottomLeft.Size = new Size(100, 100);
            lblBottomLeft.TabIndex = 6;
            lblBottomLeft.Text = "X";
            lblBottomLeft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            lblResults.BackColor = SystemColors.ControlLight;
            lblResults.Location = new Point(12, 339);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(312, 23);
            lblResults.TabIndex = 9;
            lblResults.Text = "Results";
            lblResults.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            btnNewGame.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewGame.Location = new Point(64, 377);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(207, 40);
            btnNewGame.TabIndex = 10;
            btnNewGame.Text = "New Game!";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += BtnNewGame_ClickEventHandler;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 465);
            Controls.Add(btnNewGame);
            Controls.Add(lblResults);
            Controls.Add(lblBottomRight);
            Controls.Add(lblBottomCenter);
            Controls.Add(lblBottomLeft);
            Controls.Add(lblMiddleRight);
            Controls.Add(lblMiddleCenter);
            Controls.Add(lblMiddleLeft);
            Controls.Add(lblTopRight);
            Controls.Add(lblTopCenter);
            Controls.Add(lblTopLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMain";
            Text = "Tic Tac Toe Game";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTopLeft;
        private Label lblTopCenter;
        private Label lblTopRight;
        private Label lblMiddleRight;
        private Label lblMiddleCenter;
        private Label lblMiddleLeft;
        private Label lblBottomRight;
        private Label lblBottomCenter;
        private Label lblBottomLeft;
        private Label lblResults;
        private Button btnNewGame;
    }
}