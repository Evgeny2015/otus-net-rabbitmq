using Pcf.Administration.Core.Abstractions.Repositories;
using Pcf.Administration.Core.Domain.Administration;
using System;
using System.Threading.Tasks;

namespace Pcf.Administration.WebHost.Service
{
    public static class EmployeeService
    {
        public static async Task<bool> UpdateAppliedPromocodesAsync(IRepository<Employee> _employeeRepository, Guid id)
        {
            var employee = await _employeeRepository.GetByIdAsync(id);

            if (employee == null)
                return false;

            employee.AppliedPromocodesCount++;

            await _employeeRepository.UpdateAsync(employee);

            return true;
        }
    }
}
