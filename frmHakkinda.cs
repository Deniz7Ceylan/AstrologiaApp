using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Astrologia
{
    public partial class frmHakkinda : Form
    {
        public frmHakkinda()
        {
            InitializeComponent();
        }

        private void linklnlLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.linkedin.com/in/deniz7ceylan/");
            Process.Start(info);
        }

        private void linkLlblGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://github.com/Deniz7Ceylan");
            Process.Start(info);
        }

        private void linkLblTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://twitter.com/deniz7ceylan");
            Process.Start(info);
        }

        private void linklblInstagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://instagram.com/deniz7ceylan");
            Process.Start(info);
        }
    }
}
