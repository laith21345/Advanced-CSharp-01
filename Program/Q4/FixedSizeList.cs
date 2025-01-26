using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Q4
{
    //4. implement a custom list called FixedSizeList<T> with a predetermined capacity.
    //   This list should not allow more elements than its capacity and should provide
    //   clear messages if one tries to exceed it or access invalid indices.
    //Requirements:
    //●	Create a generic class named FixedSizeList<T>.
    //●	Implement a constructor that takes the fixed capacity of the list as a parameter.
    //●	Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
    //●	Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices. 

    internal class FixedSizeList<T>
    {
        private T[] array;
        private uint index = 0;

        private uint Capacity { get; set; }
        private uint Index 
        {
            get
            {
                if (index >= Capacity)
                    throw new IndexOutOfRangeException();
                else
                    return index;
            }
            set
            {
                if (index > Capacity)
                    throw new IndexOutOfRangeException();
                else
                    index = value;
            }
        }

        public FixedSizeList(uint capacity)
        {
            this.Capacity = capacity;
            array = new T[capacity];
        }

        public void Add(T item)
        {
            array[Index++] = item;
        }

        public T Get(uint index)
        {
            if(index >= Index)
                throw new IndexOutOfRangeException();
            else
                return array[index];
        }


    }
}
