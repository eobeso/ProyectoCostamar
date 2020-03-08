using Comun;
using Datos;
using Entidad;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class BaseBL
    {        
        public void Base()
        {
            BaseDA obj = new BaseDA();
            obj.Base();
        }

        public string BuscaPais(int vCodPais)
        {
            string pais=string.Empty;
            foreach (var item in VariablesPublicas.ListaPais)
            {
                if (vCodPais == item.CodPais)
                {
                    pais = item.Descripcion;
                }
            }
            return pais;
        }

        public string Escala(int vEscala)
        {
            if (vEscala > 0)
            {
                return "Escala";
            }
            else {
                return "Directos";
            }
        }

        public List<ResponseVuelos> BusquedaListaVuelos(RequestVuelos oRequestVuelos)
        {
            List<ResponseVuelos> oResponseVuelos = new List<ResponseVuelos>();
            ListaVuelos oListaVuelos = new ListaVuelos();
            oListaVuelos = new ListaVuelosDA().BusquedaListaVuelos(oRequestVuelos);
            foreach (Vuelos oVuelos in oListaVuelos)
            {
                string PaisOrigen = BuscaPais(oVuelos.CodPaisOrigen);
                string PaisDestino = BuscaPais(oVuelos.CodPaisDestino);
                string Escalas = Escala(oVuelos.CantEscalas);
                string Equipaje = (oVuelos.Equipaje == true) ? "SI" : "NO";
                oResponseVuelos.Add(new ResponseVuelos { PaisOrigen = PaisOrigen, PaisDestino = PaisDestino, Escalas = Escalas, Equipaje = Equipaje, FechaSalida = oVuelos.FechaSalida, FechaRetorno = oVuelos.FechaRetorno, Precio = oVuelos.Precio });
            }
            return oResponseVuelos;
        }
    }
}
