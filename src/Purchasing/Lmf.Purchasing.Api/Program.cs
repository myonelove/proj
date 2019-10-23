using BeetleX.XRPC;
using Lmf.Purchasing.Api.Extensions;
using Lmf.Util.Algorithm;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace Lmf.Purchasing.Api
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
