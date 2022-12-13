using Microsoft.AspNetCore.Mvc.Testing;
using Moq;
using Newtonsoft.Json;
using ProductAPI.Controllers;
using ProductAPI.Data.Model;
using ProductAPI.Repositories.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Net;
using System.Net.Http;
using Xunit;
using System.Linq;

namespace ProjectAPI.Test
{    
    public class ProductControllerTest
    {
        private readonly IProductService _productService;

        public ProductControllerTest(IProductService productService)
        {
            _productService = productService;
          

        }

        [Fact]
        public async Task GetAll()
        {
            // Arrange
            const int expected = 3;

            // Act
            var response = await _productService.GetAll();

            // Assert
            Assert.Equal(expected, response.Count());            
        }

        [Fact]
        public async Task Add()
        {
            // Arrange 
            var product = new Product()
            {
                Name = "Cards",
                Desciption = "Greeting Cards.",
                Price = 12.00M
            };

            // Act
            var productDetails = await _productService.Add(product);
            var productName = productDetails.Split(":")[1];
           
            
            // Assert
            Assert.Equal(product.Name, productName);

        }

        [Fact]
        public async Task Update()
        {
            // Arrange 
            var product = new Product()
            {
                Id = 3,
                Name = "Bottles",
                Desciption = "1Ltr plastic bottle with metallic coating.",
                Price = 150.00M
            };

            // Act 
            var productDetails = await _productService.Update(product);
            var productId = Convert.ToInt32(productDetails.Split(":")[1]);

            // Assert
            Assert.Equal(product.Id, productId);

        }

        [Fact]
        public async Task Delete()
        {
            // Arrange
            var id = 2;

            // Act
            var response = await _productService.Delete(id);
            var productId = Convert.ToInt32(response.Split(":")[1]);

            // Assert
            Assert.Equal(id, productId);

        }

    }
}
