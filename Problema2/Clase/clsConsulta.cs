using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Problema2
{
    public class clsConsulta
    {       
        IFirebaseClient client;
        #region Metodos
        private void imprimir(EVuelo recorre)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Origen :" + recorre.Origen);
            Console.WriteLine("Destino : " + recorre.Destino);
            Console.WriteLine("Equipaje : " + recorre.Equipaje.Replace("True", "Si").Replace("False", "No"));
            Console.WriteLine("Escalas : " + recorre.Escalas);
            Console.WriteLine("Fecha Salida : " + recorre.FechaSalida);
            Console.WriteLine("Fecha Retorno : " + recorre.FechaRetorno);
            Console.WriteLine("Precio : " + recorre.Precio);
        }
        #endregion
        #region Tarea Asincrona
        public async Task  Consulta(string Cadena)
        {
            //API Firebase - Ini
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = ConfigurationManager.AppSettings["AuthSecret"].ToString(),
                BasePath = ConfigurationManager.AppSettings["BasePath"].ToString()
            };
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = await client.GetTaskAsync("Vuelos");
            List<EVuelo> obj = response.ResultAs<List<EVuelo>>();
            //API Firebase - Fin

            string[] arreglo = Cadena.Split(',');

            if (arreglo.Length != 3)
            {
                Console.WriteLine("Se deben ingresar solo 3 parametros.");
                return;
            }

            string Escala, Equipaje, Precio;
            Escala = Convert.ToString(arreglo[0]);
            Equipaje = Convert.ToString(arreglo[1]);
            Precio = Convert.ToString(arreglo[2]);

            if (obj.ToList().Count > 0)
            {
                obj.RemoveAt(0);
                List<EVuelo> filtro = (from q in obj where q.Escalas == Escala && q.Equipaje== Equipaje && q.Precio== Precio select q).ToList();
                if (filtro.ToList().Count > 0)
                {
                    foreach (var recorre in filtro)
                    {
                        imprimir(recorre);
                    }
                }
                else
                {
                    Console.WriteLine("No existe información para los filtros de cantidad de escalas.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("No existe información en la base de datos.");
                return;
            }
        }

        #endregion
    }
}
