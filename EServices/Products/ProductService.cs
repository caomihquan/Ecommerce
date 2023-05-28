using Ecore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EServices.Products
{
    public interface IProductService
    {

    }
    public  class ProductService : IProductService
    {
        public ProductService(IDbContextFactory<TenantDbContext> dbContextFactory)
        {

        }
    }
}
