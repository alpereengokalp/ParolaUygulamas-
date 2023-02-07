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
    public partial class FormParolaGoruntule : Form
    {
        public FormParolaGoruntule()
        {
            InitializeComponent();
        }

        private void buttonGoster_Click(object sender, EventArgs e)
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
    }
}
