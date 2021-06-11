using Domain.Interfaces.Products;
using Entities.Entities;
using Infra.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.Repositories
{
    public class ProductRepository : RepositoryGenerics<Product>, IProduct
    {
    }
}
