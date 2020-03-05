using System;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problema 2");
            Console.WriteLine("Solo Ingreso 3 parametros.");
            Console.WriteLine("Parametros:");
            Console.WriteLine("1: Filtro por cantidad de escalas. (1 ó 2 ó 3)");
            Console.WriteLine("2: Filtro si incluye equipaje. (True ó False)");
            Console.WriteLine("3: Filtro por precios. (120 ó 130 ó 150)");
            try
            {
                clsConsulta obj = new clsConsulta();
                string s = Console.ReadLine();
                Task t = MainAsync(args,s);
                t.Wait();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
        static async Task MainAsync(string[] args,string s)
        {
            clsConsulta obj = new clsConsulta();
            await obj.Consulta(s);
        }

    }
}
