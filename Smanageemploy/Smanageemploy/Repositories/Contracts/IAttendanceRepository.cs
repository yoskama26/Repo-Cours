using Smanageemploy.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smanageemploy.Repositories.Contracts
{
    public interface IAttendanceRepository
    {
        Task<Attendance> CreateAttendanceAsync(string attendanceToCreate);

        Task<List<Attendance>> GetAttendancesAsync();

        Task<Attendance> GetAttendanceByIdAsync(int attendanceId);

        Task<Attendance> GetAttendanceByIdWithIncludeAsync(int attendanceId);

        Task<Attendance> UpdateAttendanceAsync(string attendanceToUpdate);

        Task<Attendance> DeleteAttendanceByIdAsync(int attendanceId);
    }
}
