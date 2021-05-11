using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        string nombre;
        List<Publicacion> ventas;

        //InformeDeVentas será de clase y retornará la información del vendedor, sus ventas y la
        //ganancia total de las mismas con el siguiente formato:
        public string InformedeVentas(Vendedor v)
        {
            float acumuladorGanancia = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE");
            sb.AppendLine($"{v.nombre}");
            sb.AppendLine("------------");
            //información de cada una de las publicaciones, hay que hacer un foreach
            foreach (Publicacion p in v.ventas)
            {
                sb.AppendLine($"PUBLICACION: {p.Informacion()}");
                acumuladorGanancia = acumuladorGanancia + p.Importe;
            }
            sb.AppendLine("------------");
            sb.AppendLine($"Ganancia total: {acumuladorGanancia} ");
            return sb.ToString();
        }
        //El operador + agregará siempre y cuando haya stock suficiente para realizar una venta del
        //producto, agregando en ese caso la información de la venta a la lista y descontando Stock de
        //la publicación.
        public static bool operator +(Vendedor v, Publicacion p)
        {
            bool resultado = false;
           
            if ((object)v != null && (object)p != null)
            {
                if (p.HayStock)
                {
                    v.ventas.Add(p);
                    p.Stock--;
                    resultado = true;
                }
            }
            return resultado;
        }
        //La lista se inicializará en el constructor privado.
        private Vendedor()
        {
            this.ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre) : this()
        {
            this.nombre = nombre;
        }
      
    }
}
