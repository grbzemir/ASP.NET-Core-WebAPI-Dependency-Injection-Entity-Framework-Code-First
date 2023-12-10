using DataLibrary.Common.IdentityManagement;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Common
{
    public static class IoC
    {

        public static void IoCCommonDataLibraryRegister(this IServiceCollection services)
        {
            services.AddScoped<ILoginUnitOfWork, LoginUnitOfWork>();
        }
    }
}
