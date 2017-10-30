using System;

namespace NavrhTrid
{
    public class Administrator : Employee
    {
        public string Description { get; private set; }

        public Administrator(string name, int age, CompanyId companyId) : base(name, age, companyId)
        {
        }

        //volani konstruktoru navzajem:

        public Administrator(string name, int age, CompanyId companyId, string description) : this(name, age, companyId)
        {
            Description = description;
        }

        public override void SayHello()
        {
            Console.Write("I'm admin");
        }
    }
}