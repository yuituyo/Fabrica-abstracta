using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrica_abstracta
{
    public partial class Japones : Form
    {   
        Form _anterior;
        public Japones(Form previo)
        {
            InitializeComponent();
            _anterior = previo;
        }

        private void Japones_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restaurantes chino = new RestauranteJapones();

            Comida comida = chino.PedirComida();
            Bebida bebida = chino.ServirBebida();
            Postre postre = chino.OrdenarPostre();

            comida.PedirC();
            bebida.ServirB();
            postre.OrdenarP();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            _anterior.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
