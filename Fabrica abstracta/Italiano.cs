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
    public partial class Italiano : Form
    {
        Form anterior;

        public Italiano(Form previo)
        {
            InitializeComponent();
            this.anterior = previo;
        }

        private void Italiano_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Restaurantes ita = new RestauranteItaliano();

            Comida comida = ita.PedirComida();
            Bebida bebida = ita.ServirBebida();
            Postre postre = ita.OrdenarPostre();

            comida.PedirC();
            bebida.ServirB();
            postre.OrdenarP();
        }
    }
}
