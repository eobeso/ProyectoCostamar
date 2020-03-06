using Datos;
using Entidad;

namespace Problema_2
{
    public class ServicioConsultaVuelos : IServicioConsultaVuelos
    {
        public ListaVuelos BusquedaListaVuelos(int CantidadEscalas, bool Equipaje, double Precio)
        {
            ListaVuelos lista = new ListaVuelos();
            Base objBase;
            objBase = new Base();
            lista = objBase.BusquedaListaVuelos(CantidadEscalas, Equipaje, Precio);
            return lista;
        }
    }
}
