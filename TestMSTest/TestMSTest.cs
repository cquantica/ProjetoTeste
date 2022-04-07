using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTeste;

namespace TestMSTest
{
    [TestClass]
    public class TestMSTest
    {
        [TestMethod]
        public void SomarDoisNumeros()
            {
                //arrange - Organizar
                double pNum = 1;
                double sNum = 1;

                //Act - Agir
                var resultado = Operacoes.Somar(pNum, sNum);

                //Assert - Verificar
                Assert.AreEqual(2, resultado);
            }

            [DataTestMethod]
            [DataRow(1, 1, 2)]
            [DataRow(1, 1, 3)]
            [DataRow(1, 2, 3)]

            public void SomarDoisNumerosLista(double pNum, double sNum, double tNum)
            {
                var resultado = Operacoes.Somar(pNum, sNum);

                Assert.AreEqual(tNum, resultado);
            }
    }
}
