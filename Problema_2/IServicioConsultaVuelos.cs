using Entidad;
using System.Collections.Generic;
using System.ServiceModel;

namespace Problema_2
{
    [ServiceContract]
    public interface IServicioConsultaVuelos
    {
        [OperationContract]
        List<ResponseVuelos> BusquedaListaVuelos(RequestVuelos oRequestVuelos);
    }
}
