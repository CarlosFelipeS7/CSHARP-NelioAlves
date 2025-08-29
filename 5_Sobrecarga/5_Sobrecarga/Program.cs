using _5_Sobrecarga;
using System;
using System.Globalization;
namespace _5_Sobrecarga
{
    class Program
    {
       //Sobrecarga é um recurso que uma classe possui de oferecer mais de uma operacao com o mesmo nome
       //porem com listas diferentes de parametros


        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 1000, 10);
            Console.WriteLine(p);

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            p.AdicionarProduto(quantidade);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            p.RemoverProduto(quantidade);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}