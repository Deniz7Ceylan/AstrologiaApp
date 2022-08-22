namespace Astrologia
{
    partial class frmHakkinda
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
            this.label1 = new System.Windows.Forms.Label();
            this.linklnlLinkedIn = new System.Windows.Forms.LinkLabel();
            this.linkLlblGitHub = new System.Windows.Forms.LinkLabel();
            this.linkLblTwitter = new System.Windows.Forms.LinkLabel();
            this.linklblInstagram = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "İstek ve Önerileriniz için; Sosyal Medya Hesaplarım ↓";
            // 
            // linklnlLinkedIn
            // 
            this.linklnlLinkedIn.AutoSize = true;
            this.linklnlLinkedIn.LinkVisited = true;
            this.linklnlLinkedIn.Location = new System.Drawing.Point(63, 71);
            this.linklnlLinkedIn.Name = "linklnlLinkedIn";
            this.linklnlLinkedIn.Size = new System.Drawing.Size(49, 16);
            this.linklnlLinkedIn.TabIndex = 7;
            this.linklnlLinkedIn.TabStop = true;
            this.linklnlLinkedIn.Text = "LinkedIn";
            this.linklnlLinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklnlLinkedIn_LinkClicked);
            // 
            // linkLlblGitHub
            // 
            this.linkLlblGitHub.AutoSize = true;
            this.linkLlblGitHub.Location = new System.Drawing.Point(180, 71);
            this.linkLlblGitHub.Name = "linkLlblGitHub";
            this.linkLlblGitHub.Size = new System.Drawing.Size(40, 16);
            this.linkLlblGitHub.TabIndex = 8;
            this.linkLlblGitHub.TabStop = true;
            this.linkLlblGitHub.Text = "GitHub";
            this.linkLlblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLlblGitHub_LinkClicked);
            // 
            // linkLblTwitter
            // 
            this.linkLblTwitter.AutoSize = true;
            this.linkLblTwitter.Location = new System.Drawing.Point(63, 104);
            this.linkLblTwitter.Name = "linkLblTwitter";
            this.linkLblTwitter.Size = new System.Drawing.Size(43, 16);
            this.linkLblTwitter.TabIndex = 9;
            this.linkLblTwitter.TabStop = true;
            this.linkLblTwitter.Text = "Twitter";
            this.linkLblTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblTwitter_LinkClicked);
            // 
            // linklblInstagram
            // 
            this.linklblInstagram.AutoSize = true;
            this.linklblInstagram.Location = new System.Drawing.Point(161, 104);
            this.linklblInstagram.Name = "linklblInstagram";
            this.linklblInstagram.Size = new System.Drawing.Size(59, 16);
            this.linklblInstagram.TabIndex = 10;
            this.linklblInstagram.TabStop = true;
            this.linklblInstagram.Text = "Instagram";
            this.linklblInstagram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblInstagram_LinkClicked);
            // 
            // frmHakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 146);
            this.Controls.Add(this.linklblInstagram);
            this.Controls.Add(this.linkLblTwitter);
            this.Controls.Add(this.linkLlblGitHub);
            this.Controls.Add(this.linklnlLinkedIn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHakkinda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AstrologiApp | Hakkında";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private LinkLabel linklnlLinkedIn;
        private LinkLabel linkLlblGitHub;
        private LinkLabel linkLblTwitter;
        private LinkLabel linklblInstagram;
    }
}