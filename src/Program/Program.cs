using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "12345672");
            Person jane = new Person("Jane Doe", "76543216");
            john.IntroduceYourself();
            jane.IntroduceYourself();
        }
    }
}
