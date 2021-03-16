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
    public partial class carrito : Form
    {
        public carrito()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void carrito_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form pictureBox9 = new favoritos();
            pictureBox9.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form pictureBox4 = new Form2();
            pictureBox4.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
