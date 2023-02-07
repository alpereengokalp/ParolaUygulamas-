using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParolaUygulaması
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }
        private void FormGetir(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        }
        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            FormParolaOlustur ekle = new FormParolaOlustur();
            FormGetir(ekle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormParolaGoruntule goruntule = new FormParolaGoruntule();
            FormGetir(goruntule);
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            FormParolaSil sil = new FormParolaSil();
            FormGetir(sil);
        }
    }
}
