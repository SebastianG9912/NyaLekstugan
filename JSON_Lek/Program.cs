using System;
using System.Text.Json;

namespace ConsoleApp1
{
    public class LekKlass
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class JSON_Lek
    {
        public static void Main()
        {
            LekKlass lek = new LekKlass()
            {
                Name = "Sebastian",
                Age = 22
            };

            string jsonString = JsonSerializer.Serialize(lek);

            Console.WriteLine(jsonString);
        }
    }
}