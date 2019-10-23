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
/// Table, receiving
///</summary>
    public class ReceivingService
    {
    public IReceivingRepository ReceivingRepository { get; }

    public ReceivingService (IReceivingRepository receivingRepository)
    {
    ReceivingRepository = receivingRepository;
    }

    public int Insert(Receiving receiving)
    {
    return ReceivingRepository.Insert(receiving);
    }

    public int DeleteById(int id)
    {
    return  ReceivingRepository.DeleteById(id);
    }

    public int Update(Receiving receiving)
    {
    return  ReceivingRepository.Update(receiving);
    }

    }
    }