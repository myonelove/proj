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
/// Table, procurement_plan
///</summary>
    public class ProcurementPlanService
    {
    public IProcurementPlanRepository ProcurementPlanRepository { get; }

    public ProcurementPlanService (IProcurementPlanRepository procurementPlanRepository)
    {
    ProcurementPlanRepository = procurementPlanRepository;
    }

    public int Insert(ProcurementPlan procurementPlan)
    {
    return ProcurementPlanRepository.Insert(procurementPlan);
    }

    public int DeleteById(int id)
    {
    return  ProcurementPlanRepository.DeleteById(id);
    }

    public int Update(ProcurementPlan procurementPlan)
    {
    return  ProcurementPlanRepository.Update(procurementPlan);
    }

    }
    }