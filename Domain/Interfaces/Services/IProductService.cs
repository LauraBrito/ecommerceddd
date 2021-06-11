using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
    }
}
