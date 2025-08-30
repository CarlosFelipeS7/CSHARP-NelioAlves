using _8_Encapsulamento;
using _8_Encapsulamento;
using System;
using System.Globalization;
namespace _8_Encapsulamento
{
    class Program
    {
        
        //Encapsulamento esconde detalhes da implementacao de um componente, expondo apenas operacoes seguras

        //Ex: Radio, usuario aumenta volume, diminui, mas nao interage direto na placa mae

        //Get: Obter o valor de um atributo;
        //Set:Definir/Alterar o valor de um atributo;

        static void Main(string[] args)
        {
            Produto p = new Produto("Tv", 500, 10);

            Console.WriteLine(p.nome); //da certo pq nome é public
            
            //Usa o get para exibir atributo private da classe (basicamente cria um metodo la pra isso)
            Console.WriteLine(p.GetQuantidade());

            //Usando set para alterar atributo private 
            p.SetQuantidade(30);
            Console.WriteLine(p.GetQuantidade());

        }
    }
}