using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _27_Manipulando_Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //caminho ate o arquivo
            string sourcePath = @"B:\file1.txt";
            string targetPath = @"B:\file2.txt";


            try
             {  //criando um arquivo 
                FileInfo fileInfo = new FileInfo(sourcePath);
                
                //copiando o arquivo 1
                fileInfo.CopyTo(targetPath);

                //ler todas linhas do arquivo e armazenar no vetor
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro ocorrido");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Fim");
            }



        }
    }
}
