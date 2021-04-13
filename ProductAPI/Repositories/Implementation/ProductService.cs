using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;
using ProductAPI.Data.Model;
using ProductAPI.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Repositories.Implementation
{
    public class ProductService : IProductService
    {
        protected ProductDbContext _context;

        public ProductService(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<string> Add(Product product)
        {
            try
            {
                await _context.AddAsync(product);
                await _context.SaveChangesAsync();

                return $"Product added successfully";
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<string> Delete(int id)
        {
            try
            {
                var product = await _context.Products.FindAsync(id);
                _context.Remove(product);
                await _context.SaveChangesAsync();

                return $"Product deleted successfully";
            }
            catch (Exception)
            {
                return null;
            }

        }

        public async Task<List<Product>> GetAll()
        {
            try
            {
                return await _context.Products.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Product> GetById(int id)
        {
            try
            {
                return await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<string> Update(Product product)
        {
            try
            {
                var updateProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == product.Id);
               
                _context.Entry(updateProduct).CurrentValues.SetValues(product);

                await _context.SaveChangesAsync();

                return $"Product updated successfully";
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
