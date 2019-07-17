namespace LocadoraCarros.Entidades
{
    public class Carro
    {

        public Carro(string modelo)
        {
            this.Modelo = modelo;
        }
        public string Modelo { get; set; }
    }
}