using BeetleX.FastHttpApi;
using System;
using System.Collections.Generic;
using System.Text;
using Lmf.BasicData.Entity;
using Lmf.BasicData.Service;
using Lmf.BasicData.Model.Request;
using AutoMapper;
using BeetleX.FastHttpApi.Data;
using System.Threading.Tasks;
using System.Linq;

namespace Lmf.BasicData.Api.Controllers
{
    /// <summary>
    /// 员工控制器
    /// </summary>
    [Controller(BaseUrl = "api/basicdata/staff")]
    public class StaffController
    {
        private readonly StaffService _staffService;
        private readonly IMapper _mapper;

        public StaffController(StaffService staffService, IMapper mapper)
        {
            _staffService = staffService;
            _mapper = mapper;
        }

        /// <summary>
        /// 添加新员工
        /// </summary>
        /// <param name="body"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        [Post(Route = "add")]
        [JsonDataConvert]
        public int AddStaff(AddStaffModel body)
        {
            var model = _mapper.Map<AddStaffModel, Staff>(body);
            return _staffService.Insert(model);
        }

        /// <summary>
        /// 更新员工信息
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        [Put(Route = "modify")]
        public Task<int> ModifyStaff(ModifyStaffModel body)
        {
            var model = _mapper.Map<ModifyStaffModel, Staff>(body);
            return Task.FromResult(_staffService.Update(model));
        }

    }
}
