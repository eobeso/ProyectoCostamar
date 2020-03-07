using Comun;
using Entidad;
using System;
using System.Linq;

namespace Datos
{
    public class ListaVuelosDA
    {
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
