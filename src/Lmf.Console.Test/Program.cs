using Lmf.Util.Algorithm;
using Lmf.Util.Redis;
using System;
using System.Collections.Generic;

namespace Lmf.Cs.Test
{
    class Program
    {
        static void Main(string[] args)
        {
         
            List<string> nodes = new List<string>()
            {
                "192.168.128:8080",
                "192.168.129:8520",
                "192.168.130:9898"
            };

            KetamaNodeLocator ketamaNodeLocator = new KetamaNodeLocator(nodes);
             
            for (int i = 0; i < 100; i++)
            {
                var h = ketamaNodeLocator.GetPrimary(Guid.NewGuid().ToString("N"));
                Console.WriteLine(h);
            }

            RedisClient redisHelper = new RedisClient(0, "127.0.0.1:6379,allowadmin=true");
            var a = redisHelper.StringGet("hello");
            Console.WriteLine(a);
            Console.ReadLine();


        }
    }
}
