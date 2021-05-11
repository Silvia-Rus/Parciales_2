using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biografia : Publicacion
    {
        public override bool EsColor
        {
            //EsColor siempre será que NO.
            get
            {
                return false;
            }
        }
        //HayStock controlará solo que haya stock, sin importar el valor de venta.
        public override bool HayStock
        {
            get
            {
                if (this.stock > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        

        public Biografia(string nombre) : base(nombre)
        {}

        public Biografia(string nombre, int stock):  base(nombre, stock)
        { }

        public Biografia(string nombre, int stock, float valor) : base(nombre, stock)
        {
            this.importe = valor;
        }
        ////La conversión explicita generará un objeto Biografia.
        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }
    }
}
