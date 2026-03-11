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
    }
}
