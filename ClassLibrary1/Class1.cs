using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public int StringLengths(string[] strings)
        {

            int sum = 0;
            if (strings != null)
                foreach (var str in strings)
                {
                    if(str != null)
                        sum += str.Length;
                }
            // alternative need some work
            /*for (int i = 0; i < strings.Length / 2; i++)
            {
                sum += strings[i].Length + strings[strings.Length - 1 - i].Length;
            }*/

            return sum;
        }
    }
}
