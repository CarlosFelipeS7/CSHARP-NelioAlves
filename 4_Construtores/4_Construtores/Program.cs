using _4_Construtores;
using System;
using System.Globalization;
namespace _4_Construtores
{
    class Program
    {
        //Construtor é uma operacao especial da calsse, que executa no momento da INSTANCIACAO DO OBJETO (Produto p = new Produto();

        //Usos comuns: Iniciar valores dos atributos, permitir ou obrigar que o objeto recebe dados

        //É possivel especificar mais de um construtor na mesma calsse (sobrecarga)


        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 1000, 10);//Por padrao quando o objeto é instanciado assim os campos nome, preco e quantidade estao nulos
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