
namespace ContentCounter.GUI
{
    partial class TrackSelectionPrompt
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
            this.trackList = new System.Windows.Forms.CheckedListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trackList
            // 
            this.trackList.CheckOnClick = true;
            this.trackList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackList.FormattingEnabled = true;
            this.trackList.Location = new System.Drawing.Point(13, 13);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(459, 220);
            this.trackList.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(0, 243);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(484, 45);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // TrackSelectionPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(484, 288);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.trackList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TrackSelectionPrompt";
            this.Text = "TrackSelectionPrompt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox trackList;
        private System.Windows.Forms.Button submitButton;
    }
}