namespace NavrhTrid
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}