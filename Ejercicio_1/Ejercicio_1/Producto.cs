using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Producto
    {

        private int codBarras;
        private string nombre;
        private string descripcion;
        private float precio;

        public Producto(int codBarras, string nombreProd, string descr, float precio)
        {
            this.codBarras = codBarras;
            this.nombre = nombreProd;
            this.descripcion = descr;
            this.precio = precio;

        }



        public string getNombre()
        {
            return this.nombre;
        }

        public int getCodBarras()
        {
           return this.codBarras;
        }

        public string getDescripcion()
        {
            return this.descripcion;
        }

        public float getPrecio()
        {
            return this.precio;
        }

    }
}
