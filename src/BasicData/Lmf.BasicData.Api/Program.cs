using System;
using BeetleX.FastHttpApi.Hosting;
using Lmf.BasicData.Api.Extensions;
using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Lmf.Util.Algorithm;
using BeetleX.XRPC;
using System.Linq;

namespace Lmf.BasicData.Api
{
    class Program
    {
        static void Main(string[] args)
        {  
            CreateHostBuilder().Build().Run(); 
        }
         
        public static IHostBuilder CreateHostBuilder()
        { 
            var builder = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    var config = hostContext.Configuration;  
                    services.Settings(config); //注册所有的服务  
                })
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var env = hostingContext.HostingEnvironment;
                    config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                });

            return builder;
        } 
    }
}
