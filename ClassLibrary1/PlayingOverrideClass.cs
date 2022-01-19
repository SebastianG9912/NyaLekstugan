using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class PlayingOverrideClass
    {
        public string Name;
        public int Age;
        public DateTime Register;

        public PlayingOverrideClass(string n, int a, DateTime r)
        {
            Name = n;
            Age = a;
            Register = r;
        }

        public override string ToString()
        {
            return $"Info: {Name} {Age} {Register}";
        }
    }
}
