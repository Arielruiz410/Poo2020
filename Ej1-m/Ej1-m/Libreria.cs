using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1_m
{
    public class Libreria
    {
        public void AgregarProducto(string cbarras, string descripcion, string nombre, float precio)
        {
            Producto producto = new Producto();
            producto.CodigoDeBarras = cbarras;
            producto.Descripcion = descripcion;
            producto.NombreDeProducto = nombre;
            producto.Precio = precio;
        }

        float ventasTotales;
        public void vender(Producto producto, int cantidad)
        {
            ventasTotales += producto.Precio * cantidad;
        }
    }
}