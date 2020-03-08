using System;
using System.Linq;
using Entidad;
using Comun;

namespace Datos
{
    public class BaseDA
    {
        public void Base ()
        {
            if (VariablesPublicas.ListaVuelos.ToList().Count() > 0)
            {
                VariablesPublicas.ListaVuelos.Clear();
            }
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Chile, FechaSalida = Convert.ToDateTime("2019-02-10") ,FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Dos, Equipaje = true, Precio = 150,Clase = "A",Aerolinea ="PERUVIAM" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Argentina, CodPaisOrigen = (int)Paises.Peru, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Tres, Equipaje = false, Precio = 120, Clase = "A", Aerolinea = "LATAN" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Colombia, CodPaisOrigen = (int)Paises.Chile, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Cuatro, Equipaje = false, Precio = 150, Clase = "A", Aerolinea = "LATAN" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Venezuela, CodPaisOrigen = (int)Paises.Colombia, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Una, Equipaje = false, Precio = 120, Clase = "B", Aerolinea = "PERUVIAM" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Chile, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Tres, Equipaje = false, Precio = 150, Clase = "B", Aerolinea = "LATAN" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Colombia, CodPaisOrigen = (int)Paises.Peru, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Una, Equipaje = false, Precio = 120, Clase = "B", Aerolinea = "PERUVIAM" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Chile, CodPaisOrigen = (int)Paises.Colombia, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Dos, Equipaje = true, Precio = 120 , Clase = "B", Aerolinea = "LATAN" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Colombia, CodPaisOrigen = (int)Paises.Chile, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Una, Equipaje = true, Precio = 120 , Clase = "B", Aerolinea = "PERUVIAM" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Venezuela, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Cuatro, Equipaje = true, Precio = 120 , Clase = "A", Aerolinea = "LATAN" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Venezuela, CodPaisOrigen = (int)Paises.Chile, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Cuatro, Equipaje = true, Precio = 150 , Clase = "A", Aerolinea = "PERUVIAM" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Argentina, CodPaisOrigen = (int)Paises.Venezuela, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Dos, Equipaje = false, Precio = 120 , Clase = "C", Aerolinea = "PERUVIAM" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Argentina, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Tres, Equipaje = true, Precio = 120 , Clase = "C", Aerolinea = "PERUVIAM" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Venezuela, CodPaisOrigen = (int)Paises.Chile, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Una, Equipaje = false, Precio = 120 , Clase = "C", Aerolinea = "PERUVIAM" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Argentina, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Cuatro, Equipaje = true, Precio = 150 , Clase = "C", Aerolinea = "PERUVIAM" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Argentina, CodPaisOrigen = (int)Paises.Chile, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Tres, Equipaje = true, Precio = 120 , Clase = "C", Aerolinea = "PERUVIAM" });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Colombia, FechaSalida = Convert.ToDateTime("2019-02-10"), FechaRetorno = Convert.ToDateTime("2019-04-10"), CantEscalas = (int)Escalas.Una, Equipaje = false, Precio = 150 , Clase = "C", Aerolinea = "LATAN" });
            if (VariablesPublicas.ListaPais.ToList().Count() > 0)
            {
                VariablesPublicas.ListaPais.Clear();
            }
            VariablesPublicas.ListaPais.Add(new Pais { CodPais = (int)Paises.Peru, Descripcion = "Peru" });
            VariablesPublicas.ListaPais.Add(new Pais { CodPais = (int)Paises.Chile, Descripcion = "Chile" });
            VariablesPublicas.ListaPais.Add(new Pais { CodPais = (int)Paises.Argentina, Descripcion = "Argentina" });
            VariablesPublicas.ListaPais.Add(new Pais { CodPais = (int)Paises.Venezuela, Descripcion = "Venezuela" });
            VariablesPublicas.ListaPais.Add(new Pais { CodPais = (int)Paises.Colombia, Descripcion = "Colombia" });
        }
        

    }
}
