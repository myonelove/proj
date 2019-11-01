using BeetleX.FastHttpApi;
using BeetleX.FastHttpApi.Clients;
using Lmf.Purchasing.Service.RPCClient; 
using Lmf.Service.Model; 
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lmf.Purchasing.Api.Controllers
{
    [Controller(BaseUrl ="api/purchasing/")]
    public class HomeController
    { 
        private readonly StaffClient _staffClient;

        public HomeController(StaffClient staffClient)
        {
            _staffClient = staffClient;
        }

        /// <summary>
        /// 检查检测
        /// </summary>
        /// <returns></returns>
        [Get(Route = "healthcheck")]
        public object HealthCheck()
        {

            return new { Time = DateTime.Now };
        } 

        /// <summary>
        /// 根据员工id获取员工信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Get(Route ="staff")]
        public async Task<StaffModel> GetStaff(int id)
        {
            var ret = await _staffClient.GetStaffById(id);
            return ret;
        }
         
    }
}
