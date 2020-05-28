using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_2
{
    public class TipoNafta
    {
        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private string tipoDeNafta;

        public string TipoDeNafta
        {
            get { return tipoDeNafta; }
            set { tipoDeNafta = value; }
        }
    }
}