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
    public partial class Bilet_al_secenek : Form
    {
        public Bilet_al_secenek()
        {
            InitializeComponent();
        }

        private void vizyondakilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new Vizyondakiler();
            Bilet_al_secenek.ActiveForm.Close();
            newForm.Show();
        }

        private void yakındaGelecekFilmlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new Yakında_gelecek_filmler();
            Bilet_al_secenek.ActiveForm.Close();
            newForm.Show();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new Anasayfa();
            Bilet_al_secenek.ActiveForm.Close();
            newForm.Show();

        }
    }
}
