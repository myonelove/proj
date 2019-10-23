//*******************************
// Create By mengfeng
// Date 2019-10-19 00:05
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************

using System;
namespace Lmf.BasicData.Entity
{

    ///<summary>
    /// Table, staff
    ///</summary>
    public class Staff
    {
        ///<summary>
        /// 离职时间
        ///</summary>
        public virtual DateTime? DepartureTime { get; set; }
        ///<summary>
        /// 员工联系email
        ///</summary>
        public virtual string Email { get; set; }
        ///<summary>
        /// 入职时间
        ///</summary>
        public virtual DateTime? Hiredate { get; set; }
        ///<summary>
        /// Id, int
        ///</summary>
        public virtual int Id { get; set; }
        ///<summary>
        /// 是否离职
        ///</summary>
        public virtual byte? IsDimission { get; set; }
        ///<summary>
        /// 领导编号，默认0=未分配领导
        ///</summary>
        public virtual string LeadNo { get; set; }
        ///<summary>
        /// 员工联系电话
        ///</summary>
        public virtual string Mobile { get; set; }
        ///<summary>
        /// 员工名称
        ///</summary>
        public virtual string Name { get; set; }
        ///<summary>
        /// 员工编号
        ///</summary>
        public virtual string No { get; set; }

    }
}

