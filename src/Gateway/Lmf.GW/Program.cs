using Bumblebee;
using System;

namespace Lmf.GW
{
    class Program
    {
        static Gateway gateway;
        static void Main(string[] args)
        {
            gateway = new Gateway();
            gateway.HttpOptions(o =>
            {
                o.Port = 8080;
                o.LogToConsole = true;
                o.LogLevel = BeetleX.EventArgs.LogType.Error;
            });
            gateway.Open();
            gateway.LoadPlugin(
                typeof(Bumblebee.Configuration.Management).Assembly,
                typeof(Bumblebee.Jwt.JwtPlugin).Assembly,
                typeof(Bumblebee.Caching.default_request_cached_reader).Assembly,
                typeof(Bumblebee.Caching.default_request_cached_writer).Assembly,
                typeof(Bumblebee.Logs.DBLog).Assembly,
                typeof(Bumblebee.ConcurrentLimits.UrlConcurrentLimits).Assembly
                );
            Console.Read();
        }
    }
}
