using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal static class Helper<T>
    {
        public static void Swap(ref T value01, ref T value02)
        {
            T temp = value01;
            value01 = value02;
            value02 = temp;
        }
    }
}
