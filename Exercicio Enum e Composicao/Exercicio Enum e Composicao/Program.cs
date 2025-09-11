using System;
using Exercicio_Enum_e_Composicao.Entities;
using Exercicio_Enum_e_Composicao.Entities.Enums;

namespace Exercicio_Enum_e_Composicao
{
    internal class Program
    //Ler os dados de um trabalhador com N contratos(fornecidos p user)
    //Depois solicitar do usuario um mes
    //e mostrar o salario do funcionario nesse mes

    {
        static void Main(string[] args)
        {
            //Entradsa: Departamento, Data Work, Nome, Nivel(jr, senior),
            //salario base, qtd contratos

            //1 Contrato, data, valor p hr, duracao(horas)
            //2 Contrato, data, valor p hr, duracao(horas)
            //3 Contrato, data, valor p hr, duracao(horas)

            //Apos tudo isso, entrar com mes e ano para calcular os ganhos desse mes e ano

            Console.WriteLine("Enter Departament's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter work data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Departament dept = new Departament(deptName); //instanciado com o valor informado pelo user
            Worker worker = new Worker(name, level, baseSalary, dept);//instanciado com o valor informado pelo user

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i =1; i<=n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Date (DD//MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                //instanciando com as variaveis informadas para o construtor
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.addContract(contract); //adicionando o contrato ao trabalhador


            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month =int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for:  " + monthAndYear + ": " + worker.Income(year,month));

        }
    }
}
