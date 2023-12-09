namespace Class_Project.PresentationLayer
{
    partial class FrmSearchResults
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            gvSearchResults = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // gvSearchResults
            // 
            gvSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            gvSearchResults.DefaultCellStyle = dataGridViewCellStyle1;
            gvSearchResults.Location = new Point(12, 56);
            gvSearchResults.Name = "gvSearchResults";
            gvSearchResults.ReadOnly = true;
            gvSearchResults.RowTemplate.Height = 25;
            gvSearchResults.ScrollBars = ScrollBars.Vertical;
            gvSearchResults.Size = new Size(661, 472);
            gvSearchResults.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(221, 18);
            label1.TabIndex = 1;
            label1.Text = "Here is What We Found...";
            // 
            // FrmSearchResults
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 540);
            Controls.Add(label1);
            Controls.Add(gvSearchResults);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmSearchResults";
            Text = "Search Results";
            Load += OnFormLoad_EventHandler;
            ((System.ComponentModel.ISupportInitialize)gvSearchResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvSearchResults;
        private Label label1;
    }
}