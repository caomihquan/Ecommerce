using EServices.Products;
using EServices.User.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EServices.User
{
    public static class UserServiceCollection
    {
        public static IServiceCollection AddUserService(this IServiceCollection services)
        {
            return services.AddScoped<IUserService, UserService>();
        }
    }
}
