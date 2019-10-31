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
            var types = assembly.GetTypes().Where(w=> !w.Name.EndsWith("RPCService"));
            foreach (var type in types)
            {
                services.AddSingleton(type);
            }
            return services;
        } 

    }
}
