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
    public partial class Yonetici_giris : Form
    {
        public Yonetici_giris()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                var newForm = new Yonetici_islem();
                newForm.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Yanlış Bilgi Girdiniz.", "Hata");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Anasayfa();
            Yonetici_giris.ActiveForm.Close();
            newForm.Show();

        }
    }
}
