using System;

namespace NavrhTrid
{
    /// <summary>
    /// Robot nededi z Person
    /// </summary>
    public class Robot : ICompanyResource
    {
        public Robot(CompanyId id)
        {
            CompanyId = id;
        }

        public CompanyId CompanyId { get; }
        public void SayHello()
        {
            Console.Write("I'm robot");
        }

        public decimal GetValue()
        {
            return 1000;
        }
    }
}
