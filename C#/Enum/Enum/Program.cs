using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Enum
{
    class Program
    {
        enum Ranks
        {
            AB, Amn, A1C, SrA, SSgt, TSgt, MSgt, SMSgt, CMSgt
        }
        static void Main(string[] args)
        {
            Ranks a = Ranks.SSgt;
            int index = Array.IndexOf(Ranks.GetValues(a.GetType()), a);
            Console.WriteLine(index);
        }
    }
}
