using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comic : Publicacion
    {
        private bool esColor;

        public override bool EsColor
        {
            get
            {
                return this.EsColor;
            }
        }

        public Comic(string nombre, bool esColor, int stock, float valor):base(nombre)
        {
            this.esColor = esColor;
            this.stock = stock;
            this.importe = valor;

        }
    }
}
