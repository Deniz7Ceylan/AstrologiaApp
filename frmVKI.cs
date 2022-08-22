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
    public partial class frmVKI : Form
    {
        public frmVKI()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //Vücut Kitle İndeksi
            double boy = Convert.ToDouble(txtBoy.Text);
            double kilo = Convert.ToDouble(txtKilo.Text);
            double vkiSonuc = kilo / (boy * boy);
            vkiSonuc = Math.Round(vkiSonuc, 2);

            //İdeal Kilo
            double erkekIdealKilo = 50 + 2.3 * (((boy*100)/2.54)-60);
            erkekIdealKilo = Math.Round(erkekIdealKilo, 2);
            double kadinIdealKilo = 45.5 + 2.3 * (((boy * 100)/2.54)-60);
            kadinIdealKilo = Math.Round(kadinIdealKilo, 2);

            string cinsiyet = Convert.ToString(cboxCinsiyet.SelectedItem);
            
            if (cinsiyet == "Erkek")
            {
                if (vkiSonuc < 18.5)
                {
                    MessageBox.Show($"Vücut Kitle İndeksin: {vkiSonuc}\nZayıfsın.\nİdeal Kilon: {erkekIdealKilo} kg.");
                }
                else if (vkiSonuc >= 18.5 && vkiSonuc < 25)
                {
                    MessageBox.Show($"Vücut Kitle İndeksin: {vkiSonuc}\nNormalsin.\nİdeal Kilon: {erkekIdealKilo} kg.");
                }
                else if (vkiSonuc >= 25 && vkiSonuc < 30)
                {
                    MessageBox.Show($"Vücut Kitle İndeksin: {vkiSonuc}\nKilolusun.\nİdeal Kilon: {erkekIdealKilo} kg.");
                }
                else if (vkiSonuc >= 30 && vkiSonuc < 35)
                {
                    MessageBox.Show($"Vücut Kitle İndeksin: {vkiSonuc}\nObezsin (1.Sınıf ).\nİdeal Kilon: {erkekIdealKilo} kg.");
                }
                else if (vkiSonuc >= 35 && vkiSonuc < 45)
                {
                    MessageBox.Show($"Vücut Kitle İndeksin: {vkiSonuc}\nObezsin (2.Sınıf ).\nİdeal Kilon: {erkekIdealKilo} kg.");
                }
                else
                {
                    MessageBox.Show($"Vücut Kitle İndeksin: {vkiSonuc}\nAşırı Obezsin (3.Sınıf).\nİdeal Kilon: {erkekIdealKilo} kg.");
                }
            }
            else if (cinsiyet == "Kadın")
            {
                if (vkiSonuc < 18.5)
                {
                    MessageBox.Show($"Vücut Kitle İndeksin: {vkiSonuc}\nZayıfsın.\nİdeal Kilon: {kadinIdealKilo} kg.");
                }
                else if (vkiSonuc >= 18.5 && vkiSonuc < 25)
                {
                    MessageBox.Show($"Vücut Kitle İndeksin: {vkiSonuc}\nNormalsin.\nİdeal Kilon: {kadinIdealKilo} kg.");
                }
                else if (vkiSonuc >= 25 && vkiSonuc < 30)
                {
                    MessageBox.Show($"Vücut Kitle İndeksin: {vkiSonuc}\nKilolusun.\nİdeal Kilon: {kadinIdealKilo} kg.");
                }
                else if (vkiSonuc >= 30 && vkiSonuc < 35)
                {
                    MessageBox.Show($"Vücut Kitle İndeksin: {vkiSonuc}\nObezsin (1.Sınıf ).\nİdeal Kilon: {kadinIdealKilo} kg.");
                }
                else if (vkiSonuc >= 35 && vkiSonuc < 45)
                {
                    MessageBox.Show($"Vücut Kitle İndeksin: {vkiSonuc}\nObezsin (2.Sınıf ).\nİdeal Kilon: {kadinIdealKilo} kg.");
                }
                else
                {
                    MessageBox.Show($"Vücut Kitle İndeksin: {vkiSonuc}\nAşırı Obezsin (3.Sınıf).\nİdeal Kilon: {kadinIdealKilo} kg.");
                }
            }


        }
    }
}
