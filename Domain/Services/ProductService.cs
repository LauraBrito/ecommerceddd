using Domain.Interfaces.Products;
using Domain.Interfaces.Services;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProduct _product;

        public ProductService(IProduct product)
        {
            _product = product;
        }

        public async Task AddProduct(Product product)
        {
            var validateName = product.ValidateStringProp(product.Name, "Name");
            var validateValue = product.ValidateDecimalProp(product.Value, "Value");

            if(validateName && validateValue)
            {
                product.Status = true;
                await _product.Add(product);
            }
        }

        public async Task UpdateProduct(Product product)
        {
            var validateName = product.ValidateStringProp(product.Name, "Name");
            var validateValue = product.ValidateDecimalProp(product.Value, "Value");

            if (validateName && validateValue)
            {
                await _product.Update(product);
            }
        }
    }
}
