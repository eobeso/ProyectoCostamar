using Comun;
using Datos;
using Entidad;

namespace Negocio
{
    public class BaseBL
    {        
        public void Base()
        {
            BaseDA obj = new BaseDA();
            obj.Base();
        }
        public ListaVuelos BusquedaListaVuelos(int vCantidadEscalas, bool vEquipaje, double vPrecio)
        {            
            ListaVuelos oListaVuelos = new ListaVuelos();
            oListaVuelos = new ListaVuelosDA().BusquedaListaVuelos(vCantidadEscalas, vEquipaje, vPrecio);
            var obj = (from q in oListaVuelos where q
            return new ListaVuelosDA().BusquedaListaVuelos(vCantidadEscalas, vEquipaje, vPrecio);

            var JoinUsingQS = (from emp in Employee.GetAllEmployees()
                               join address in Address.GetAllAddresses()
                               on emp.AddressId equals address.ID
                               select new
                               {
                                   EmployeeName = emp.Name,
                                   AddressLine = address.AddressLine
                               }).ToList();



            ListaVuelos.AddRange((from q in VariablesPublicas.ListaVuelos
                                  where q.CantEscalas == vCantidadEscalas && q.Equipaje == vEquipaje && q.Precio == vPrecio
                                  select q).ToList());
            from t1 in db.Table1
            join t2 in db.Table2 on t1.field equals t2.field
            select new { t1.field2, t2.field3 }
        }
    }
}
