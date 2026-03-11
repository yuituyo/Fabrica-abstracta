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
    }
}
