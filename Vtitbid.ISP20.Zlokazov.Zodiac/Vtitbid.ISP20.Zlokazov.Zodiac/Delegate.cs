using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.ISP20.Zlokazov.Zodiac
{
    public class Delegates
    {
        public delegate void Del(string message);
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

    }
}
