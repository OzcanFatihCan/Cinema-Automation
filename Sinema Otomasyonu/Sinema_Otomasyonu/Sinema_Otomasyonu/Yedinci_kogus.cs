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
    public partial class Yedinci_kogus : Form
    {
        public Yedinci_kogus()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new Vizyondakiler();
            Yedinci_kogus.ActiveForm.Close();
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
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=QfLfrXxMwHg%22");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new Bilet_al();
            Yedinci_kogus.ActiveForm.Close();
            newForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
