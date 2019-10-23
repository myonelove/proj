//*******************************
// Create By mengfengli
// Date 2019-10-22 02:05
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************

using System;
namespace Lmf.Purchasing.Entity
{

    ///<summary>
/// Table, stores_returned
///</summary>
    public class StoresReturned
    {
///<summary>
/// id, int
///</summary>
public virtual int Id { get; set; }
///<summary>
/// 采购退料单号
///</summary>
public virtual string OrderNo { get; set; }
///<summary>
/// 退料状态，0=验收入库异常，1=采购收料异常
///</summary>
public virtual int? CauseCategory { get; set; }
///<summary>
/// 退料操作人
///</summary>
public virtual int? OperatorStaff { get; set; }
///<summary>
/// 退料时间
///</summary>
public virtual DateTime? CreateTime { get; set; }
///<summary>
/// 是否撤销，0=否，1=撤销退料
///</summary>
public virtual byte? Cancel { get; set; }
///<summary>
/// 最后一次操作时间
///</summary>
public virtual DateTime? ModifyTime { get; set; }
    }
    }