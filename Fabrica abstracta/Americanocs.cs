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
    public partial class Americanocs : Form
    {
        Form anterior;
        public Americanocs(Form previo)
        {
            InitializeComponent();
            this.anterior = previo;
        }

        private void Americanocs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Restaurantes chino = new RestauranteChino();

            Comida comida = chino.PedirComida();
            Bebida bebida = chino.ServirBebida();
            Postre postre = chino.OrdenarPostre();

            comida.PedirC();
            bebida.ServirB();
            postre.OrdenarP();
        }
    }
}
