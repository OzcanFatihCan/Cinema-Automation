using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu
{
    public partial class Yonetici_islem : Form
    {
        public Yonetici_islem()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var newForm = new Anasayfa();
            Yonetici_islem.ActiveForm.Close();
            newForm.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            var newForm = new Anasayfa();
            Yonetici_islem.ActiveForm.Close();
            newForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var newForm = new Film_ekle();
            Yonetici_islem.ActiveForm.Close();
            newForm.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            var newForm = new Film_ekle();
            Yonetici_islem.ActiveForm.Close();
            newForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var newForm = new Film_sil();
            Yonetici_islem.ActiveForm.Close();
            newForm.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            var newForm = new Film_sil();
            Yonetici_islem.ActiveForm.Close();
            newForm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var newForm = new Musteri();
            Yonetici_islem.ActiveForm.Close();
            newForm.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            var newForm = new Musteri();
            Yonetici_islem.ActiveForm.Close();
            newForm.Show();
        }
    }
}
