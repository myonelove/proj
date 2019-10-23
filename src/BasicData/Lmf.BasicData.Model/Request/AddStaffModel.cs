using System;

namespace Lmf.BasicData.Model.Request
{
    public class AddStaffModel
    { 
        ///<summary>
        /// 员工联系email
        ///</summary>
        public string Email { get; set; }
        ///<summary>
        /// 入职时间
        ///</summary>
        public DateTime? Hiredate { get; set; } = DateTime.Now; 
        ///<summary>
        /// 领导编号，默认""=未分配领导
        ///</summary>
        public string LeadNo { get; set; } = "";
        ///<summary>
        /// 员工联系电话
        ///</summary>
        public string Mobile { get; set; }
        ///<summary>
        /// 员工名称
        ///</summary>
        public string Name { get; set; }
        ///<summary>
        /// 员工编号
        ///</summary>
        public string No { get; set; } = Guid.NewGuid().ToString("N");

        ///<summary>
        /// 是否离职
        ///</summary>
        public virtual bool? IsDimission { get; set; } = false;
    }
}
