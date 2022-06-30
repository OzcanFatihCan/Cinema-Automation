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
    public partial class Vizyondakiler : Form
    {
        public Vizyondakiler()
        {
            InitializeComponent();
        }
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=" + Application.StartupPath + "\\vt_sinema_otomasyonu.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Passengers();
            Vizyondakiler.ActiveForm.Close();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Yedinci_kogus();
            Vizyondakiler.ActiveForm.Close();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new Bilet_al_secenek();
            Vizyondakiler.ActiveForm.Close();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new Parasite();
            Vizyondakiler.ActiveForm.Close();
            newForm.Show();
        }
        OleDbDataReader dr;
        OleDbCommand cmd;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var newForm = new Bilet_al();
            Vizyondakiler.ActiveForm.Close();
            newForm.Show();

            
        }

        private void Vizyondakiler_Load(object sender, EventArgs e)
        {
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
    }
}
