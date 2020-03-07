using Negocio;
using Entidad;

namespace Problema_2
{
    public class ServicioConsultaVuelos : IServicioConsultaVuelos
    {
        public ListaVuelos BusquedaListaVuelos(int CantidadEscalas, bool Equipaje, double Precio)
        {
            ListaVuelos oListaVuelos = new ListaVuelos();
            BaseBL oBaseBL = new BaseBL();
            oBaseBL.Base();
            oListaVuelos = oBaseBL.BusquedaListaVuelos(CantidadEscalas, Equipaje, Precio);
            return oListaVuelos;
        }
    }
}
