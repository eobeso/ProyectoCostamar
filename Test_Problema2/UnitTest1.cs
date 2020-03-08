using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidad;
using Negocio;
using System.Collections.Generic;

namespace Test_Problema2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RequestVuelos oRequestVuelos = new RequestVuelos { Precio = 120, Equipaje = true, CantidadEscalas = 1 };
            List<ResponseVuelos> Resultado = new List<ResponseVuelos>();
            List<ResponseVuelos> ResultadoEsperado = new List<ResponseVuelos>();
            ResultadoEsperado.Add(new ResponseVuelos { Equipaje = "SI", Escalas = "Escala", FechaRetorno = Convert.ToDateTime("2019-04-10"), FechaSalida = Convert.ToDateTime("2019-02-10"), PaisDestino = "Colombia", PaisOrigen = "Chile", Precio = 120 });
            BaseBL oBaseBL = new BaseBL();
            oBaseBL.Base();
            Resultado = oBaseBL.BusquedaListaVuelos(oRequestVuelos);
            Assert.AreEqual(ResultadoEsperado.Count, Resultado.Count);           
        }
    }
}
