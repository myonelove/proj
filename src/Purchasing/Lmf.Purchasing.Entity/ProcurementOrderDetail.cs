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
/// Table, procurement_order_detail
///</summary>
    public class ProcurementOrderDetail
    {
///<summary>
/// id, int
///</summary>
public virtual int Id { get; set; }
///<summary>
/// 采购单明细
///</summary>
public virtual string OrderNo { get; set; }
///<summary>
/// 采购的商品
///</summary>
public virtual int? GoodsId { get; set; }
///<summary>
/// 采购的数量
///</summary>
public virtual int? Qty { get; set; }
///<summary>
/// 采购的商品单价
///</summary>
public virtual decimal? Price { get; set; }
///<summary>
/// 采购的商品的单位id
///</summary>
public virtual int? UnitKey { get; set; }
///<summary>
/// 商品单位描述
///</summary>
public virtual string UnitName { get; set; }
    }
    }