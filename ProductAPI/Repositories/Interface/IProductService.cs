using ProductAPI.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Repositories.Interface
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<string> Add(Product product);
        Task<string> Update(Product product);
        Task<string> Delete(int id);
    }   
}
