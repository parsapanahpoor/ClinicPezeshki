using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            #region Application Layer

            //service.AddScoped<IUserService, UserService>();
 
            #endregion


            #region Data Layer

            //service.AddScoped<IUserRepository, UserRepository>();

            #endregion

        }
    }

}
