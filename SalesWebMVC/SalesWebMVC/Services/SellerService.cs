using SalesWebMVC.Data;
using SalesWebMVC.Models;
namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;
        
        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();//acessar a fonte de dados relacionada a tabela de vendedores e converter para uma lista
        }
    }
}
