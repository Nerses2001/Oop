using System;


//utility class


namespace Oop.ClassExamples.Statics
{
    static class StaticClass
    {
        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static void PrintDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
