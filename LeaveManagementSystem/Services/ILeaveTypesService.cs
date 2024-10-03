using System;
using LeaveManagementSystem.Models.LeaveType;

namespace LeaveManagementSystem.Services;

public interface ILeaveTypesService
{
    Task Create(LeaveTypeCreateVM model);
    Task Edit(LeaveTypeEditVM model);
    Task<T?> Get<T>(int id) where T : class;
    Task<List<LeaveTypeReadOnlyVM>> GetAllLeaveTypes();
    Task Remove(int id);
    bool LeaveTypeExists(int id);

    Task<bool> CheckIfLeaveTypeNameExists(string name);
    Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveTypeEdit);

}
