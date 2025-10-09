using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_Introducao_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ = conjunto de tecnologias baseadas na integracao de funcionalidades de consultas
            //operacoes chamadas a partir de colecoes

            //Para trabalhar deve se seguir 3 passos
            //1 Datasource(colacao,array,etc)
            //2 Query(Consulta)
            //3 Exececao da query(foreach ou alguma operacao)

            //Passo 1 Especificar Datasource, aqui usei vetor, mas pode ser ate banco de dados
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Passo2 Query, eu fiz a query que pega todos os numeros da lista numbers
                        // (where) resultam da expressao lambda x%2 ==0,
                        //ou seja x percorre a lista, e quem tiver resto = 0 é par
                                    //apos isso faco um select para transformar os elementos em * 10 
            var result = numbers.Where(x => x%2 ==0).Select(x => x*10);

            //Passo 3 Executar
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}
