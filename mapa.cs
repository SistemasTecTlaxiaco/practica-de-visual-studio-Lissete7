using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiMercadito
{
    public partial class mapa : Form
    {
        public mapa()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form pictureBox9 = new favoritos();
            pictureBox9.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form pictureBox8 = new carrito();
            pictureBox8.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void mapa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form pictureBox4 = new opciones();
            pictureBox4.Show();
        }
    }
}
