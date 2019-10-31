using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Lmf.Purchasing.Api.Extensions
{
    public static class RegisterProjExtensions
    {
        /// <summary>
        /// 注册仓储
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddProjRepository(this IServiceCollection services)
        {
            services.AddSmartSql()
                .AddRepositoryFromAssembly(options =>
                {
                    options.AssemblyString = "Lmf.Purchasing.Repository";
                });
            return services;
        }

        /// <summary>
        /// 注册服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddProjServer(this IServiceCollection services)
        { 
            var assembly = Assembly.Load("Lmf.Purchasing.Service");
            var types = assembly.GetTypes().Where(w => !w.Name.EndsWith("RPCService"));
            foreach (var type in types)
            {
                services.AddSingleton(type);
            }
            return services;
        }

    }
}
