//*******************************
// Create By mengfeng
// Date 2019-10-19 00:05
// Code Generate By SmartCode
// Code Generate Github : https://github.com/Ahoo-Wang/SmartCode
//*******************************
using System;
using System.Linq;
using System.Threading.Tasks;
using Lmf.BasicData.Entity;
using Lmf.BasicData.Repository;

namespace Lmf.BasicData.Service
{
    ///<summary>
    /// Table, staff
    ///</summary>
    public class StaffService
    {
        public IStaffRepository StaffRepository { get; }

        public StaffService(IStaffRepository staffRepository)
        {
            StaffRepository = staffRepository;
        }

        public int Insert(Staff staff)
        {
            return StaffRepository.Insert(staff);
        }

        public int DeleteById(int id)
        {
            return StaffRepository.DeleteById(id);
        }

        public int Update(Staff staff)
        {
            return StaffRepository.Update(staff);
        }

        public async Task<Staff> GetById(int id)
        {
            return await StaffRepository.GetByIdAsync(id);
        }

    }
}

