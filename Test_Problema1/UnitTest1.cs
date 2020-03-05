using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problema1;

namespace Test_Problema
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string Cadena = "aatt";
            string ResultadoEsperado = "2a2t";
            string Resultado = "";
            clsCadenasRepertidas oclsCadenasRepertidas = new clsCadenasRepertidas();
            Resultado = oclsCadenasRepertidas.build(Cadena);
            Assert.AreEqual(ResultadoEsperado, Resultado);
        }
    }
}
