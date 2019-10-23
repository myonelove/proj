using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lmf.Service.Model
{
    [MessagePackObject]
    public class StaffModel
    {
        ///<summary>
        /// Id, int
        ///</summary>
        [Key(5)]
        public int Id { get; set; }

        ///<summary>
        /// 员工名称
        ///</summary>
        [Key(0)]
        public string Name { get; set; }

        ///<summary>
        /// 员工编号
        ///</summary>
        [Key(1)]
        public string No { get; set; }

        ///<summary>
        /// 员工联系email
        ///</summary>
        [Key(2)]
        public string Email { get; set; }

        ///<summary>
        /// 领导编号，默认0=未分配领导
        ///</summary>
        [Key(3)]
        public string LeadNo { get; set; }

        ///<summary>
        /// 员工联系电话
        ///</summary>
        [Key(4)]
        public string Mobile { get; set; }

    }
}
