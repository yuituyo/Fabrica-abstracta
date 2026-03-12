using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrica_abstracta
{
    //Fabrica Central
    public abstract class Restaurantes

    {
        public abstract Comida PedirComida();
        public abstract Bebida ServirBebida();
        public abstract Postre OrdenarPostre();
    }
    //Metodos
    public abstract class Comida
    {
        public abstract void PedirC();
    }

    public abstract class Bebida
    {
        public abstract void ServirB();
    }

    public abstract class Postre
    {
        public abstract void OrdenarP();
    }

    //Generar Comida
    //Comida Mexicana
    public class Tacos : Comida
    {
        public override void PedirC()
        {

            MessageBox.Show("Comida: Tacos");

            
        }
    }
    //Generar Comida
    public class AguaJamaica : Bebida
    {
        public override void ServirB()
        {
            MessageBox.Show("Bebida: Agua de Jamaica");
        }
    }
    //Generar Postre
    public class PastelTresLeches : Postre
    {
        public override void OrdenarP()
        {
            MessageBox.Show("Postre: Pastel de Tres Leches");
        }
    }
    //Comida China
    public class Cantones : Comida
    {
        public override void PedirC()
        {
            MessageBox.Show("Comida: Pollo Cantones");
        }
    }

    public class TeJazmin : Bebida
    {
        public override void ServirB()
        {
            MessageBox.Show("Bebida: Te de Jazmin");
        }
    }

    public class RollosDulces : Postre
    {
        public override void OrdenarP()
        {
            MessageBox.Show("Postre: Rollos Dulces");
        }
    }
    //Comida Japonesa

    public class Ramen : Comida
    {
        public override void PedirC()
        {
            MessageBox.Show("Comida: Ramen");
        }
    }
    public class Sake : Bebida
    {
        public override void ServirB()
        {
            MessageBox.Show("Bebida: Sake");
        }
    }

    public class Dango : Postre
    {
        public override void OrdenarP()
        {
            MessageBox.Show("Postre: Dango");
        }
    }
    //Comida Italiana
    public class Pizza : Comida
    {
        public override void PedirC()
        {
            MessageBox.Show("Comida: Pizza");
        }
    }
    public class Vino : Bebida
    {
        public override void ServirB()
        {

            MessageBox.Show("Bebida: Vino");
        }
    }
    public class Tiramisu : Postre
    {
        public override void OrdenarP()
        {
            MessageBox.Show("Postre: Tiramisu");
        }
    }
    //Comida Americana
    public class Hamburguesa : Comida
    {
        public override void PedirC()
        {
            MessageBox.Show("Comida: Hamburguesa");
        }
    }
    public class DrPepper : Bebida
    {
        public override void ServirB()
        {
            MessageBox.Show("Bebida: Dr Pepper");
        }
    }
    public class PayManzana : Postre
    {
        public override void OrdenarP()
        {
            MessageBox.Show("Postre: Pay de Manzana");
        }
    }
    //Fabricas Especificas
    public class RestauranteMexicano : Restaurantes
    {
        public override Comida PedirComida()
        {
            return new Tacos();
        }
        public override Bebida ServirBebida()
        {
            return new AguaJamaica();
        }
        public override Postre OrdenarPostre()
        {
            return new PastelTresLeches();
        }
    }
    public class RestauranteChino : Restaurantes
    {
        public override Comida PedirComida()
        {
            return new Cantones();
        }
        public override Bebida ServirBebida()
        {
            return new TeJazmin();
        }
        public override Postre OrdenarPostre()
        {
            return new RollosDulces();
        }
    }
    public class RestauranteJapones : Restaurantes
    {
        public override Comida PedirComida()
        {
            return new Ramen();
        }
        public override Bebida ServirBebida()
        {
            return new Sake();
        }
        public override Postre OrdenarPostre()
        {
            return new Dango();
        }
    }
    public class RestauranteItaliano : Restaurantes
    {
        public override Comida PedirComida()
        {
            return new Pizza();
        }
        public override Bebida ServirBebida()
        {
            return new Vino();
        }
        public override Postre OrdenarPostre()
        {
            return new Tiramisu();
        }
    }
    public class RestauranteAmericano : Restaurantes
    {
        public override Comida PedirComida()
        {
            return new Hamburguesa();
        }
        public override Bebida ServirBebida()
        {
            return new DrPepper();
        }
        public override Postre OrdenarPostre()
        {
            return new PayManzana();
        }
    }
}
