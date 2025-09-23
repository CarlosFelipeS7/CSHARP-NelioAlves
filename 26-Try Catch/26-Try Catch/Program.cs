using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {  //Estrutura try-catch

            //Bloco try: Codigo que representa a execucao normal do codigo

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }

            //Bloco catch: Codigo a ser executado caso uma excessao ocorra
            catch(DivideByZeroException e)  //poderia colocar somente exception,
                                            //mas é sempre bom colocar o  mais proximo possivel do erro
            {                               //para personalizar de acordo com os erros

                Console.WriteLine("Error! " + e.Message);
            }
            catch(Exception a)
            {
                Console.WriteLine("Valor nao numerico! " + a.Message);
            }


            //bloco finally: codigo que vai ser executado independe se der erro ou nao
            //exemplo fechar arquivo ou conexao com BD ao final do processamento
            finally
            {
                Console.WriteLine("Fim do codigo");
            }
            

        }
    }
}
