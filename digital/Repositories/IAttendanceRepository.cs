using digital.Models;

namespace digital.Interfaces
{
    public interface IAttendanceRepository
    {
        List<Attendance> GetAttendanceByStudentId(int studentId);
        List<Attendance> GetAttendanceByFilters(List<int> studentIds, int month, int year);
        void SaveAttendance(List<Attendance> attendanceRecords);
    }
}
