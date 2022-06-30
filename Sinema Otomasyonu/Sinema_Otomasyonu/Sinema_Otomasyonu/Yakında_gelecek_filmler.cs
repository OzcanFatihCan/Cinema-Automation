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
    public partial class Yakında_gelecek_filmler : Form
    {
        public Yakında_gelecek_filmler()
        {
            InitializeComponent();
        }

        private void Yakında_gelecek_filmler_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 7000;//filmlerin vizyon tarihinin kalan süresine göre daha hızlı akma süresi
            timer2.Start();
            timer2.Interval = 10000;//filmlerin vizyon tarihinin kalan süresine göre daha hızlı akma süresi
            timer3.Start();
            timer3.Interval = 5000;//filmlerin vizyon tarihinin kalan süresine göre daha hızlı akma süresi
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Value + 1;
                return;
            }
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
            if (progressBar2.Value < progressBar2.Maximum)
            {
                progressBar2.Value = progressBar2.Value + 1;
                return;
            }
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Minimum = 0;
            progressBar3.Maximum = 100;


            if (progressBar3.Value < progressBar3.Maximum)
            {
                progressBar3.Value = progressBar3.Value + 1;
                return;
            }
            timer3.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new Bilet_al_secenek();
            Yakında_gelecek_filmler.ActiveForm.Close();
            newForm.Show();
        }
    }
}
