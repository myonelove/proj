using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Lmf.Util.Redis;

namespace Lmf.BasicData.Api.Extensions
{
    /// <summary>
    /// RedisExchange 扩展
    /// </summary>
    public static class RedisExchangeExtensions
    {
        /// <summary>
        /// 注册Redis服务
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRedisExchange(this IServiceCollection services, IConfiguration configuration)
        {
            var redisKey = configuration.GetSection("RedisKey").Value;
            var redisExchangeHosts = configuration.GetSection("RedisExchangeHosts").Value;
            RedisClient redisHelper = new RedisClient(1, redisExchangeHosts);

            redisHelper.CustomKey = redisKey;
            services.AddSingleton(redisHelper);
            return services;
        }

    }
}
