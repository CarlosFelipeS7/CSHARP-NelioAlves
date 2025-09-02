using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Variaveis cujo tipo sao classes, nao devem ser entendidas como caixas
//Mas sim tentaculos(ponteiros) para caixas


//Classes sao tipo referencia
//Exemplo: Product p1 = new Product(!!!!)
//p2=p1, p2 passa a apontar para onde p1 aponta (mesma caixa)


//Structs sao tipos valor: caixas e nao ponteiros.
//Exemplo de Struct: double x=10; y=x;, y recebe uma copia do valor, (crie outra caixa)

namespace _11_Tipos_Referencia_e_Valor
{
    internal class Program
    {
      

        static void Main(string[] args)
        {
            //Nao precisa instanciar assim por ser struct Point point = new Point();

            //Somente de fazer isso, ja cria as "caixinhas na memoria"
            Point point;

            //Acessando as caixinhas
            point.X = 10;
            point.Y = 20;

            //Mostrando a primeira caixinha
            Console.WriteLine(point);

            //Criando a segunda caixinha
            point = new Point();

            //Mostrando a segunda
            Console.WriteLine(point);

        }
    }
}
