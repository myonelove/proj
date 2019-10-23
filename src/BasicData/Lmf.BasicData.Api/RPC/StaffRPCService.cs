using AutoMapper;
using BeetleX.FastHttpApi;
using EventNext;
using Lmf.BasicData.Entity;
using Lmf.BasicData.Repository;
using Lmf.BasicData.Service;
using Lmf.Service.Model;
using Lmf.Service.PRC.BasicData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lmf.BasicData.Api.RPC
{  
    [Service(typeof(IStaffService))]
    public class StaffRPCService : IStaffService
    {
        private readonly StaffService _staffService;
        private readonly IMapper _mapper;

        public StaffRPCService(StaffService staffService, IMapper mapper)
        {
            _staffService = staffService;
            _mapper = mapper;
        }

        public Task<string> AddStaff(StaffModel param)
        {
            throw new NotImplementedException();
        }

        public async Task<StaffModel> GetStaff(int id)
        {
            var entity = await _staffService.GetById(id);
            var model = _mapper.Map<Staff, StaffModel>(entity);
            return model; 
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
