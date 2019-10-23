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
/// Table, receiving
///</summary>
    public class Receiving
    {
///<summary>
/// Id, int
///</summary>
public virtual int Id { get; set; }
///<summary>
/// 采购收料单号
///</summary>
public virtual string OrderNo { get; set; }
///<summary>
/// 采购单id
///</summary>
public virtual string ProcurementOrderNo { get; set; }
///<summary>
/// 收料操作人
///</summary>
public virtual int? OperatorStaff { get; set; }
///<summary>
/// 收料时间
///</summary>
public virtual DateTime? CreateTime { get; set; }
///<summary>
/// 收料状态，0=正常，1=有异常，可能退货
///</summary>
public virtual int? Status { get; set; }
///<summary>
/// 收料异常说明/备注
///</summary>
public virtual string Remark { get; set; }
    }
    }