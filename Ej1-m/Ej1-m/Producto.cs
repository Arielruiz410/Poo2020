using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1_m
{
    public class Producto
    {
        private string codigoDeBarras;

        public string CodigoDeBarras
        {
            get { return codigoDeBarras; }
            set { codigoDeBarras = value; }
        }

        private string nombreDeProducto;

        public string NombreDeProducto
        {
            get { return nombreDeProducto; }
            set { nombreDeProducto = value; }
        }

        private string descrpcion;

        public string Descripcion
        {
            get { return descrpcion; }
            set { descrpcion = value; }
        }

        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

    }
}