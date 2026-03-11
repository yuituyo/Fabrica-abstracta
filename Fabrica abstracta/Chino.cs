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
    public partial class Chino : Form
    {   
        Form anterior;

        public Chino(Form previo)
        {
            InitializeComponent();
            anterior = previo;
        }

        private void Chino_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
