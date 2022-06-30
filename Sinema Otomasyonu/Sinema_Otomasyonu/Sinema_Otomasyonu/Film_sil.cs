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
    public partial class Film_sil : Form
    {
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=" + Application.StartupPath + "\\vt_sinema_otomasyonu.accdb");
        public Film_sil()
        {
            InitializeComponent();
        }

        OleDbDataReader dr;
        OleDbCommand cmd;
        private void listele()
        {
            listView1.Items.Clear(); 
            baglantim.Open();
            cmd = new OleDbCommand("Select * From film_vt", baglantim);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Film_Adi"].ToString());
                item.SubItems.Add(dr["Afis"].ToString());
                item.SubItems.Add(dr["Fragman_link"].ToString());  
                item.SubItems.Add(dr["Fotograf_1"].ToString());
                item.SubItems.Add(dr["Fotograf_2"].ToString());
                item.SubItems.Add(dr["Fotograf_3"].ToString());
                item.SubItems.Add(dr["Film_Turu"].ToString());

                listView1.Items.Add(item);
            }
            baglantim.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Yonetici_islem();
            Film_sil.ActiveForm.Close();
            newForm.Show();
        }

        private void Film_sil_Load(object sender, EventArgs e)
        {
            listele();
        }
        string a;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                a = listView1.SelectedItems[0].Text;
                OleDbCommand sil = new OleDbCommand("delete from film_vt where Film_Adi='" + a + "' ", baglantim);
                baglantim.Open();
                sil.ExecuteNonQuery();
                baglantim.Close();
                listele();
            }
            catch
            {
                MessageBox.Show("Lütfen listeden silmek istediğiniz Filmi seçiniz");
            }
        }
    }
}
