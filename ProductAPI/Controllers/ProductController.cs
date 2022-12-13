using Microsoft.AspNetCore.Mvc;
using ProductAPI.Data.Model;
using ProductAPI.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
    /// <summary>
    /// Product API entry point
    /// </summary>
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        /// <summary>
        /// ProductController Constructor
        /// </summary>
        /// <param name="productService"></param>
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Returns the products list
        /// </summary>
        /// <returns>List of Products present</returns>
        [HttpGet(template: nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productService.GetAll();
            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        /// <summary>
        /// Saves product in db.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost(template: nameof(Add))]
        public async Task<IActionResult> Add([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Request body is empty");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (product.Id != 0)
            {
                return BadRequest($"Product id must be zero.");
            }

            var response = await _productService.Add(product);
            if (response == null)
            {
                return BadRequest("Oops! something went wrong, try again.");
            }

            return Ok(response);
        }

        /// <summary>
        /// Update the product in db.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPut(template: nameof(Update))]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest("Request body is empty");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productById = await _productService.GetById(product.Id);

            if (productById == null)
            {
                return BadRequest($"Product with id:{product.Id} not found");
            }

            var response = await _productService.Update(product);
            if (response == null)
            {
                return BadRequest("Oops! something went wrong, try again.");
            }

            return Ok(response);
        }

        /// <summary>
        /// Delete the product of id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete(template: nameof(Delete))]
        public async Task<IActionResult> Delete(int id)
        {
           
            var response = await _productService.Delete(id);
            if(response == null)
            {
                return BadRequest("Oops! something went wrong, try again.");
            }
            return Ok(response);
        }
    }
}
