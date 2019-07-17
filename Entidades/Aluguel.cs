using System;

namespace LocadoraCarros.Entidades
{
    public class Aluguel
    {
        public Aluguel(DateTime horaInicial, DateTime horaFinal)
        {
            this.HoraInicial = horaInicial;
            this.HoraFinal = horaFinal;
        }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }


    }
}