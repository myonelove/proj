using EventNext;
using Lmf.BasicData.Entity;
using Lmf.Service.Model;
using Lmf.Service.PRC.BasicData;
using SmartSql;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lmf.BasicData.Service
{
    [Service(typeof(IStaffService))]
    public class StaffRPCService : IStaffService
    {
        public StaffRPCService()
        {
        }

        public Task<string> AddStaff(StaffModel param)
        {
            throw new NotImplementedException();
        }

        public async Task<StaffModel> GetStaff(int id)
        {
            ISqlMapper mapper = SmartSqlContainer.Instance.GetSmartSql("SmartSql").GetSqlMapper();
            var data = await mapper.QuerySingleAsync<Staff>(new RequestContext
            {
                Scope = "Staff",
                SqlId = "GetEntity",
                Request = new { Id = id }
            });

            return new StaffModel()
            {
                Email = data.Email,
                Id = data.Id,
                LeadNo = data.LeadNo,
                Mobile = data.Mobile,
                Name = data.Name,
                No = data.No
            };
        }

        public Task<List<StaffModel>> GetStaffs(IList<string> staffnos)
        {
            throw new NotImplementedException();
        }

        public Task<string> ModifyStaff(StaffModel param)
        {
            throw new NotImplementedException();
        }
    }
}