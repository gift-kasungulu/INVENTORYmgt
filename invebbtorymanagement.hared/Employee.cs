using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invebbtorymanagement.shared
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public int ProductId { get; set; }
        public int SalesId { get; set; }



    }
}
