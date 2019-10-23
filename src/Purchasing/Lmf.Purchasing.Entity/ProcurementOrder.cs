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
/// Table, procurement_order
///</summary>
    public class ProcurementOrder
    {
///<summary>
/// id, int
///</summary>
public virtual int Id { get; set; }
///<summary>
/// 采购单单号
///</summary>
public virtual string OrderNo { get; set; }
///<summary>
/// 商品的供应商id
///</summary>
public virtual int? SupplierId { get; set; }
///<summary>
/// 采购的商品的单位id
///</summary>
public virtual int? UnitKey { get; set; }
///<summary>
/// 商品单位描述
///</summary>
public virtual string UnitName { get; set; }
///<summary>
/// 最近的操作人id
///</summary>
public virtual int? OperatorStaff { get; set; }
///<summary>
/// 入库时间
///</summary>
public virtual DateTime? CreateTime { get; set; }
///<summary>
/// 最后一次更正时间
///</summary>
public virtual DateTime? ModifyTime { get; set; }
    }
    }