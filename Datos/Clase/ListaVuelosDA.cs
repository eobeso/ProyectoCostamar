using Comun;
using Entidad;
using System;
using System.Linq;

namespace Datos
{
    public class ListaVuelosDA
    {
        public ListaVuelos BusquedaListaVuelos(RequestVuelos oRequestVuelos)
        {
            ListaVuelos ListaVuelos = new ListaVuelos();
            try
            {
                if (VariablesPublicas.ListaVuelos.ToList().Count > 0)
                {
                    ListaVuelos.AddRange((from q in VariablesPublicas.ListaVuelos
                                          where q.CantEscalas == oRequestVuelos.CantidadEscalas && q.Equipaje == oRequestVuelos.Equipaje && q.Precio == oRequestVuelos.Precio
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
