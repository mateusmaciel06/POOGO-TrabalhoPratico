using System;
using System.Collections.Generic;
namespace GestaoAtivos.core
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ativo> Inventario = new List<Ativo>();
            bool aExecutar = true;
            while (aExecutar)
{
                Console.Clear();








            }
            // Adicionando ativos
            inventario.Add(new Ativo("Computador", "Eletrônicos", 3000.00m, 5, "Ativo"));
            ativos.Add(new Ativo("Mesa", "Móveis", 500.00m, 10, "Ativo"));
            ativos.Add(new Ativo("Carro", "Veículos", 20000.00m, 8, "Ativo"));

            // Exibindo detalhes dos ativos
            foreach (var ativo in ativos)
            {
                ativo.ExibirDetalhes();
                Console.WriteLine($"Amortização Anual: {ativo.CalcularAmortizacaoAnual():C}");
                Console.WriteLine();
            }
        }
    }
}