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
    public partial class Anasayfa : Form
    {
        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Bilet_al_secenek();
            newForm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new Yonetici_giris();
            newForm.Show();
            Visible = false;
        }

        
    }
}
