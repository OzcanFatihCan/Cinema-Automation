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
    public partial class Bilet_al : Form
    {
        public Bilet_al()
        {
            InitializeComponent();
        }
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=" + Application.StartupPath + "\\vt_sinema_otomasyonu.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
                panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else
                panel2.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            koltuk_sec = "1. Koltuk";
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            koltuk_sec = "2. Koltuk";
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            koltuk_sec = "3. Koltuk";
            if (checkBox3.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            koltuk_sec = "4. Koltuk";
            if (checkBox4.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox1.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox1.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            koltuk_sec = "5. Koltuk";
            if (checkBox5.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox1.Enabled = false;
                checkBox6.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox1.Enabled = true;
                checkBox6.Enabled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            koltuk_sec = "6. Koltuk";
            if (checkBox6.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new Anasayfa();
            Bilet_al.ActiveForm.Close();
            newForm.Show();

        }
        //
        //
        string tc,adi, soyadi, yas, telefon, film_adi, seans, koltuk_sec,hizmet_puani;

        OleDbDataReader dr;
        OleDbCommand cmd;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            var newForm = new Vizyondakiler();
            Bilet_al.ActiveForm.Close();
            newForm.Show();
        }

        private void Bilet_al_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 5;
            cmd = new OleDbCommand();
            baglantim.Open();
            cmd.Connection = baglantim;
            cmd.CommandText = "SELECT * FROM film_vt";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Film_Adi"]);

            }
            baglantim.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            tc = maskedTextBox2.Text;
            adi = textBox1.Text;
            soyadi = textBox2.Text;
            telefon = maskedTextBox1.Text;
            film_adi = comboBox1.SelectedItem.ToString();
            seans = listBox1.SelectedItem.ToString();
            hizmet_puani = trackBar1.Value.ToString();
            if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("Tc No Alanı Boş Geçilemez");
            }
            
            else
            {

                try
                {
                    baglantim.Open();
                    OleDbCommand eklekomutu = new OleDbCommand("insert into Musteri_bilgi_vt (Tc,Ad,Soyad,Yas,Telefon,Film_adi,Seans,Koltuk_secimi,Hizmet_puanı) values('" + tc + "','" + adi + "','" + soyadi + "','" + yas + "','" + telefon + "','" + film_adi + "','" + seans + "','" + koltuk_sec + "','" + hizmet_puani + "')", baglantim);
                    eklekomutu.ExecuteNonQuery();
                    baglantim.Close();
                    MessageBox.Show("Biletiniz Başarılı Bir Şekilde Kayıt Edildi");
                    textBox1.Clear();
                    textBox2.Clear();
                    maskedTextBox1.Clear();
                    maskedTextBox2.Clear();
                    listBox1.ClearSelected();

                }
                catch (Exception aciklama)
                {

                    MessageBox.Show(aciklama.Message, "Bir hata oluştu!");
                    baglantim.Close();
                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
 

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            yas = "3-12";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            yas = "13-26";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            yas = "+26";
        }
    }
}
