using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Relation
{
    internal class joins
    {
        static void Main(string[] args)
        {
            VendorDbcontext db = new VendorDbcontext();

            var list = (from v in db.Vendors
                        join e in db.Employees
                        on v.eid equals e.eid
                        select new { e.eid,e.name, v.vid, v.city }
                      ).ToList();
            foreach ( var v1 in list )
            {
                Console.WriteLine(v1.eid+" "+ v1.name+" "+v1.vid+" "+v1.city );
            }
        }
    }
}
