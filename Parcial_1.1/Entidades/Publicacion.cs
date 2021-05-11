using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected  int stock;

        public abstract  bool EsColor
        {
            get;

        }

        //HayStock será virtual, retornará True siempre y cuando haya stock y el importe sea mayor a 0 (cero).
        public virtual bool HayStock
        {
            get
            {
                if(this.stock>=0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public float Importe
        {
            get
            {
                return this.importe;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }

            set
            {
                this.stock = value;
            }
        }
        //Informacion retornará los datos de la Publicacion utilizando StringBuilder (deberá utilizar
        //todos los métodos Append disponibles). Completar las palabras en mayúscula con los datos
        //de cada elemento según corresponda:
        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Stock: {this.Stock}");
            //sb.AppendLine($"Color: {this.EsColor}");
            sb.AppendLine($"Valor: {this.Importe}");
            return sb.ToString();
        }

        public Publicacion()
        { }
        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock) : this(nombre)
        {
            this.stock = stock;
        }

        //ToString() retornará el nombre (servirá para el formulario)
        public override string ToString()
        {
            return this.nombre;
        }
    }
}
