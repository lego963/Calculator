namespace CalculatorWFA
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.HistoryLbl = new System.Windows.Forms.Label();
            this.CloseForm = new System.Windows.Forms.Button();
            this.HistoryPnl = new System.Windows.Forms.Panel();
            this.HistoryPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryLbl
            // 
            this.HistoryLbl.AutoSize = true;
            this.HistoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryLbl.Location = new System.Drawing.Point(12, 9);
            this.HistoryLbl.Name = "HistoryLbl";
            this.HistoryLbl.Size = new System.Drawing.Size(0, 24);
            this.HistoryLbl.TabIndex = 0;
            // 
            // CloseForm
            // 
            this.CloseForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseForm.Location = new System.Drawing.Point(165, 280);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(82, 23);
            this.CloseForm.TabIndex = 1;
            this.CloseForm.Text = "Close";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // HistoryPnl
            // 
            this.HistoryPnl.AutoScroll = true;
            this.HistoryPnl.Controls.Add(this.HistoryLbl);
            this.HistoryPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistoryPnl.Location = new System.Drawing.Point(0, 0);
            this.HistoryPnl.Name = "HistoryPnl";
            this.HistoryPnl.Size = new System.Drawing.Size(419, 274);
            this.HistoryPnl.TabIndex = 2;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 310);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.HistoryPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.HistoryPnl.ResumeLayout(false);
            this.HistoryPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HistoryLbl;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Panel HistoryPnl;
    }
}