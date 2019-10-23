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
/// Table, storage_inspection
///</summary>
    public class StorageInspection
    {
///<summary>
/// id, int
///</summary>
public virtual int Id { get; set; }
///<summary>
/// 验收入库单号
///</summary>
public virtual string OrderNo { get; set; }
///<summary>
/// 采购收料单号
///</summary>
public virtual string ReceivingNo { get; set; }
///<summary>
/// 验收操作人
///</summary>
public virtual int? OperatorStaff { get; set; }
///<summary>
/// 记录时间
///</summary>
public virtual DateTime? CreateTime { get; set; }
    }
    }