using BeetleX.FastHttpApi;
using Lmf.Util.Redis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lmf.BasicData.Api.Controllers
{
    /// <summary>
    /// 主页控制器
    /// </summary>
    [Controller(BaseUrl = "api/basicdata/")]
    public class HomeController
    {  
        /// <summary>
        /// 检查检测
        /// </summary>
        /// <returns></returns>
        [Get(Route = "healthcheck")]
        public object HealthCheck()
        {
            return new { Time = DateTime.Now };
        }

    }
}
