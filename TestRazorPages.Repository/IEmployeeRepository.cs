using System;
using System.Collections.Generic;
using System.Text;
using TestRazorPages.Models;

namespace TestRazorPages.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> Search(string searchTerm);
        IEnumerable<Employee> GetAllEmployees();

        Employee GetEmployee(int id);

        Employee Update(Employee updateEmployee);

        Employee Add(Employee newEmployee);

        Employee Delete(int id);

        IEnumerable<DeptHeadCount> EmployeeCountByDept(Dept? dept);


    }
}
