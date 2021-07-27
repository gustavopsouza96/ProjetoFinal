using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.v2.Data;
using SalesWebMvc.v2.Models;

namespace SalesWebMvc.v2.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcv2Context _context;

        public SellerService(SalesWebMvcv2Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
