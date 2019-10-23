using BeetleX.EventArgs;
using BeetleX.FastHttpApi.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lmf.BasicData.Api.Extensions
{
    public static class BeetlexHttpExtensions
    {

        /// <summary>
        /// 注册XRPC服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddBeetlexHttp(this IServiceCollection services, IConfiguration configuration)
        {
            #region 获取配置

            var bufferPoolMaxMemory = configuration.GetSection("HttpConfig:BufferPoolMaxMemory").Value;
            var sessionTimeOut = configuration.GetSection("HttpConfig:SessionTimeOut").Value;
            var useIPv6 = configuration.GetSection("HttpConfig:UseIPv6").Value;
            var urlIgnoreCase = configuration.GetSection("HttpConfig:UrlIgnoreCase").Value;
            var packetCombined = configuration.GetSection("HttpConfig:PacketCombined").Value;
            var logToConsole = configuration.GetSection("HttpConfig:LogToConsole").Value;
            var cacheFiles = configuration.GetSection("HttpConfig:CacheFiles").Value;
            var logLevel = configuration.GetSection("HttpConfig:LogLevel").Value;
            var webSocketMaxRPS = configuration.GetSection("HttpConfig:WebSocketMaxRPS").Value;
            var bufferSize = configuration.GetSection("HttpConfig:BufferSize").Value;
            var noGzipFiles = configuration.GetSection("HttpConfig:NoGzipFiles").Value;
            var maxConnections = configuration.GetSection("HttpConfig:MaxConnections").Value;
            var writeLog = configuration.GetSection("HttpConfig:WriteLog").Value;
            var host = configuration.GetSection("HttpConfig:Host").Value;
            var port = configuration.GetSection("HttpConfig:Port").Value;
            var maxBodyLength = configuration.GetSection("HttpConfig:MaxBodyLength").Value;
            var outputStackTrace = configuration.GetSection("HttpConfig:OutputStackTrace").Value;
            var staticResurceType = configuration.GetSection("HttpConfig:StaticResurceType").Value;
            var defaultPage = configuration.GetSection("HttpConfig:DefaultPage").Value;

            #endregion

            services.UseBeetlexHttp(o =>
            {
                #region 判断是否配置，并且指定配置

                if (bufferPoolMaxMemory != null)
                {
                    o.BufferPoolMaxMemory = Convert.ToInt32(bufferPoolMaxMemory);
                }
                if (sessionTimeOut != null)
                {
                    o.SessionTimeOut = Convert.ToInt32(sessionTimeOut);
                }
                if (useIPv6 != null)
                {
                    o.UseIPv6 = Convert.ToBoolean(useIPv6);
                }
                if (urlIgnoreCase != null)
                {
                    o.UrlIgnoreCase = Convert.ToBoolean(urlIgnoreCase);
                }
                if (packetCombined != null)
                {
                    o.PacketCombined = Convert.ToInt32(packetCombined);
                }
                if (logToConsole != null)
                {
                    o.LogToConsole = Convert.ToBoolean(logToConsole);
                }
                if (!string.IsNullOrEmpty(cacheFiles))
                {
                    o.CacheFiles = cacheFiles;
                }
                if (logLevel != null)
                {
                    o.LogLevel = (LogType)Convert.ToInt32(logLevel);
                }
                if (webSocketMaxRPS != null)
                {
                    o.WebSocketMaxRPS = Convert.ToInt32(webSocketMaxRPS);
                }
                if (bufferSize != null)
                {
                    o.BufferSize = Convert.ToInt32(bufferSize);
                }
                if (!string.IsNullOrEmpty(noGzipFiles))
                {
                    o.NoGzipFiles = noGzipFiles;
                }
                if (maxConnections != null)
                {
                    o.MaxConnections = Convert.ToInt32(maxConnections);
                }
                if (writeLog != null)
                {
                    o.WriteLog = Convert.ToBoolean(writeLog);
                }
                if (!string.IsNullOrEmpty(host))
                {
                    o.Host = host;
                }
                if (port != null)
                {
                    o.Port = Convert.ToInt32(port);
                }
                if (maxBodyLength != null)
                {
                    o.MaxBodyLength = Convert.ToInt32(maxBodyLength);
                }
                if (outputStackTrace != null)
                {
                    o.OutputStackTrace = Convert.ToBoolean(outputStackTrace);
                }
                if (!string.IsNullOrEmpty(staticResurceType))
                {
                    o.StaticResurceType = staticResurceType;
                }
                if (!string.IsNullOrEmpty(defaultPage))
                {
                    o.DefaultPage = defaultPage;
                }

                #endregion

            }, typeof(Program).Assembly);
            return services;
        }

    }
}
