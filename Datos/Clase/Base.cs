using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Comun;

namespace Datos
{
    public class Base
    {
        public Base ()
        {
            if (VariablesPublicas.ListaVuelos.ToList().Count() > 0)
            {
                VariablesPublicas.ListaVuelos.Clear();
            }
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Dos, Equipaje = true, Precio = 150 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Argentina, CodPaisOrigen = (int)Paises.Peru, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Tres, Equipaje = false, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Colombia, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Cuatro, Equipaje = false, Precio = 150 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Venezuela, CodPaisOrigen = (int)Paises.Colombia, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Una, Equipaje = false, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Tres, Equipaje = false, Precio = 150 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Colombia, CodPaisOrigen = (int)Paises.Peru, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Una, Equipaje = false, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Chile, CodPaisOrigen = (int)Paises.Colombia, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Dos, Equipaje = true, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Colombia, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Una, Equipaje = true, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Venezuela, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Cuatro, Equipaje = true, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Venezuela, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Cuatro, Equipaje = true, Precio = 150 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Argentina, CodPaisOrigen = (int)Paises.Venezuela, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Dos, Equipaje = false, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Argentina, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Tres, Equipaje = true, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Venezuela, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Una, Equipaje = false, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Argentina, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Cuatro, Equipaje = true, Precio = 150 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Argentina, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Tres, Equipaje = true, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Colombia, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Una, Equipaje = false, Precio = 150 });
        }
        public ListaVuelos BusquedaListaVuelos(int vCantidadEscalas, bool vEquipaje, double vPrecio)
        {
            ListaVuelos ListaVuelos = new ListaVuelos();                    
            try
            {
                if (VariablesPublicas.ListaVuelos.ToList().Count > 0)
                {
                    ListaVuelos.AddRange((from q in VariablesPublicas.ListaVuelos
                                          where q.CantEscalas == vCantidadEscalas && q.Equipaje == vEquipaje && q.Precio == vPrecio
                                          select q).ToList());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ListaVuelos;
        }

    }
}
