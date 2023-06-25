using System;
using System.Globalization;
using System.Xml;

namespace Exercicios004
{
    class Program
    {
        static void Main(String[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produtos: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int howMuch = int.Parse(Console.ReadLine());
            p.AdicianarProdutos(howMuch);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de pordutos a ser romovido do estoque: ");
            int romovido = int.Parse(Console.ReadLine());
            p.RemoverProdutos(romovido);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}