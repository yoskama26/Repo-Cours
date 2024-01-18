using Smanageemploy.Dtos.Department;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Smanageemploy.Services.Contracts
{
    public interface IAttendanceService
    {
        Task<ReadAttendance> CreateAttendanceAsync(CreateAttendance attendance);

        Task<List<ReadAttendance>> GetAttendances();

        Task<ReadAttendance> GetAttendanceByIdAsync(int attendanceId);

        Task<Attendance> UpdateAttendanceAsync(int attendanceId, UpdateAttendance attendance);

        Task<Attendance> DeleteAttendanceById(int attendanceId);
    }
}