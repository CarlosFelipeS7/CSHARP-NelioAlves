using Exercicio_Enum_e_Composicao.Entities.Enums;
using System.Collections.Generic;

namespace Exercicio_Enum_e_Composicao
{
     class Worker
    {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }//Enum
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } //Composicao

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();//Criando lista de contratos (por ter varios contratos), para usar como metodo

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament) //nao inlcuir associacoes para N(muitos) no caso os contratos
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }
    
        public void addContract(HourContract contract)//contract é o parametro
        {
            Contracts.Add(contract);//Adicionar parametro na lista Contracts
        }

        public void removeContract(HourContract contract)//removendo
        {
            Contracts.Remove(contract);//removendo parametro da lista Contracts
        }
    
        public double Income(int year, int month) //funcao pra retornar lucro
        {

            double sum = BaseSalary; //variavel soma recebe BaseSalary

            foreach (HourContract contract in Contracts){  // uso a variavel contract do tipo HourContract para percorrer a lista Contracts   
                if (contract.Date.Year== year && contract.Date.Month == month) //se o Year da lista for igual year do metodo e o month:
                {
                    sum += contract.TotalValue(); //soma o contrato igual ao salario base
                }
            }

            return sum;
            
        }

  
    }
}
