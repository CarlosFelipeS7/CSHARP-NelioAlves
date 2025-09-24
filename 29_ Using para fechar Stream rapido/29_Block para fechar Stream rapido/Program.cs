using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _29_Block_para_fechar_Stream_rapido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"B:\file1.txt";

            //Usando o using, assim que o bloco de codigo acaba e fechado automaticamente
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {

            }    
        }
    }
}
