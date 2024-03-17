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

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Sellers
                     .OrderBy(s => s.Id)
                     .ToListAsync();
        }

        public async Task InsertAsync(Seller seller)
        {
            _context.Add(seller);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Sellers
                    .Include(s => s.Departament)
                    .FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = _context.Sellers.Find(id);
                _context.Sellers.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {

                throw new IntegrityException(e.Message);
            }

        }

        public async Task UpdateAsync(Seller seller)
        {
            var hasAsync = await _context.Sellers.AnyAsync(s => s.Id == seller.Id);
            if (!hasAsync)
            {
                throw new NotFoundException("Id not found!");
            }

            try
            {
                _context.Update(seller);
                await _context.SaveChangesAsync();

            }catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException("Erro:" + e.Message);
            }
            
        }

    }
}
