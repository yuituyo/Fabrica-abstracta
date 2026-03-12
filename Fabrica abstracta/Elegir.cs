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
    public partial class Elegir : Form
    {
        Form _anterior;

        public Elegir(Form anterior)
        {
            InitializeComponent();
            _anterior = anterior;
        }

        private void Elegir_FormClosed(object sender, FormClosedEventArgs e)
        {
            _anterior.Show();
        }


        private void Elegir_Load(object sender, EventArgs e)
        {

        }

       
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Mexicano mex1 = new Mexicano(this);
            mex1.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Chino chino1 = new Chino(this);
            chino1.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Japones japo1 = new Japones(this);
            japo1.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Italiano ita = new Italiano(this);
            ita.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Americanocs americanos1 = new Americanocs(this);
            americanos1.Show();
            this.Hide();
        }
    }
}
