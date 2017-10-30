using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace NavrhTrid
{
    public class Usage
    {
        public static void Test()
        {
            Administrator admin = new Administrator("Karel Novak",39, new CompanyId("ab56de", DateTime.Now));
            Employee pepa = new Employee("Pepa Zdepa", 55, new CompanyId("55oopp",DateTime.Now));
            Robot robot = new Robot(new CompanyId("aahh99", new DateTime(2000,1,1)));

            var allResources = new List<ICompanyResource>();

            allResources.Add(admin);
            allResources.Add(pepa);
            allResources.Add(robot);

            admin.SayHello();
            pepa.SayHello();
            robot.SayHello();
            
            decimal companyValue = 0;
            foreach (var companyResource in allResources)
            {
                companyValue += companyResource.GetValue();
                //toto nefunguje: proc asi ?
                //companyResource.SayHello()

            }
        }
    }
}