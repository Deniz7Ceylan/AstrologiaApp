using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astrologia
{
    public partial class frmCinsiyet : Form
    {
        public frmCinsiyet()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string anne = Convert.ToString(cboxAnneYas.SelectedItem);
            string ay = Convert.ToString(cboxHKAy.SelectedItem);

            if (anne == "18")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "19")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "20")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "21")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "22")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "23")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "24")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "25")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "26")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "27")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "28")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "29")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "30")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "31")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "32")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "33")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "34")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "35")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "36")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "37")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "38")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "39")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "40")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "41")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "42")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "43")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "44")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }
            if (anne == "45")
            {
                if (ay == "Ocak")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Şubat")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mart")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Nisan")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Mayıs")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Haziran")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Temmuz")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ağustos")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Eylül")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Ekim")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Kasım")
                {
                    MessageBox.Show("Erkek çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
                else if (ay == "Aralık")
                {
                    MessageBox.Show("Kız çocuğunuz olacak.\nSağlıklı bir ömür dileriz, tebrikler.");
                }
            }

        }    
    }
}
