using EventNext;
using Lmf.BasicData.Entity;
using Lmf.Service.Model;
using Lmf.Service.PRC.BasicData;
using SmartSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lmf.BasicData.Service
{
    [Service(typeof(IStaffService))]
    public class StaffRPCService : IStaffService
    { 
        public Task<string> AddStaff(StaffModel param)
        {
            throw new NotImplementedException();
        }

        public async Task<StaffModel> GetStaff(int id)
        {
            var mapper = SmartSqlContainer.Instance.GetSmartSql("SmartSql").GetSqlMapper();
            var data = await mapper.QuerySingleAsync<StaffModel>(new RequestContext
            {
                Scope = "Staff",
                SqlId = "GetEntityById",
                Request = new { Id = id }
            }); 
            return data;
        }

        public async Task<IList<StaffModel>> GetStaffs(IList<string> staffnos)
        {
            string strStaffnos = string.Join(',',staffnos.Select(s=>$"'{s}'"));
            var mapper = SmartSqlContainer.Instance.GetSmartSql("SmartSql").GetSqlMapper();
            var data = await mapper.QueryAsync<StaffModel>(new RequestContext { 
                Scope = "Staff",
                SqlId = "GetListByNos",
                Request  = new
                {
                    No = strStaffnos
                }
            });
            return data;
        }

        public Task<string> ModifyStaff(StaffModel param)
        {
            throw new NotImplementedException();
        }
    }
}