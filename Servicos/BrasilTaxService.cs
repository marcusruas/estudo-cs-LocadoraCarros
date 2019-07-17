namespace LocadoraCarros.Servicos
{
    public class BrasilTaxService : ITaxService
    {
        public double Tax(double valor)
        {
            if(valor <= 100){
                return valor * 0.2;
            }else{
                return valor * 0.15;
            }
        }
    }
}