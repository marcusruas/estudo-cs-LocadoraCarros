using System;
using LocadoraCarros.Entidades;

namespace LocadoraCarros.Servicos
{
    public class AluguelService
    {
        ITaxService _servico;
        public AluguelService(double precoHora, double precoDia, ITaxService servico)
        {
            this.PrecoHora = precoHora;
            this.PrecoDia = precoDia;
            this._servico = servico;
        }
        public double PrecoHora { get; set; }
        public double PrecoDia { get; set; }
        public void ProcessarNota(Nota nota)
        {
            TimeSpan duracao = nota.aluguel.HoraFinal - nota.aluguel.HoraInicial;
            

            if(duracao.TotalHours <= 12){
                nota.ValorInicial = PrecoHora * Math.Ceiling(duracao.TotalHours);
            }else{
                nota.ValorInicial = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }
            

            nota.Imposto = _servico.Tax(nota.ValorInicial);
            nota.ValorFinal = nota.ValorInicial + nota.Imposto;

        }
    }
}