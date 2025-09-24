using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _28_StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"B:\file1.txt";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //instanciando objeto filestream
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);

            }
            catch (IOException e)
            {
                Console.WriteLine("ERRO! " + e.Message);
            }
            finally
            {   //fechando streams
                if (sr != null) {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
                }
        }
    }
}
