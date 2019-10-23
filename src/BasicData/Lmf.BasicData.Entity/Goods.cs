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
    /// Table, goods
    ///</summary>
    public class Goods
    {
        ///<summary>
        /// 货品名称
        ///</summary>
        public virtual string GoodName { get; set; }
        ///<summary>
        /// Id, int
        ///</summary>
        public virtual int Id { get; set; }
        ///<summary>
        /// 录入时间
        ///</summary>
        public virtual DateTime? InputTime { get; set; }
        ///<summary>
        /// 货品编号
        ///</summary>
        public virtual string No { get; set; }
    }
}

