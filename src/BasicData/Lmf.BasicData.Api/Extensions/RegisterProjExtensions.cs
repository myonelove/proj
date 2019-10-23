using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace Lmf.BasicData.Api.Extensions
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
                    options.AssemblyString = "Lmf.BasicData.Repository";
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
            var assembly = Assembly.Load("Lmf.BasicData.Service");
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                services.AddSingleton(type);
            }
            return services;
        }

        /// <summary>
        /// 注册RPC
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddProjRPC(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly().DefinedTypes.Where(w => w.Name.EndsWith("RPCService"));
            foreach (var item in assembly)
            {
                if (item.GetInterfaces().Count() == 0)
                {
                    continue;
                }
                services.AddTransient(item.GetInterfaces().FirstOrDefault(), item);
            }
            return services;
        }

    }
}
