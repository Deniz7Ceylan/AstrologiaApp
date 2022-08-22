namespace Astrologia
{
    partial class frmAstrolojiNedir
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
            this.lblAstrolojiNedir = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAstrolojiNedir
            // 
            this.lblAstrolojiNedir.AutoSize = true;
            this.lblAstrolojiNedir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAstrolojiNedir.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAstrolojiNedir.Location = new System.Drawing.Point(17, 21);
            this.lblAstrolojiNedir.Margin = new System.Windows.Forms.Padding(17, 21, 17, 21);
            this.lblAstrolojiNedir.Name = "lblAstrolojiNedir";
            this.lblAstrolojiNedir.Size = new System.Drawing.Size(2, 18);
            this.lblAstrolojiNedir.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblAstrolojiNedir);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1184, 936);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // frmAstrolojiNedir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 936);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAstrolojiNedir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AstrologiApp | Astroloji Nedir?";
            this.Load += new System.EventHandler(this.frmAstrolojiNedir_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblAstrolojiNedir;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}