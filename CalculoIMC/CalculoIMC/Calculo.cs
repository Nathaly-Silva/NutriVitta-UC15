namespace CalculoIMC
{
    public static class Calculo
    {
        public static double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public static string ClassificarIMC(double IMC)
        {
            var Classificacao =  "";

            if (IMC < 18.5)
            {
                Classificacao = "Abaixo de 18.5 - Abaixo do peso ";
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                Classificacao = "Entre 18.5 e 24.9 - Peso Normal";
            }
            else if (IMC >= 25.0 && IMC <= 29.9)
            {
                Classificacao = "Entre 25 e 29.9 - Sobrepeso";
            }
            else if (IMC >= 30.0 && IMC <= 34.9)
            {
                Classificacao = "Entre 30 e 34.9 - Obesidade Grau I";
            }
            else if (IMC >= 35.0 && IMC <= 39.9)
            {
                Classificacao = "Entre 35 e 39.9 - Obesidade Grau II";
            }
            else
            {
                Classificacao = "Acima de 40 - Obesidade Grau III";
            }

            return Classificacao;
        }
    }
}