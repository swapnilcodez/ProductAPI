using ProductAPI.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Repositories.Interface
{
    /// <summary>
    /// ProductService interface
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// GetAll
        /// </summary>
        /// <returns></returns>
        Task<List<Product>> GetAll();

        /// <summary>
        /// GetById
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Product> GetById(int id);

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<string> Add(Product product);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        Task<string> Update(Product product);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<string> Delete(int id);
    }   
}
