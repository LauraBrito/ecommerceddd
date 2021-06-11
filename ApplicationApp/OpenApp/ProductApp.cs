using ApplicationApp.Interfaces;
using Domain.Interfaces.Products;
using Domain.Interfaces.Services;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class ProductApp : IProductApp
    {
        private readonly IProduct _product;
        private readonly IProductService _productService;

        public ProductApp(IProduct product,
            IProductService productService)
        {
            _product = product;
            _productService = productService;
        }

        public async Task Add(Product product)
        {
            await _product.Add(product);
        }  

        public async Task Delete(Product product)
        {
            await _product.Delete(product);
        }

        public async Task<Product> GetEntityById(Guid id)
        {
            return await _product.GetEntityById(id);
        }

        public async Task<List<Product>> List()
        {
            return await _product.List();
        }

        public async Task Update(Product product)
        {
            await _product.Update(product);

        }

        public async Task AddProduct(Product product)
        {
            await _productService.AddProduct(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _productService.UpdateProduct(product);
        }
    }
}
