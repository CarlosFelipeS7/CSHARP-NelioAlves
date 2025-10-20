using System.Collections.Generic;
using System;
using System.Linq;
namespace SalesWebMVC.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Implementando associacao do departamento com seller
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Departament()
        {

        }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }
   
        public void AddSeller (Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            //para cada seller na lista, chamo o total sales e somo todos os vendedores do departamento
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    
    
    }


}
