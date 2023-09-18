
namespace ContentCounter.GUI
{
    partial class TrackStatsPrompt
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
            this.statsTable = new System.Windows.Forms.TableLayoutPanel();
            this.trackLabel = new System.Windows.Forms.Label();
            this.totalLengthLabel = new System.Windows.Forms.Label();
            this.cursorLengthLabel = new System.Windows.Forms.Label();
            this.selectionLengthLabel = new System.Windows.Forms.Label();
            this.statsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // statsTable
            // 
            this.statsTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.statsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.statsTable.ColumnCount = 4;
            this.statsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.statsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.statsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.statsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.statsTable.Controls.Add(this.totalLengthLabel, 1, 0);
            this.statsTable.Controls.Add(this.trackLabel, 0, 0);
            this.statsTable.Controls.Add(this.cursorLengthLabel, 2, 0);
            this.statsTable.Controls.Add(this.selectionLengthLabel, 3, 0);
            this.statsTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statsTable.Location = new System.Drawing.Point(13, 13);
            this.statsTable.Name = "statsTable";
            this.statsTable.RowCount = 1;
            this.statsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.statsTable.Size = new System.Drawing.Size(775, 70);
            this.statsTable.TabIndex = 0;
            // 
            // trackLabel
            // 
            this.trackLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackLabel.AutoSize = true;
            this.trackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.trackLabel.Location = new System.Drawing.Point(65, 24);
            this.trackLabel.Name = "trackLabel";
            this.trackLabel.Size = new System.Drawing.Size(65, 26);
            this.trackLabel.TabIndex = 0;
            this.trackLabel.Text = "Track";
            this.trackLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalLengthLabel
            // 
            this.totalLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLengthLabel.AutoSize = true;
            this.totalLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.totalLengthLabel.Location = new System.Drawing.Point(227, 24);
            this.totalLengthLabel.Name = "totalLengthLabel";
            this.totalLengthLabel.Size = new System.Drawing.Size(131, 26);
            this.totalLengthLabel.TabIndex = 1;
            this.totalLengthLabel.Text = "Total Length";
            this.totalLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cursorLengthLabel
            // 
            this.cursorLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cursorLengthLabel.AutoSize = true;
            this.cursorLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cursorLengthLabel.Location = new System.Drawing.Point(401, 24);
            this.cursorLengthLabel.Name = "cursorLengthLabel";
            this.cursorLengthLabel.Size = new System.Drawing.Size(173, 26);
            this.cursorLengthLabel.TabIndex = 2;
            this.cursorLengthLabel.Text = "Length to Cursor";
            this.cursorLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectionLengthLabel
            // 
            this.selectionLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectionLengthLabel.AutoSize = true;
            this.selectionLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.selectionLengthLabel.Location = new System.Drawing.Point(622, 11);
            this.selectionLengthLabel.Name = "selectionLengthLabel";
            this.selectionLengthLabel.Size = new System.Drawing.Size(142, 52);
            this.selectionLengthLabel.TabIndex = 3;
            this.selectionLengthLabel.Text = "Length Inside Selection";
            this.selectionLengthLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TrackStatsPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 211);
            this.Controls.Add(this.statsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(816, 800);
            this.Name = "TrackStatsPrompt";
            this.Text = "TrackStatsPrompt";
            this.statsTable.ResumeLayout(false);
            this.statsTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel statsTable;
        private System.Windows.Forms.Label selectionLengthLabel;
        private System.Windows.Forms.Label cursorLengthLabel;
        private System.Windows.Forms.Label totalLengthLabel;
        private System.Windows.Forms.Label trackLabel;
    }
}