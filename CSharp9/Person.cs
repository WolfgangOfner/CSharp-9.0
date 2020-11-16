namespace CSharp9
{
    // without records
    //public class Person
    //{
    //    public Person(int age, string name)
    //    {
    //        Age = age;
    //        Name = name;
    //    }

    //    public int Age { get; set; }

    //    public string Name { get; set; }
    //}

    public record Person(int Age, string Name)
    {
        public string SaySomething()
        {
            return "Hello, I am a Person";
        }
    }
}