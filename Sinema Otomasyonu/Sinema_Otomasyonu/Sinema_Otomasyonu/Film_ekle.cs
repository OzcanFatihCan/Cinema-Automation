using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace Sinema_Otomasyonu
{
    public partial class Film_ekle : Form
    {
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=" + Application.StartupPath + "\\vt_sinema_otomasyonu.accdb");
        public Film_ekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
                panel1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newForm = new Yonetici_islem();
            Film_ekle.ActiveForm.Close();
            newForm.Show();

        }

        private void Film_ekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "JPEG Files(*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg|All Files(*.*)|*.*";
                if (openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    textBox3.Text = openFileDialog1.FileName.ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "JPEG Files(*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg|All Files(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox5.Text = openFileDialog1.FileName.ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "JPEG Files(*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg|All Files(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox6.Text = openFileDialog1.FileName.ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "JPEG Files(*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg|All Files(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox7.Text = openFileDialog1.FileName.ToString();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        string Film_Adi, Film_Turu, Fragman_link, Afis, Fotograf_1, Fotograf_2, Fotograf_3;

        private void button6_Click(object sender, EventArgs e)
        {
            Film_Adi = textBox1.Text;
            Film_Turu = textBox2.Text;
            Fragman_link = textBox4.Text;
            Afis = textBox3.Text;
            Fotograf_1 = textBox5.Text;
            Fotograf_2 = textBox6.Text;
            Fotograf_3 = textBox7.Text;
            if (textBox1.Text=="")
            {
                MessageBox.Show("Film Adı Alanı Boş Geçilemez");
            }
            else
            {
                
            
            try
            {
                baglantim.Open();
                OleDbCommand eklekomutu = new OleDbCommand("insert into film_vt (Film_Adi,Afis,Fragman_link,Fotograf_1,Fotograf_2,Fotograf_3,Film_Turu) values('" + Film_Adi + "','" + Afis + "','" + Fragman_link + "','" + Fotograf_1 + "','" + Fotograf_2 + "','" + Fotograf_3 + "','" + Film_Turu + "')", baglantim);
                eklekomutu.ExecuteNonQuery();
                baglantim.Close();
                MessageBox.Show("Film Bilgileri Başarılı Bir Şekilde Kayıt Edildi");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();


            }
            catch (Exception aciklama)
            {

                MessageBox.Show(aciklama.Message, "Bir hata oluştu!");
                baglantim.Close();
            }
            }

        }
    }
}
