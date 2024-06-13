using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
    internal class EmployeeData
    {
        static void Main(string[] args)
        {
            VendorDbcontext db = new VendorDbcontext();
            Employee e= new Employee();
            e.eid=int.Parse(Console.ReadLine());
            e.name=Console.ReadLine();
            db.Employees.Add(e);
            db.SaveChanges();
        }
    }
}
