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
    public partial class Parasite : Form
    {
        public Parasite()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new Vizyondakiler();
            Parasite.ActiveForm.Close();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new Bilet_al();
            Parasite.ActiveForm.Close();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Xey1oYCWbV4");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
                panel1.Visible = false;
        }
    }
}
