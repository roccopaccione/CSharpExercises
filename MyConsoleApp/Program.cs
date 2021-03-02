using System;

namespace MyConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            OperatorExamples();
            LogicalOperators();
        }

        private static void OperatorExamples()
        {
            int width = 3;

            width++;

            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            bool truthValue = true;
            Console.WriteLine(truthValue);
        }

        private static void LogicalOperators()
        {
            int age = 22;
            int odd = 33;

            bool isEqual = (age == odd);
            Console.WriteLine(isEqual);

            bool isGreater = (odd >= age);
            Console.WriteLine(isGreater);
        }


    }
}
