using System;

namespace NavrhTrid
{
    public class Employee : Person, ICompanyResource
    {
        public CompanyId CompanyId { get; private set; }

        public Employee(string name, int age, CompanyId companyId) : base(name, age)
        {
            if (companyId.Equals(default (CompanyId)))
                throw new ArgumentException("Invalid id - must be set for Employee");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Invalid name");

            if (age<18)
                throw new ArgumentException("Too young !!");

            CompanyId = companyId;
        }

        public decimal Salary { get;  set; }

        public virtual void SayHello()
        {
            Console.Write("I'm employee ..., my name is "+Name);
        }

        public decimal GetValue()
        {
            return 0;
        }
    }
}