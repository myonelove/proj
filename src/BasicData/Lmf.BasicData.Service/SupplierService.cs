//*******************************
// Create By mengfeng
// Date 2019-10-19 00:05
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Linq;
using Lmf.BasicData.Entity;
using Lmf.BasicData.Repository;

namespace Lmf.BasicData.Service
{
    ///<summary>
    /// Table, supplier
    ///</summary>
    public class SupplierService
    {
        public ISupplierRepository SupplierRepository { get; }

        public SupplierService(ISupplierRepository supplierRepository)
        {
            SupplierRepository = supplierRepository;
        }

        public int Insert(Supplier supplier)
        {
            return SupplierRepository.Insert(supplier);
        }

        public int DeleteById(int id)
        {
            return SupplierRepository.DeleteById(id);
        }

        public int Update(Supplier supplier)
        {
            return SupplierRepository.Update(supplier);
        }

    }
}

