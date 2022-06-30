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
    public partial class Musteri : Form
    {
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=" + Application.StartupPath + "\\vt_sinema_otomasyonu.accdb");
        public Musteri()
        {
            InitializeComponent();
        }

        OleDbDataReader dr;
        OleDbCommand cmd;
        private void listele()
        {
            listView1.Items.Clear();
            baglantim.Open();
            cmd = new OleDbCommand("Select * From Musteri_bilgi_vt", baglantim);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Tc"].ToString());
                item.SubItems.Add(dr["Ad"].ToString());
                item.SubItems.Add(dr["Soyad"].ToString());
                item.SubItems.Add(dr["Yas"].ToString());
                item.SubItems.Add(dr["Telefon"].ToString());
                item.SubItems.Add(dr["Film_adi"].ToString());
                item.SubItems.Add(dr["Seans"].ToString());
                item.SubItems.Add(dr["Koltuk_secimi"].ToString());
                item.SubItems.Add(dr["Hizmet_puanı"].ToString());
                listView1.Items.Add(item);
            }
            baglantim.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Yonetici_islem();
            Musteri.ActiveForm.Close();
            newForm.Show();
        }
        string a;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = listView1.SelectedItems[0].Text;
                OleDbCommand sil = new OleDbCommand("delete from Musteri_bilgi_vt where Tc='" + a + "' ", baglantim);
                baglantim.Open();
                sil.ExecuteNonQuery();
                baglantim.Close();
                listele();
            }
            catch
            {
                MessageBox.Show("Lütfen listeden silmek istediğiniz Müşteriyi seçiniz");
            }

        }
        private void Musteri_Load(object sender, EventArgs e)
        {
            listele();
        }


    }
}
