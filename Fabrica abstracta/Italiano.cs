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
    }
}
