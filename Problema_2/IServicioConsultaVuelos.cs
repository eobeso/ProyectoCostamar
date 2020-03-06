using Entidad;
using System.ServiceModel;

namespace Problema_2
{
    [ServiceContract]
    public interface IServicioConsultaVuelos
    {
        [OperationContract]
        ListaVuelos BusquedaListaVuelos(int vCantidadEscalas, bool vEquipaje, double vPrecio);
    }
}
