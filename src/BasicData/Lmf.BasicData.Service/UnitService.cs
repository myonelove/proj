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
    /// Table, unit
    ///</summary>
    public class UnitService
    {
        public IUnitRepository UnitRepository { get; }

        public UnitService(IUnitRepository unitRepository)
        {
            UnitRepository = unitRepository;
        }

        public int Insert(Unit unit)
        {
            return UnitRepository.Insert(unit);
        }

        public int DeleteById(int id)
        {
            return UnitRepository.DeleteById(id);
        }

        public int Update(Unit unit)
        {
            return UnitRepository.Update(unit);
        }

    }
}

