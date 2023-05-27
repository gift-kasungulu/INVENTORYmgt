using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorymngt.shared
{
    public class Employees
    {
        public int EployeeId { get; set; }
        public string EmployeeFistName { get; set; }
        public string EmployeeLastName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int SaleId { get; set; }


    }
}
