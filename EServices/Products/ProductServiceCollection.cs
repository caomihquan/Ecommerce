using Ecore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EServices.Products
{
    public static class ProductServiceCollection
    {
        public static IServiceCollection AddProductService(this IServiceCollection services)
        {
            return services.AddScoped<IProductService, ProductService>();
        }
    }
}
