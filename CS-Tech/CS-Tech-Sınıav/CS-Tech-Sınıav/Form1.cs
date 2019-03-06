using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS_Tech_Sınıav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //değişkenler
        private int bilSayi, bilSonTahmin;
        private int[,] bilTahminX = new int[4, 3];// *,0 son 
        private int[,] bilTahminDeger=new int[2,2]; // 0 - arti || 1 - eksi
        private bool ilkTahmin = false;
        private bool siraKimde = true; //false - Kullanıcı //true - bilgisayar

        //Değerlendirme Buton Kontrol
        private void siraKontrol( int i)
        {
            if (i==0)
            {
                bilTahimB.Enabled = false;
                tahminB.Enabled = true;
            }
            else if(i==1)
            {
                bilTahimB.Enabled = true;
                tahminB.Enabled = false;
            }
            else if (i == 2)
            {

                bilTahimB.Enabled = false;
                tahminB.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //4 basamaklı rastgele sayı
            Random r = new Random();
            bilSayi = r.Next(1000, 10000);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    bilTahminX[i, j] = -1;
                }
            }

            this.siraKontrol(0);
        }

        //rakam bazında karşılaştırma için sayının rakamlarını diziye aktarıyor
        private int[] rakamla(int sayi)
        {
            int[] rakam = new int[4];
            string s = sayi.ToString();
            for (int i = 0; i < 4; i++)
            {
                rakam[i] = int.Parse(s[i].ToString());
            }
            return rakam;
        }

        //int dizisini sayıya dönüştür
        private int sayila(int[] rakam)
        {
            string t = "";
            foreach (int i in rakam)
            {
                t += i.ToString();
            }
            return int.Parse(t);
        }

        //kullanıcı tahmin kontrol
        private void tahmin(int sayi)
        {
            int[] s1 = rakamla(bilSayi),s2 = rakamla(sayi);
            int arti = 0, eksi = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (s1[i] == s2[j])
                    {
                        if (i == j) arti++;
                        else eksi++;
                        break;
                    }
                }
            }
            //kullanıcı tahmin sonucu yazdırma
            string sonuc = "";
            if (arti == 4)
            {
                sonuc = "Tebrikler Doğru tahmiin ettiniz\n Sayı : " + sayi;
                kulTahminSonucT.Text = sonuc;
                MessageBox.Show(sonuc);
            }
            else
            {
                sonuc = "";
                if (arti != 0) sonuc += "+" + arti + "\n";
                if (eksi != 0) sonuc += "-" + eksi + "\n";
                sonuc += arti + " rakamın yerini doğru tahmin ettiniz.\n";
                sonuc += eksi + " rakamı doğru tahmin ettiniz ama yerleri yanlış.";
                if (arti == 0 && eksi == 0) sonuc = "Tekrar tahmin Etmeyi Deneyiniz";
                kulTahminSonucT.Text = sonuc;
            }

        }

        private void tahminB_Click(object sender, EventArgs e)
        {
            this.siraKontrol(1);
            int sayi;
            // kontrol başlangıç
            if (tahminT.Text.Length != 4) MessageBox.Show("Lütfen 4 basamaklı bir sayı giriniz!");
            else if (!int.TryParse(tahminT.Text, out sayi)) MessageBox.Show("Lütfen sadece rakam giriniz!");
            else this.tahmin(sayi);
            //kontrol bitiş
        }


        //bilgisayar tahmin kontrol -- Tahmin p ucu olduğu zman buraya gelir
        private void bilTahmin()
        {
            int[] sonTah = rakamla(bilSonTahmin);
            for (int i = 0; i < 4; i++)
            {
                bilTahminX[i, 0] = sonTah[i];
            }
            // artıda artış var ise tek rakam üzerinde işlem yaparak artışa sebep olduğu düşünülen rakam hafızaya alınır.
            if (bilTahminDeger[0, 0] > bilTahminDeger[1, 0])
            {
                int i = 0;
                //hafıza boş yer var mı diye kontrol edilir. kontrolde dolu bulunan yerler boşaltılır.
                for (; i < 4; i++)
                {
                    if (bilTahminX[i, 1] == -1 && bilTahminX[i, 2] == -1) break;
                    else bilTahminX[i, 1] = -1;

                }
                if (i != 4)
                {
                    bilTahminX[i, 1] = bilTahminX[i, 0];
                    while (true) //hafızaya alınan rakamın yerine sonTahmin de bulunmayan bir rakam atanır.
                    {
                        int j = 0;
                        for (; j < 4; j++)
                        {
                            if (i == 0 && bilTahminX[i, 1] == 9)
                            {
                                if (i != j && ((bilTahminX[i, 1] + 2) % 10) == bilTahminX[j, 0]) break;
                            }
                            else
                            {
                                if (i != j && ((bilTahminX[i, 1] + 1) % 10) == bilTahminX[j, 0]) break;
                            }
                        }
                        if (j == 4)
                        {
                            bilTahminX[i, 0] = (bilTahminX[i, 0] + 1) % 10;
                            break;
                        }
                    }
                }
            }
            //artıda azalma olduysa hafızaya alınan son rakam doğrudur ve kalıcı hafızaya alınır.
            else if (bilTahminDeger[0, 0] < bilTahminDeger[1, 0])
            {
                for (int i = 0; i < 4; i++)
                {
                    if (bilTahminX[i, 1] != -1)
                    {
                        bilTahminX[i, 2] = bilTahminX[i, 1];
                        break;
                    }
                }
            }
            else//eğer artılar da değişme yok ise eksileri kontrol et
            {
                int j = -1;

                if (bilTahminDeger[0, 1] > bilTahminDeger[1, 1])//eksilerde artış varsa
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (bilTahminX[i, 2] == -1 && bilTahminX[i, 2] == -1)
                        {
                            if (j != -1)
                            {
                                bilTahminX[i, 1] = bilTahminX[j, 0];
                                bilTahminX[j, 1] = bilTahminX[i, 0];
                                break;
                            }
                            else j = i;
                        }
                    }
                }

                else if (bilTahminDeger[0, 1] == bilTahminDeger[1, 1])//eksilerde değişme yoksa
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (bilTahminX[i, 2] == -1  )
                        {
                            if (j == -1 && bilTahminX[i, 1] == -1) j = i;
                            else if (j != -1 && bilTahminX[i, 1] != -1)//eğer sabit hafızada yeterli yer yoksa buraya girmez
                            {
                                bilTahminX[j, 1] = bilTahminX[i, 1];
                                bilTahminX[i, 1] = bilTahminX[j, 0];
                                break;
                            }
                        }
                    }
                }
            }

            bilTahminDeger[1, 0] = bilTahminDeger[0, 0];//artiları hafızaya al
            bilTahminDeger[1, 1] = bilTahminDeger[0, 1];//eksileri hafıyaza al

            for (int i = 0; i < 4; i++)
            {
                if (bilTahminX[i, 2] == -1 && bilTahminX[i, 1] == -1)
                {
                    if (i == 0) sonTah[i] = new Random().Next(1, 10);
                    else sonTah[i] = new Random().Next(0, 10);
                }
                else if (bilTahminX[i, 1] != -1) sonTah[i] = bilTahminX[i, 1];
                else sonTah[i] = bilTahminX[i, 0];

            }
            bilSonTahmin = sayila(sonTah);

        }


        private int rastgeleTahmin()
        {
           return  new Random().Next(1000, 10000);
        }
        private void bilTahimB_Click(object sender, EventArgs e)
        {
            this.siraKontrol(2);
            // ilk rastgele tahmin
            if (!ilkTahmin)
            {
                ilkTahmin = true;
                bilSonTahmin = this.rastgeleTahmin();
            }
            else
            {
                //tahmin ip ucu yoksa yeni bir rastgele tahmin yap
                if (bilTahminDeger[0, 0] == 0 && bilTahminDeger[0, 1] == 0)
                {
                    bilSonTahmin = this.rastgeleTahmin();
                }
                    // else tahmin işlemi yap
                else this.bilTahmin();
            }
            bilTahminT.Text = bilSonTahmin + "";
        }

        // Başla - kullanıcı değerlendime sonuc text kontrol
        private string textKotrol(string t)
        {
            if (!string.IsNullOrEmpty(t))
            {
                int s;
                if (!int.TryParse(t, out s)) MessageBox.Show("Lütfen rakam giriniz!");
                if (s > 4) return "4";
                else if (s < 0) return "0";
                return s.ToString();
            }
            return "";
        }

        private void artiT_TextChanged(object sender, EventArgs e)
        {
            artiT.Text = textKotrol(artiT.Text);
        }

        private void eksiT_TextChanged(object sender, EventArgs e)
        {
            eksiT.Text = textKotrol(eksiT.Text);
        }

        // Bitiş - kullanıcı değerlendime sonuc text kontrol


        private void degerB_Click(object sender, EventArgs e)
        {
            siraKontrol(0);
            if (int.Parse(artiT.Text) == 4)
            {
                if (DialogResult.Yes
                    == MessageBox.Show(
                        "Bilgisayar oyunu kazandı. Oyun Yeniden Başlasın mı?",
                        "Uyarı!!",
                        MessageBoxButtons.YesNo)) Application.Restart();
            }

            else
            {
                if (string.IsNullOrEmpty(artiT.Text)) bilTahminDeger[0, 0] = 0;
                else bilTahminDeger[0, 0] = int.Parse(artiT.Text);
                if (string.IsNullOrEmpty(eksiT.Text)) bilTahminDeger[0, 1] = 0;
                else bilTahminDeger[0, 1] = int.Parse(eksiT.Text);
            }
        }

        private void artiT_Enter(object sender, EventArgs e)
        {
            artiT.Text = "";
        }

        private void eksiT_Enter(object sender, EventArgs e)
        {
            eksiT.Text = "";
        }
    }
}