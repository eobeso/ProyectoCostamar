using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class RequestVuelos
    {
        private int cantidadEscalas;
        private bool equipaje;
        private double precio;

        public int CantidadEscalas
        {
            get
            {
                return cantidadEscalas;
            }

            set
            {
                cantidadEscalas = value;
            }
        }
        public bool Equipaje
        {
            get
            {
                return equipaje;
            }

            set
            {
                equipaje = value;
            }
        }
        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
    }
}
