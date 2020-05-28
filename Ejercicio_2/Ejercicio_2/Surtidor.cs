using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_2
{
    public class Surtidor : TipoNafta
    {


        private int capacidadRestante;

        public int CapacidadRestante
        {

            get { return capacidadRestante; }
            set { capacidadRestante = value; }
        }

    }
}