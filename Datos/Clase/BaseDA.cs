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
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Dos, Equipaje = true, Precio = 150 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Argentina, CodPaisOrigen = (int)Paises.Peru, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Tres, Equipaje = false, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Colombia, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Cuatro, Equipaje = false, Precio = 150 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Venezuela, CodPaisOrigen = (int)Paises.Colombia, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Una, Equipaje = false, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Tres, Equipaje = false, Precio = 150 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Colombia, CodPaisOrigen = (int)Paises.Peru, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Una, Equipaje = false, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Chile, CodPaisOrigen = (int)Paises.Colombia, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Dos, Equipaje = true, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Colombia, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Una, Equipaje = true, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Venezuela, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Cuatro, Equipaje = true, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Venezuela, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Cuatro, Equipaje = true, Precio = 150 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Argentina, CodPaisOrigen = (int)Paises.Venezuela, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Dos, Equipaje = false, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Argentina, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Tres, Equipaje = true, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Venezuela, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Una, Equipaje = false, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Argentina, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Cuatro, Equipaje = true, Precio = 150 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Argentina, CodPaisOrigen = (int)Paises.Chile, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Tres, Equipaje = true, Precio = 120 });
            VariablesPublicas.ListaVuelos.Add(new Vuelos { CodPaisDestino = (int)Paises.Peru, CodPaisOrigen = (int)Paises.Colombia, FechaSalida = DateTime.Now.AddDays(-1), FechaRetorno = DateTime.Now.AddDays(+15), CantEscalas = (int)Escalas.Una, Equipaje = false, Precio = 150 });
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
