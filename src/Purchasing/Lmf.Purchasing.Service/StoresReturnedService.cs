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
/// Table, stores_returned
///</summary>
    public class StoresReturnedService
    {
    public IStoresReturnedRepository StoresReturnedRepository { get; }

    public StoresReturnedService (IStoresReturnedRepository storesReturnedRepository)
    {
    StoresReturnedRepository = storesReturnedRepository;
    }

    public int Insert(StoresReturned storesReturned)
    {
    return StoresReturnedRepository.Insert(storesReturned);
    }

    public int DeleteById(int id)
    {
    return  StoresReturnedRepository.DeleteById(id);
    }

    public int Update(StoresReturned storesReturned)
    {
    return  StoresReturnedRepository.Update(storesReturned);
    }

    }
    }