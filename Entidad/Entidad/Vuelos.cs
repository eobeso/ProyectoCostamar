using System;

namespace Entidad
{
    public class Vuelos
    {
        private int codPaisOrigen;
        private int codPaisDestino;
        private DateTime fechaSalida;
        private DateTime fechaRetorno;
        private int cantEscalas;
        private bool equipaje;
        private double precio;

        public int CodPaisOrigen
        {
            get
            {
                return codPaisOrigen;
            }

            set
            {
                codPaisOrigen = value;
            }
        }
        public int CodPaisDestino
        {
            get
            {
                return codPaisDestino;
            }

            set
            {
                codPaisDestino = value;
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
        public int CantEscalas
        {
            get
            {
                return cantEscalas;
            }

            set
            {
                cantEscalas = value;
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
