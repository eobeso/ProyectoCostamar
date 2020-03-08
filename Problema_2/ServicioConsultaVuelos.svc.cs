using Negocio;
using Entidad;
using System;
using System.Collections.Generic;

namespace Problema_2
{
    public class ServicioConsultaVuelos : IServicioConsultaVuelos
    {
        public List<ResponseVuelos> BusquedaListaVuelos(RequestVuelos oRequestVuelos)
        {
            List<ResponseVuelos> oResponseVuelos = new List<ResponseVuelos>();            
            BaseBL oBaseBL = new BaseBL();
            oBaseBL.Base();
            oResponseVuelos = oBaseBL.BusquedaListaVuelos(oRequestVuelos);
            return oResponseVuelos;
        }
    }
}
