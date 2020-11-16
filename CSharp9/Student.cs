namespace CSharp9
{
    // without record
    //public class Student : Person
    //{
    //    public Student(int grade, int age, string name) : base(age, name)
    //    {
    //        Grade = grade;
    //    }

    //    public int Grade { get; set; }
    //}

    public record Student(int Grade, int Age, string Name) : Person(Age, Name);
}