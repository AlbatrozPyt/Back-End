using System.Globalization;

namespace Conversao_De_Moedas
{
    public static class ConversorMoedas
    {

        // Metodos
        public static string RealToDolar(float real) {
            float res = real * 0.20f;

            return res.ToString("C", new CultureInfo("en-US"));
        }

        public static string DolarToReal(float dolar) {
            float res = dolar * 4.99f;

            return res.ToString("C", new CultureInfo("pt-BR"));
        }
    }
}