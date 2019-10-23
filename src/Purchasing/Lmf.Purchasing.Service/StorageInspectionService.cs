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
/// Table, storage_inspection
///</summary>
    public class StorageInspectionService
    {
    public IStorageInspectionRepository StorageInspectionRepository { get; }

    public StorageInspectionService (IStorageInspectionRepository storageInspectionRepository)
    {
    StorageInspectionRepository = storageInspectionRepository;
    }

    public int Insert(StorageInspection storageInspection)
    {
    return StorageInspectionRepository.Insert(storageInspection);
    }

    public int DeleteById(int id)
    {
    return  StorageInspectionRepository.DeleteById(id);
    }

    public int Update(StorageInspection storageInspection)
    {
    return  StorageInspectionRepository.Update(storageInspection);
    }

    }
    }