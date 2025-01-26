using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Program.Q1
{
    internal class Range<T> where T : ISubtractionOperators<T, T, T>, IComparable<T>
    {
        public T Maximum { get; set; }
        public T Minimum { get; set; }


        //constructor that takes the minimum and maximum values to define the range.
        public Range(T maximum, T minimum)
        {
            if (maximum.CompareTo(minimum) < 0)
                Helper<T>.Swap(ref maximum, ref minimum);

            Maximum = maximum;
            Minimum = minimum;
        }

        //returns true if the given value is within the range, otherwise false.
        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
        }

        //returns the length of the range.
        public T Length()
        {
            return Maximum - Maximum;
        }
    }
}
