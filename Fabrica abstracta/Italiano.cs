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

        private void button1_Click(object sender, EventArgs e)
        {
            Restaurantes chino = new RestauranteItaliano();

            Comida comida = chino.PedirComida();
            Bebida bebida = chino.ServirBebida();
            Postre postre = chino.OrdenarPostre();

            comida.PedirC();
            bebida.ServirB();
            postre.OrdenarP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            anterior.Show();
            this.Close();
        }
    }
}
