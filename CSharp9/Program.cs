using System;

namespace CSharp9
{
    // https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9
    public class Program
    {
        static void Main(string[] args)
        {
            Record();
            InitOnlySetter();
            PatternMatchingEnhancements('5');
            FitAndFinish();

            Console.ReadLine();
        }

        private static void Record()
        {
            var student = new Student(8, 30, "Wolfgang");
            Console.WriteLine(student.SaySomething());
        }

        private static void InitOnlySetter()
        {
            var initOnlySetter = new InitOnlySetter
            {
                Name = "Wolfgang"
            };

            // not allowed
            //initOnlySetter.Name = "Smith";
        }

        private static void PatternMatchingEnhancements(char character)
        {
            var isLetter = character is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') and not (>= '0' and <= '9');

            Console.WriteLine($"{character} is a letter and not a number: {isLetter}");
        }

        private static void FitAndFinish()
        {
            FitAndFinish fitAndFinish = new() { Name = "Wolfgang" };

            Console.WriteLine($"Hello {fitAndFinish.Name}");
        }
    }
}
