using System;
using System.Threading.Tasks.Dataflow;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PowerOf();

            TestaOverride();
        }

        public static void PowerOf()
        {
            int value = 153;
            int sum = 0;
            for (int i = 0; i < value.ToString().Length; i++)
            {
                sum += (int)Math.Pow(value.ToString()[i] - 48, value.ToString().Length);
            }

            int one = (int)Math.Pow(1, 3);
            int two = (int)Math.Pow(5, 3);
            int three = (int)Math.Pow(3, 3);
            int all = one + two + three;

            Console.WriteLine(sum);
            Console.WriteLine(sum == value);
        }

        public static void TestaOverride()
        {
            var over = new PlayingOverrideClass("Base", 22, DateTime.Now);

            Console.WriteLine(over);
        }
    }
}
