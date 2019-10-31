using BeetleX.XRPC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Lmf.Util.Algorithm;
using System.Linq;
using BeetleX.XRPC.Clients;

namespace Lmf.Purchasing.Api.Extensions
{
    public static class XRPCExtensions
    { 
        /// <summary>
        /// 注册XRPC服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddXRPCClient(this IServiceCollection services, IConfiguration configuration)
        {
            var hosts = configuration.GetSection("XRPCClient").Value;
            var timeOut = configuration.GetSection("XRPCClientTimeOut").Value; 
            var arr = hosts.Split(";").ToList(); 
            KetamaNodeLocator ketamaNodeLocator = new KetamaNodeLocator(arr); 
            var host = ketamaNodeLocator.GetPrimary(Guid.NewGuid().ToString());
             
            var client = new XRPCClient(host.Split(":")[0], Convert.ToInt32(host.Split(":")[1]));
            client.TimeOut = Convert.ToInt32(timeOut);
            client.Connect();
            client.NetError = (c, e) =>
            {
                Console.WriteLine(e.Error.Message);
            };
              
            services.AddSingleton(client);
            return services;
        }


    }
}
