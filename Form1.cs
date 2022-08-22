namespace Astrologia
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnAstrolojiNedir_Click(object sender, EventArgs e)
        {
            frmAstrolojiNedir frmAstrolojiNedir = new frmAstrolojiNedir();
            frmAstrolojiNedir.ShowDialog();
        }

        private void btnHangiBurcOzl_Click(object sender, EventArgs e)
        {
            frmHangiBurc frmHangiBurc = new frmHangiBurc();
            frmHangiBurc.ShowDialog();
        }

        private void btnCinBurcu_Click(object sender, EventArgs e)
        {
            frmCinBurcu frmCinBurcu = new frmCinBurcu();
            frmCinBurcu.ShowDialog();
        }

        private void btnVKI_Click(object sender, EventArgs e)
        {
            frmVKI frmVKI = new frmVKI();
            frmVKI.ShowDialog();
        }

        private void btnNextUpdates_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ay Burcu, Burçlarýn Uyumu, Tarot (Tam Detaylý) olarak güncelleme ile eklenecek.");
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            frmHakkinda frmHakkinda = new frmHakkinda();
            frmHakkinda.ShowDialog();
        }

        private void btnCinCinsiyet_Click(object sender, EventArgs e)
        {
            frmCinsiyet frmCinsiyet = new frmCinsiyet();
            frmCinsiyet.ShowDialog();
        }
    }
}