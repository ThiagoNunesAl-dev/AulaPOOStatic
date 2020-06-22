namespace AulaPOOStatic
{
    public static class Conversor
    {
        //É preciso usar "static" porque classes estáticas não podem ser instanciadas da forma convecional.
        public static float CotacaoDolar = 5.23f;

        public static float CotacaoEuro = 5.89f;
        
        //É preciso usar "static" nos métodos também, dado que métodos estáticos não podem ser criados da forma convencional.
        public static string ConverterRealDolar (float valorRS) {
            return $"R$ {valorRS} em dólares: US$ {valorRS / CotacaoDolar}.";
        }

        public static string ConverterDolarReal (float valorDOL) {
            return $"US$ {valorDOL} em reais: R$ {valorDOL * CotacaoDolar}.";
        }

        public static string ConverterRealEuro (float valorRS) {
            return $"R$ {valorRS} em euros: {valorRS / CotacaoEuro} euros.";
        }

        public static string ConverterEuroReal (float valorEUR) {
            return $"{valorEUR} euros em reais: R$ {valorEUR * CotacaoEuro}.";
        }


    }
}