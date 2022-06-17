using CalculoIMC;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CalcularIMC()
        {
            //Arrange
            double peso = 63.0;
            double altura = 1.68;
            string IMC = "Seu IMC é: 22,3";

            //Act 
            var resultado = Calculo.CalcularIMC(peso, altura).ToString("Seu IMC é: #.#");

            //Assert
            Assert.Equal(IMC, resultado);
        }

        [Fact]
        public void ClassificarIMC()
        {
            //Arrange
            double IMC = 22.3;
            string resultadoImc = "Entre 18.5 e 24.9 - Peso Normal";

            //Act
            var resultado = Calculo.ClassificarIMC(IMC);

            //Assert
            Assert.Equal(resultadoImc, resultado);
        }
    }
}