namespace Astrologia
{
    partial class frmHangiBurc
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
            this.lblAy = new System.Windows.Forms.Label();
            this.lblGun = new System.Windows.Forms.Label();
            this.cmboxAy = new System.Windows.Forms.ComboBox();
            this.cmboxGun = new System.Windows.Forms.ComboBox();
            this.btnBurcOgren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAy
            // 
            this.lblAy.AutoSize = true;
            this.lblAy.Location = new System.Drawing.Point(14, 14);
            this.lblAy.Margin = new System.Windows.Forms.Padding(5);
            this.lblAy.Name = "lblAy";
            this.lblAy.Size = new System.Drawing.Size(162, 16);
            this.lblAy.TabIndex = 0;
            this.lblAy.Text = "Lütfen doğduğunuz ayı seçiniz:";
            // 
            // lblGun
            // 
            this.lblGun.AutoSize = true;
            this.lblGun.Location = new System.Drawing.Point(14, 55);
            this.lblGun.Margin = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.lblGun.Name = "lblGun";
            this.lblGun.Size = new System.Drawing.Size(171, 16);
            this.lblGun.TabIndex = 1;
            this.lblGun.Text = "Lütfen doğduğunuz günü seçiniz:";
            // 
            // cmboxAy
            // 
            this.cmboxAy.FormattingEnabled = true;
            this.cmboxAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmboxAy.Location = new System.Drawing.Point(195, 11);
            this.cmboxAy.Name = "cmboxAy";
            this.cmboxAy.Size = new System.Drawing.Size(106, 24);
            this.cmboxAy.TabIndex = 2;
            // 
            // cmboxGun
            // 
            this.cmboxGun.FormattingEnabled = true;
            this.cmboxGun.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmboxGun.Location = new System.Drawing.Point(195, 52);
            this.cmboxGun.Name = "cmboxGun";
            this.cmboxGun.Size = new System.Drawing.Size(106, 24);
            this.cmboxGun.TabIndex = 3;
            // 
            // btnBurcOgren
            // 
            this.btnBurcOgren.Location = new System.Drawing.Point(226, 99);
            this.btnBurcOgren.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.btnBurcOgren.Name = "btnBurcOgren";
            this.btnBurcOgren.Size = new System.Drawing.Size(75, 23);
            this.btnBurcOgren.TabIndex = 4;
            this.btnBurcOgren.Text = "Hesapla";
            this.btnBurcOgren.UseVisualStyleBackColor = true;
            this.btnBurcOgren.Click += new System.EventHandler(this.btnBurcOgren_Click);
            // 
            // frmHangiBurc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 145);
            this.Controls.Add(this.btnBurcOgren);
            this.Controls.Add(this.cmboxGun);
            this.Controls.Add(this.cmboxAy);
            this.Controls.Add(this.lblGun);
            this.Controls.Add(this.lblAy);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHangiBurc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AstrologiApp | Hangi Burçsun? ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAy;
        private Label lblGun;
        private ComboBox cmboxAy;
        private ComboBox cmboxGun;
        private Button btnBurcOgren;
    }
}