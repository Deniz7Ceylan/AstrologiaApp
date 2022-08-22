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
    public partial class frmCinBurcu : Form
    {
        public frmCinBurcu()
        {
            InitializeComponent();
        }


        private void txtCinBurc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string kullaniciYili = txtCinBurc.Text;

                #region kaplan06
                string[] kaplan = new string[171];
                string kaplanDeger = "6";
                int kaplanDeger1 = 0;



                for (int i = 0; i < 171; i++)
                {
                    kaplan[i] = kaplanDeger;
                    kaplanDeger1 = Convert.ToInt32(kaplanDeger);
                    kaplanDeger1 = kaplanDeger1 + 12;
                    kaplanDeger = Convert.ToString(kaplanDeger1);
                }
                for (int i = 0; i < kaplan.Length; i++)
                {
                    if (kaplan[i] == kullaniciYili)
                    {
                        MessageBox.Show("KAPLAN BURCU\n\nLider olarak doğarlar, hastalanıncaya kadar çalışmaya devam ederler. En sevdikleri şey çalışmaktır. Başkalarından esinlenmek onlara güven verir, böylece güven ve güç elde ederler. Sessiz ama çok dayanıklıdırlar. Olaylar karşısında kolay kolay sarsılmazlar. Sabit fikirlidirler ve kararlarından geri adım atmaktan hoşlanmazlar.");
                    }
                }
                #endregion
                #region tavsan07
                string[] tavsan = new string[171];
                string tavsanDeger = "7";
                int tavsanDeger1 = 0;

                for (int i = 0; i < 171; i++)
                {
                    tavsan[i] = tavsanDeger;
                    tavsanDeger1 = Convert.ToInt32(tavsanDeger);
                    tavsanDeger1 = tavsanDeger1 + 12;
                    tavsanDeger = Convert.ToString(tavsanDeger1);
                }
                for (int i = 0; i < tavsan.Length; i++)
                {
                    if (tavsan[i] == kullaniciYili)
                    {
                        MessageBox.Show("TAVŞAN BURCU\n\nTavşanların sosyal bir yapısı vardır. Daima affedici, hoş ve zariftirler. Buna karşın, sır saklama konusunda tutarsızlıklar gösterebilirler. Ağızları biraz gevşektir. Normalde aşırı duyarlı olan Tavşanlar, zaman zaman bu konuda daha yüzeysel davranabilirler. Tutucu bir yapıları vardır. Tutucu doğaları nedeniyle, kuşkuculukları ve tedbirli olma tutkuları özellikle iş yaşamında bir avantaj olarak ortaya çıkar.");
                    }
                }
                #endregion
                #region ejderha08
                string[] ejderha = new string[171];
                string ejderhaDeger = "8";
                int ejderhaDeger1 = 0;

                for (int i = 0; i < 171; i++)
                {
                    ejderha[i] = ejderhaDeger;
                    ejderhaDeger1 = Convert.ToInt32(ejderhaDeger);
                    ejderhaDeger1 = ejderhaDeger1 + 12;
                    ejderhaDeger = Convert.ToString(ejderhaDeger1);
                }
                for (int i = 0; i < ejderha.Length; i++)
                {
                    if (ejderha[i] == kullaniciYili)
                    {
                        MessageBox.Show("EJDERHA BURCU\n\nEjderhalar yaşam ve coşku dolu insanlardır. Toplum içinde çabuk sevilirler ve hemen fark edilirler. Bir konuda konuşmadan önce mutlaka ne söyleyeceklerini düşünürler ve başkalarını yargılamayı severler. İşlerinde genellikle çok başarılı olurlar. Bu durum onların iç güdülerinden gelir. Allah vergisi bir zekaları vardır. Oldukça cömert insanlardır.");
                    }
                }
                #endregion
                #region yilan09
                string[] yilan = new string[171];
                string yilanDeger = "09";
                int yilanDeger1 = 0;
                for (int i = 0; i < 171; i++)
                {
                    yilan[i] = yilanDeger;
                    yilanDeger1 = Convert.ToInt32(yilanDeger);
                    yilanDeger1 = yilanDeger1 + 12;
                    yilanDeger = Convert.ToString(yilanDeger1);
                }
                for (int i = 0; i < yilan.Length; i++)
                {
                    if (yilan[i] == kullaniciYili)
                    {
                        MessageBox.Show("YILAN BURCU\n\nYılanlar genellikle cazibeli ve şık kişilerdir. Karar veremediklerinde içgüdüleriyle yön bulurlar, çok derin düşünürler. Filozofik yapıları nedeniyle yıllar geçtikçe daha olgun ve bilge bir yapıya kavuşurlar. Bulundukları ortamda ya da çalıştıkları konuda her şeye hakim olmak isterler. Yapılan iyilik ya da kötülüğü unutmamaları, kindar olmaları onları intikam almaya yönlendirir.");
                    }
                }
                #endregion
                #region at10
                string[] at = new string[171];
                string atDeger = "10";
                int atDeger1 = 0;
                for (int i = 0; i < 171; i++)
                {
                    at[i] = atDeger;
                    atDeger1 = Convert.ToInt32(atDeger);
                    atDeger1 = atDeger1 + 12;
                    atDeger = Convert.ToString(atDeger1);
                }
                for (int i = 0; i < at.Length; i++)
                {
                    if (at[i] == kullaniciYili)
                    {
                        MessageBox.Show("AT BURCU\n\nAt burcu olanlar, özgür ve ruhsal yönden doğal olarak bağımsızdırlar. Sosyal konularda oldukça başarılı olurlar. Çevreleri tarafından da bu yönleri oldukça takdir edilir. Ancak aynı zamanda özgür ve bağımsız tarafları onları biraz egoist ve isyankar da yapabilir. Özellikle beklentileri istedikleri gibi sonuçlanmazsa saldırgan bir tutum içine de girebilirler. Maceraperest bir tarafları da vardır. Bu yüzden yaşamı tüm yönleri ile yaşamak isterler.");
                    }
                }
                #endregion
                #region keci11
                string[] keci = new string[171];
                string keciDeger = "11";
                int keciDeger1 = 0;
                for (int i = 0; i < 171; i++)
                {
                    keci[i] = keciDeger;
                    keciDeger1 = Convert.ToInt32(keciDeger);
                    keciDeger1 = keciDeger1 + 12;
                    keciDeger = Convert.ToString(keciDeger1);
                }
                for (int i = 0; i < keci.Length; i++)
                {
                    if (keci[i] == kullaniciYili)
                    {
                        MessageBox.Show("KEÇİ BURCU\n\nKeçiler hem zarafet simgesi hem de yaratıcı kişilerdir. Keçi insanları oldukça terbiyeli ve dikkat çekicidir. Ancak çok fazla pozitif oldukları söylenemez. Olaylara kötümser yaklaşırlar. Bu durum da onların mutlu olmaları gerektiği zamanlarda bile bir taraflarının huzursuz olmalarına yol açar. Genellikle tatminsiz olurlar. Sezgisel zamanlamaları mükemmeldir. Sevecen ve dengeli insanlardır. Çevresi ile iletişiminde bu durum onlara oldukça kolaylık sağlar.");
                    }
                }
                #endregion//0'a denk //0'a denk
                #region maymun12
                string[] maymun = new string[171];
                string maymunDeger = "12";
                int maymunDeger1 = 0;
                for (int i = 0; i < 171; i++)
                {
                    maymun[i] = maymunDeger;
                    maymunDeger1 = Convert.ToInt32(maymunDeger);
                    maymunDeger1 = maymunDeger1 + 12;
                    maymunDeger = Convert.ToString(maymunDeger1);
                }
                for (int i = 0; i < maymun.Length; i++)
                {
                    if (maymun[i] == kullaniciYili)
                    {
                        MessageBox.Show("MAYMUN BURCU\n\nMaymunlar zeki ve gözlemcidirler. Hep genç kalırlar, kişilikleri ise hipnotize edebilecek kadar etkilidir. Daima herkes tarafından sevilirler. Ancak fazla kuşkucu olmaları onların bazı konularda gereğinden fazla titiz olmalarına ve yorulmalarına neden olabilir. Zaman zaman kararsızlıkları yüzünden seçenekler arasında kaldıklarında zorlanabilirler. Amaçlarından uzaklaştıklarında çocukça tepkiler verebilirler. Bir şeyi kafaya koymuşlarsa onu elde etmek için her yolu denerler. İlişkilerinde pek sadık olamayabilirler.");
                    }
                }
                #endregion
                #region horoz01
                string[] horoz = new string[171];
                string horozDeger = "1";
                int horozDeger1 = 0;
                for (int i = 0; i < 171; i++)
                {
                    horoz[i] = horozDeger;
                    horozDeger1 = Convert.ToInt32(horozDeger);
                    horozDeger1 = horozDeger1 + 12;
                    horozDeger = Convert.ToString(horozDeger1);
                }
                for (int i = 0; i < horoz.Length; i++)
                {
                    if (horoz[i] == kullaniciYili)
                    {
                        MessageBox.Show("HOROZ BURCU\n\nHorozlar çalışkan, kurnaz ve beceriklidir. Bir konuda karar verirken her şeyi öğrenmek isterler. Konuşken tiplerdir, düşüncelerini anlatmayı severler. Kendilerini beğendiklerini söylemek yanlış olmaz. Kendilerini övmeyi ve ön plana çıkartmayı severler. Para konusunda çok tutumlu değillerdir. Özellikle moda konusunda harcama yapmaktan kaçınmazlar. Doğalarında fedakarlık ve çevresi için bir şeyler yapmak olduğundan, herkes tarafından çok sevilirler.");
                    }
                }
                #endregion
                #region kopek02
                string[] kopek = new string[171];
                string kopekDeger = "2";
                int kopekDeger1 = 0;
                for (int i = 0; i < 171; i++)
                {
                    kopek[i] = kopekDeger;
                    kopekDeger1 = Convert.ToInt32(kopekDeger);
                    kopekDeger1 = kopekDeger1 + 12;
                    kopekDeger = Convert.ToString(kopekDeger1);
                }
                for (int i = 0; i < kopek.Length; i++)
                {
                    if (kopek[i] == kullaniciYili)
                    {
                        MessageBox.Show("KÖPEK BURCU\n\nİnatçıdırlar, eğer bir konuya yoğunlaştılarsa ya da bir şeye sahip çıktılarsa kendilerini adarlar ve amaçlarından asla vazgeçmezler. Dürüstlük ve güvenilirlik onlar için çok önemlidir. Kendileri de hem partnerlerine hem de çevre ile ilişkilerinde dürüst ve güvenilir olurlar. Bazen aşırı meraklı olmaları çevrelerini rahatsız edebilir. İnsanların hatalarını bulup düzeltmekten hoşlanırlar. Bu yüzden iş hayatlarında baskın bir karakter olarak çevresinin çekindiği bir kişi haline gelirler.");
                    }
                }
                #endregion
                #region domuz03
                string[] domuz = new string[171];
                string domuzDeger = "3";
                int domuzDeger1 = 0;
                for (int i = 0; i < 171; i++)
                {
                    domuz[i] = domuzDeger;
                    domuzDeger1 = Convert.ToInt32(domuzDeger);
                    domuzDeger1 = domuzDeger1 + 12;
                    domuzDeger = Convert.ToString(domuzDeger1);
                }
                for (int i = 0; i < domuz.Length; i++)
                {
                    if (domuz[i] == kullaniciYili)
                    {
                        MessageBox.Show("DOMUZ BURCU\n\nDomuzlar mükemmel arkadaş ve harika bir iş ortağı olurlar. Güçlü zekaları vardır ve kolay işler ya da hedeflerden hoşlanmazlar. Güçlerini sergilemekten de kaçınmazlar. Çevrelerine karşı oldukça hoşgörülüdürler. İçten ve dürüst insanlardır. Ancak çok duygusal olmaları ve zaman zaman duyguları ile karar vermeleri onları oldukça zorlar. Sizi hiçbir zaman yalnız bırakmayacak ve size doğru yolu gösterecek, sizi anlayışla karşılayacak mükemmel dost ve eşler bu burçtan çıkar.");
                    }
                }
                #endregion
                #region fare04
                string[] fare = new string[171];
                string fareDeger = "4";
                int fareDeger1 = 0;
                for (int i = 0; i < 171; i++)
                {
                    fare[i] = fareDeger;
                    fareDeger1 = Convert.ToInt32(fareDeger);
                    fareDeger1 = fareDeger1 + 12;
                    fareDeger = Convert.ToString(fareDeger1);
                }
                for (int i = 0; i < fare.Length; i++)
                {
                    if (fare[i] == kullaniciYili)
                    {
                        MessageBox.Show("FARE BURCU\n\nZeki, büyüleyici ve içtendir, sevdiğine cömerttir. Sosyal uyum yeteneği yüksektir ve toplumun her düzeyine uyum sağlar. Fareler başarılı iş insanlarıdırlar ama bazen çok hırslı olurlar ve tüm gücü ellerinde bulundurmak isterler. Zaman zaman fırsatçı davrandıkları da söylenebilir.");
                    }
                }
                #endregion
                #region okuz05
                string[] okuz = new string[171];
                string okuzDeger = "5";
                int okuzDeger1 = 0;
                for (int i = 0; i < 171; i++)
                {
                    okuz[i] = okuzDeger;
                    okuzDeger1 = Convert.ToInt32(okuzDeger);
                    okuzDeger1 = okuzDeger1 + 12;
                    okuzDeger = Convert.ToString(okuzDeger1);
                }
                for (int i = 0; i < okuz.Length; i++)
                {
                    if (okuz[i] == kullaniciYili)
                    {
                        MessageBox.Show("ÖKÜZ BURCU\n\nLider olarak doğarlar, hastalanıncaya kadar çalışmaya devam ederler. En sevdikleri şey çalışmaktır. Başkalarından esinlenmek onlara güven verir, böylece güven ve güç elde ederler. Sessiz ama çok dayanıklıdırlar. Olaylar karşısında kolay kolay sarsılmazlar. Sabit fikirlidirler ve kararlarından geri adım atmaktan hoşlanmazlar.");
                    }
                }
                #endregion
            }
        }

        private void txtCinBurc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
