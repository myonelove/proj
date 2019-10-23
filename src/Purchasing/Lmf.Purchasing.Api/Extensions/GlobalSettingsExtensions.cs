using BeetleX.FastHttpApi.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Lmf.Util.Algorithm;
using System.Linq;
using BeetleX.XRPC;

namespace Lmf.Purchasing.Api.Extensions
{
    public static class GlobalSettingsExtensions
    {
        public static IServiceCollection Settings(this IServiceCollection services, IConfiguration configuration)
        {
            RPCHostRun(configuration);
            services
                .AddBeetlexHttp(configuration)
                .AddRedisExchange(configuration)
                .AddProjRepository()
                .AddProjServer()
                .AddAutoMapper(typeof(Program).Assembly) 
                .AddXRPCClient(configuration);
            return services;
        }

        public static void RPCHostRun(IConfiguration configuration)
        {
            var hosts = configuration.GetSection("XRPCHosts").Value;
            var arr = hosts.Split(";").ToList();

            KetamaNodeLocator ketamaNodeLocator = new KetamaNodeLocator(arr);
            var host = ketamaNodeLocator.GetPrimary(Guid.NewGuid().ToString());

            XRPCServer xRPCServer = new XRPCServer();
            xRPCServer.RPCOptions.LogToConsole = true;
            xRPCServer.ServerOptions.DefaultListen.Host = host.Split(":")[0];
            xRPCServer.ServerOptions.DefaultListen.Port = Convert.ToInt32(host.Split(":")[1]);
            xRPCServer.ServerOptions.LogLevel = BeetleX.EventArgs.LogType.Debug;
            xRPCServer.Register(typeof(Program).Assembly);
            xRPCServer.Open();
        }
    }
}
