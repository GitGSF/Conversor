namespace Conversor
{
    public class Conversor
    {

        //Dólar(US)
        private static float CotacaoDolar = 5.25f;

        public static float RealParaDolar(float valorRS){
            return valorRS / CotacaoDolar ;

        }
        public static float DolarParaReais(float valorUS){
            return CotacaoDolar * valorUS ;
        }

        
        //Euro(EUR)
        private static float CotacaoEuro = 5.92f;

        public static float RealParaEuro(float valorRS){
            return valorRS / CotacaoEuro ;

        }
        public static float EuroParaReais(float valorEUS){
            return CotacaoEuro * valorEUS ;

        }
    }
}