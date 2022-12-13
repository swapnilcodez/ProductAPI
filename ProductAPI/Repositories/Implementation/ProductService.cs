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
    /// <summary>
    /// ProductService Implementation
    /// </summary>
    public class ProductService : IProductService
    {
        /// <summary>
        /// _context
        /// </summary>
        protected ProductDbContext _context;

        /// <summary>
        /// ProductService
        /// </summary>
        /// <param name="context"></param>
        public ProductService(ProductDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<string> Delete(int id)
        {
            try
            {
                var product = await _context.Products.FindAsync(id);
                if (product != null)
                {
                    _context.Remove(product);
                    await _context.SaveChangesAsync();
                    return $"Product deleted successfully";
                }
                return $"Product Not Found";
            }
            catch (Exception)
            {
                return null;
            }

        }

        /// <summary>
        /// GetAll
        /// </summary>
        /// <returns></returns>
        public async Task<List<Product>> GetAll()
        {
            try
            {
                var products = await _context.Products.ToListAsync();
                if (products != null)
                    return products;

                return new List<Product>();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// GetById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Product> GetById(int id)
        {
            try
            {
                var product = await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
                if (product != null)
                    return product;

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<string> Update(Product product)
        {
            try
            {
                var updateProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == product.Id);

                if (updateProduct != null)
                {
                    _context.Entry(updateProduct).CurrentValues.SetValues(product);
                    await _context.SaveChangesAsync();

                    return $"Product updated successfully";
                }
                return $"Product Not found";
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
