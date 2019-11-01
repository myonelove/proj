using Lmf.Service.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lmf.Service.PRC.BasicData
{
    /// <summary>
    /// 员工基础服务接口
    /// </summary>
    public interface IStaffService
    {
        /// <summary>
        /// 根据员工编号，获取员工基础信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<StaffModel> GetStaff(int id);

        /// <summary>
        /// 获取指定员工集合
        /// </summary>
        /// <param name="staffnos"></param>
        /// <returns></returns>
        Task<IList<StaffModel>> GetStaffs(IList<string> staffnos);

        /// <summary>
        /// 入职员工录入
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<string> AddStaff(StaffModel param);

        /// <summary>
        /// 更新员工信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        Task<string> ModifyStaff(StaffModel param);
         
    }
}
