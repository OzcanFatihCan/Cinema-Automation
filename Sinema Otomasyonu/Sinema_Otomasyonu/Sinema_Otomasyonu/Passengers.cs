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
    public partial class Passengers : Form
    {
        public Passengers()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new Vizyondakiler();
            Passengers.ActiveForm.Close();
            newForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
                panel1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=8GKyQ1S5594%22");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new Bilet_al();
            Passengers.ActiveForm.Close();
            newForm.Show();
        }
    }
}
