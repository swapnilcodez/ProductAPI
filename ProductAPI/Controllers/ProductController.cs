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
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productService.GetAll();
            if(response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Product product)
        {
            if(product == null)
            {
                return BadRequest("Request body is empty");
            }
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(product.Id != 0)
            {
                return BadRequest($"Product id must be zero.");
            }

            var response = await _productService.Add(product);
            if(response == null)
            {
                return BadRequest("Oops! something went wrong, try again.");
            }

            return Ok(response);
        }

        [HttpPut]
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

            if(productById == null)
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

        [HttpDelete("id")]
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
