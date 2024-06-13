using CodeFirst.Relation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendorDbcontext db = new VendorDbcontext();
            Console.WriteLine("Employee details");
           


            Vendor v=new Vendor();
            v.vid=int.Parse(Console.ReadLine());
            v.vname=Console.ReadLine();
            v.DoReg=DateTime.Parse(Console.ReadLine());
            v.city=Console.ReadLine();
            v.country=Console.ReadLine();
            v.eid=int.Parse(Console.ReadLine());
            db.Vendors.Add(v);
            db.SaveChanges();


            VendorDbcontext db1 = new VendorDbcontext();
            Employee e = new Employee();
            e.eid = int.Parse(Console.ReadLine());
            e.name = Console.ReadLine();
            db1.Employees.Add(e);
            db1.SaveChanges();


        }
    }
}
