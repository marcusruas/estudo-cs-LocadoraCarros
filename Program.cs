using System;
using System.Globalization;
using LocadoraCarros.Entidades;
using LocadoraCarros.Servicos;

namespace LocadoraCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nova Nota: ");

            System.Console.Write("Modelo de Carro: ");
            string model = Console.ReadLine();
            System.Console.Write("Hora Inicial  (dd:MM:yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            System.Console.Write("Hora Final  (dd:MM:yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        
            System.Console.Write("Digite o Preço por Hora: R$");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Digite o Preço por Dia: R$");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Carro carro = new Carro(model);
            Aluguel aluguel = new Aluguel(start, finish);
            Nota nota = new Nota(carro, aluguel);

            AluguelService servico = new AluguelService(pricePerHour, pricePerDay, new BrasilTaxService());
            servico.ProcessarNota(nota);
            Console.WriteLine(nota.ToString());
        }
    }
}
