using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Services.Exception;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Sellers
                     .OrderBy(s => s.Id)
                     .ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Sellers
                    .Include(s => s.Departament)
                    .FirstOrDefault(s => s.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Sellers.Find(id);
            _context.Sellers.Remove(obj);
            _context.SaveChanges();

        }

        public void Update(Seller seller)
        {

            if(!_context.Sellers.Any(s => s.Id == seller.Id))
            {
                throw new NotFoundException("Id not found!");
            }

            try
            {
                _context.Update(seller);
                _context.SaveChanges();

            }catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException("Erro:" + e.Message);
            }
            
        }

    }
}
