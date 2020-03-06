using System;

namespace Entidad
{
    public class Vuelos
    {
        public Vuelos() //Constructor
        {
        }
        public Vuelos(int codPaisOrigen,int codPaisDestino,DateTime fechaSalida,DateTime fechaRetorno,int cantEscalas,bool equipaje,double precio)
        {
            CodPaisOrigen = codPaisOrigen;
            CodPaisDestino = codPaisDestino;
            FechaSalida = fechaSalida;
            FechaRetorno = fechaRetorno;
            CantEscalas = cantEscalas;
            Equipaje = equipaje;
            Precio = precio;
        }      

        public int CodPaisOrigen { get; set; }
        public int CodPaisDestino { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaRetorno { get; set; }
        public int CantEscalas { get; set; }
        public bool Equipaje { get; set; }
        public double Precio { get; set; }
        
    }
}
