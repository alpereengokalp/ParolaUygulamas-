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

namespace ParolaUygulaması
{
    public partial class FormParolaSil : Form
    {
        public FormParolaSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {          

            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Dosya silinsin mi?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                DosyaSilme();
                richTextBoxGoster.Text = "";
            }
            else
            {
                MessageBox.Show("Silinmedi");
            }
        }
        private static void DosyaSilme()
        {
            System.IO.FileInfo dosya = new System.IO.FileInfo("sifreler.txt");
            try
            {
                dosya.Delete();
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }
            //File.Delete(@"C:\Users\ALPEREN\Desktop\sifreler.txt");

        }

        private void buttonKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("sifreler.txt",
                    FileMode.Open);
                StreamReader oku = new StreamReader(fs);
                richTextBoxGoster.Text = oku.ReadToEnd();
                oku.Close();
                fs.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("İşlem başarısız");
            }
        }

        

        private void FormParolaSil_Load(object sender, EventArgs e)
        {
            
        }
    }
}
