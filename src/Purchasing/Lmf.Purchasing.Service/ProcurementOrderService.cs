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
/// Table, procurement_order
///</summary>
    public class ProcurementOrderService
    {
    public IProcurementOrderRepository ProcurementOrderRepository { get; }

    public ProcurementOrderService (IProcurementOrderRepository procurementOrderRepository)
    {
    ProcurementOrderRepository = procurementOrderRepository;
    }

    public int Insert(ProcurementOrder procurementOrder)
    {
    return ProcurementOrderRepository.Insert(procurementOrder);
    }

    public int DeleteById(int id)
    {
    return  ProcurementOrderRepository.DeleteById(id);
    }

    public int Update(ProcurementOrder procurementOrder)
    {
    return  ProcurementOrderRepository.Update(procurementOrder);
    }

    }
    }