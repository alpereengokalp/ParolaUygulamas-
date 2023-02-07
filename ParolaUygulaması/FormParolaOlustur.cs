using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParolaUygulaması
{
    public partial class FormParolaOlustur : Form
    {
        public FormParolaOlustur()
        {
            InitializeComponent();
        }

        public string secim = "";

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            string islem1 = comboBoxSeviye.Text;

            string deger = textBoxYaz.Text;

            secim = textBoxSecim.Text + ": ";

            DosyaVeriYaz(secim);

            if (islem1 == "Seviye 1")
            {
                asama1(deger);
            }
            else if (islem1 == "Seviye 2")
            {
                asama2(deger);
            }
            else if (islem1 == "Seviye 3")
            {
                asama3(deger);
            }
            else if (islem1 == "Seviye 4")
            {
                asama4(deger);
            }
            
        }

        private void FormParolaOlustur_Load(object sender, EventArgs e)
        {
            comboBoxSeviye.Items.Add("Seviye 1");

            comboBoxSeviye.Items.Add("Seviye 2");

            comboBoxSeviye.Items.Add("Seviye 3");

            comboBoxSeviye.Items.Add("Seviye 4");

            textBoxYaz.MaxLength = 10;
        }

        public static string asama1(string deger1)
        {
            Random rastgele = new Random();
            string sonuc = deger1;

            byte sayi;
            byte[] sayilar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            StringBuilder sb = new StringBuilder();

            for (byte i = 0; i < sonuc.Length; i++)
            {
                sayi = Convert.ToByte(rastgele.Next(0, sayilar.Length));
                if (sonuc[i] % 2 == 0)
                {
                    sb.Append(sonuc[i]);
                }
                else
                {
                    sb.Append(deger1[i]);
                    sb.Append(sayi);
                }
            }
            deger1 = sb.ToString() + "\n";
            DosyaVeriYaz(deger1);
            return deger1;
        }

        public static string asama2(string deger2)
        {

            Random rastgele = new Random();
            string sonuc = deger2;

            StringBuilder sb = new StringBuilder();

            char[] karakter = { '*', '/', '$', '%', '-', '?', '!', '(', ')', '_' };
            byte secim;

            for (byte i = 0; i < sonuc.Length; i++)
            {
                secim = Convert.ToByte(rastgele.Next(0, karakter.Length));
                if (sonuc[i] % 2 == 0)
                {
                    sb.Append(sonuc[i]);
                    sb.Append(karakter[secim]);
                }
                else
                {
                    sb.Append(deger2[i]);
                }
            }
            deger2 = sb.ToString() + "\n";
            DosyaVeriYaz(deger2);
            return deger2;
        }

        public static string asama3(string deger3)
        {
            Random rastgele = new Random();           
            string sonuc = deger3;

            byte sayi;
            byte[] sayilar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; 

            StringBuilder sb = new StringBuilder();

            char[] karakter = { '*', '/', '$', '%', '-', '?', '!', '(', ')', '_' };
            byte secim;

            for (byte i = 0; i < sonuc.Length; i++)
            {
                secim = Convert.ToByte(rastgele.Next(0, karakter.Length));
                sayi = Convert.ToByte(rastgele.Next(0, sayilar.Length)); 
                if (sonuc[i] % 2 == 0)
                {
                    sb.Append(sonuc[i]);
                    sb.Append(karakter[secim]);
                }
                else
                {
                    sb.Append(deger3[i]);
                    sb.Append(sayi); 
                }
            }
            deger3 = sb.ToString() + "\n";
            DosyaVeriYaz(deger3);
            return deger3;
        }

        public static string asama4(string deger4)
        {
            Random rastgele = new Random();
            string sonuc = degisim(deger4);

            byte sayi;
            byte[] sayilar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            StringBuilder sb = new StringBuilder();

            char[] karakter = { '*', '/', '$', '%', '-', '?', '!', '(', ')', '_' };
            byte secim;

            for (byte i = 0; i < sonuc.Length; i++)
            {
                secim = Convert.ToByte(rastgele.Next(0, karakter.Length));
                sayi = Convert.ToByte(rastgele.Next(0, sayilar.Length));
                if (sonuc[i] % 2 == 0)
                {
                    sb.Append(sonuc[i]);
                    sb.Append(karakter[secim]);
                }
                else
                {
                    sb.Append(deger4[i]);
                    sb.Append(sayi);
                }
            }
            deger4 = sb.ToString() + "\n";
            DosyaVeriYaz(deger4);
            return deger4;
        }

        private static void DosyaVeriYaz(string yaz)
        {
            
            FileStream fs = new FileStream("sifreler.txt", 
                    FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.Write(yaz);
            sw.Close();
        }

        private void textBoxYaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Sadece string girişi yapılır

            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar); //Sadece karakter girişi

            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }//Boşluk engelleme
        }

        private void textBoxSecim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);

            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }//Boşluk engelleme
        }

        public static string degisim(string sifre)
        {
            return sifre.Replace("a", "@")
            .Replace("e", "3")
            .Replace("E", "3")
            .Replace("i", "1")
            .Replace("ı", "1")
            .Replace("S", "5")
            .Replace("s", "5")
            .Replace("G", "6")
            .Replace("g", "9")
            .Replace("l", "|")
            .Replace("L", "1")
            .Replace("Z", "2")
            .Replace("B", "8")
            .Replace("O", "0")
            .Replace("o", "0")
            .Replace("p", "7")
            .Replace("r", "8")
            .Replace("T", "+");
        }
    }
}
