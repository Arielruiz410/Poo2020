using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Libreria
    {


        private string nombreLibreria;
        private Producto prodLapicera;
        private Producto prodResma;
        private Producto prodMarcadores;
        private float recaudacion = 0;
        private int cantVentas = 0;

        public Libreria()
        {
            
            if (this.prodLapicera == null)
            {
                this.prodLapicera = new Producto(001, "Lápicera", "Sirve para escribir", float.Parse("9,99"));
            }

            if (this.prodResma == null)
            {
                this.prodResma = new Producto(002, "Resma A4", "400 hojas A4", float.Parse("29,99"));
            }

            if (this.prodMarcadores == null)
            {
                this.prodMarcadores = new Producto(003, "Marcadores", "Varios colores", float.Parse("15,99"));
            }
        }

        public float getRecaudacionTotal()
        {
            return this.recaudacion;
        }

        public float venderProducto(int codBarra, int cantidad)
        {
            this.cantVentas++;
            float importeVenta = 0;

            if (codBarra==1)
            {
                importeVenta = prodLapicera.getPrecio() * cantidad;

            }else if (codBarra==2)
            {
                importeVenta = prodResma.getPrecio() * cantidad;
            }
            else
            {
                importeVenta = prodMarcadores.getPrecio() * cantidad;
            }

            recaudacion += importeVenta;

            return importeVenta;

        }

        public void setNombre(string nombre)
        {
            this.nombreLibreria = nombre;
        }

        public Producto obtenerProducto(int codBarra)
        {

            Producto prod = prodLapicera;

            if (codBarra==2)
            {
                prod = prodResma;

            }else if (codBarra == 3)
            {
                prod = prodMarcadores;
            }
            return prod;
        }

        public int getCantVentas()
        {
            return this.cantVentas;
        }
    }
}
