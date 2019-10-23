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
    /// Table, supplier
    ///</summary>
    public class Supplier
    {
        ///<summary>
        /// 供应商地址
        ///</summary>
        public virtual string Address { get; set; }
        ///<summary>
        /// 供应商类型，0=未分类
        ///</summary>
        public virtual int? Category { get; set; }
        ///<summary>
        /// 供应商联主要系人
        ///</summary>
        public virtual string Contact { get; set; }
        ///<summary>
        /// id, int
        ///</summary>
        public virtual int Id { get; set; }
        ///<summary>
        /// 开始合作时间
        ///</summary>
        public virtual DateTime? JoinUsTime { get; set; }
        ///<summary>
        /// 供应商联系点好
        ///</summary>
        public virtual string Mobile { get; set; }
        ///<summary>
        /// 供应商编号
        ///</summary>
        public virtual string No { get; set; }
        ///<summary>
        /// 供应商名称
        ///</summary>
        public virtual string SupplierName { get; set; }
    }
}

