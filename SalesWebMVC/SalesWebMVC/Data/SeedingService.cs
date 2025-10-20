using System;
using System.Linq;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private readonly SalesWebMVCContext _context;

        // injeção de dependência
        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }
        
        // Popular a base de dados
        public void Seed() 
        { 
            if (_context.Departament.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            var d1 = new Departament { Name = "Computers" };
            var d2 = new Departament { Name = "Electronics" };
            var d3 = new Departament { Name = "Fashion" };

            var s1 = new Seller { Name = "Bob Brown", Email = "bob@gmail.com", BirthDate = new DateTime(1998,4,21), BaseSalary = 1000.0, Departament = d1 };
            var s2 = new Seller { Name = "John Red", Email = "john@gmail.com", BirthDate = new DateTime(2000,11,18), BaseSalary = 2000.0, Departament = d2 };
            var s3 = new Seller { Name = "Peter Green", Email = "peterg@gmail.com", BirthDate = new DateTime(1989,3,20), BaseSalary = 5000.0, Departament = d3 };

            var r1 = new SalesRecord { Date = new DateTime(2018,9,25), Amount = 11000, Status = SaleStatus.Billed, Seller = s1 };
            var r2 = new SalesRecord { Date = new DateTime(2016,8,23), Amount = 66000, Status = SaleStatus.Billed, Seller = s3 };
            var r3 = new SalesRecord { Date = new DateTime(2017,10,21), Amount = 55000, Status = SaleStatus.Billed, Seller = s2 };

            _context.Departament.AddRange(d1, d2, d3);
            _context.Seller.AddRange(s1, s2, s3);
            _context.SalesRecord.AddRange(r1, r2, r3);

            _context.SaveChanges();
        }   
    }
}
