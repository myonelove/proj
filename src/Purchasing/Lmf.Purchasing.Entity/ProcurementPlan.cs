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
/// Table, procurement_plan
///</summary>
    public class ProcurementPlan
    {
///<summary>
/// id, int
///</summary>
public virtual int Id { get; set; }
///<summary>
/// 供应商编号
///</summary>
public virtual int? SupplierId { get; set; }
///<summary>
/// 商品资料Id
///</summary>
public virtual int? GoodId { get; set; }
///<summary>
/// 计划采购产品数量
///</summary>
public virtual int? Qty { get; set; }
    }
    }