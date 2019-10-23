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
    /// Table, supplier_category
    ///</summary>
    public class SupplierCategoryService
    {
        public ISupplierCategoryRepository SupplierCategoryRepository { get; }

        public SupplierCategoryService(ISupplierCategoryRepository supplierCategoryRepository)
        {
            SupplierCategoryRepository = supplierCategoryRepository;
        }

        public int Insert(SupplierCategory supplierCategory)
        {
            return SupplierCategoryRepository.Insert(supplierCategory);
        }

        public int DeleteById(int id)
        {
            return SupplierCategoryRepository.DeleteById(id);
        }

        public int Update(SupplierCategory supplierCategory)
        {
            return SupplierCategoryRepository.Update(supplierCategory);
        }

    }
}

