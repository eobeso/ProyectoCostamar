using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class ResponseVuelos
    {
        private string paisOrigen;
        private string paisDestino;
        private DateTime fechaSalida;
        private DateTime fechaRetorno;
        private string escalas;
        private string equipaje;
        private double precio;

        public string PaisOrigen
        {
            get
            {
                return paisOrigen;
            }

            set
            {
                paisOrigen = value;
            }
        }
        public string PaisDestino
        {
            get
            {
                return paisDestino;
            }

            set
            {
                paisDestino = value;
            }
        }
        public DateTime FechaSalida
        {
            get
            {
                return fechaSalida;
            }

            set
            {
                fechaSalida = value;
            }
        }
        public DateTime FechaRetorno
        {
            get
            {
                return fechaRetorno;
            }

            set
            {
                fechaRetorno = value;
            }
        }      
        public string Equipaje
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
        public string Escalas
        {
            get
            {
                return escalas;
            }

            set
            {
                escalas = value;
            }
        }
    }
}
