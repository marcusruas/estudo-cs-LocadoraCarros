namespace LocadoraCarros.Entidades
{
    public class Nota
    {
        public Nota(Carro carro, Aluguel aluguel)
        {
            this.carro = carro;
            this.aluguel = aluguel;
        }
        public Carro carro { get; set; }
        public Aluguel aluguel { get; set; }
        public double ValorInicial { get; set; }
        public double Imposto { get; set; }
        public double ValorFinal { get; set; }

        public override string ToString()
        {
            return "Nota Gerada"
            + "\nModelo do Carro Alugado: " + carro.Modelo
            + "\nValor do Aluguel: R$"+this.ValorInicial.ToString("F2")
            + "\nImposto sobre Nota: R$"+this.Imposto.ToString("F2")
            + "\nValor final da Nota: R$"+this.ValorFinal.ToString("F2");

        }
    }
}