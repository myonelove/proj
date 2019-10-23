//*******************************
// Create By mengfengli
// Date 2019-10-22 02:05
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Linq;
using Lmf.Purchasing.Entity;
using Lmf.Purchasing.Repository;

namespace Lmf.Purchasing.Service
{
    ///<summary>
/// Table, procurement_order_detail
///</summary>
    public class ProcurementOrderDetailService
    {
    public IProcurementOrderDetailRepository ProcurementOrderDetailRepository { get; }

    public ProcurementOrderDetailService (IProcurementOrderDetailRepository procurementOrderDetailRepository)
    {
    ProcurementOrderDetailRepository = procurementOrderDetailRepository;
    }

    public int Insert(ProcurementOrderDetail procurementOrderDetail)
    {
    return ProcurementOrderDetailRepository.Insert(procurementOrderDetail);
    }

    public int DeleteById(int id)
    {
    return  ProcurementOrderDetailRepository.DeleteById(id);
    }

    public int Update(ProcurementOrderDetail procurementOrderDetail)
    {
    return  ProcurementOrderDetailRepository.Update(procurementOrderDetail);
    }

    }
    }