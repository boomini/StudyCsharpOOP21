using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MyList
    {
        private int[] array;

        public int this[int index] // ==MyList[i] == array[i]
        {
            get
            {
                return array[index];
            }
            set
            {
                if(index >= array.Length)
                {
                    System.Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array resized : {array.Length}");
                }
                array[index] = value;
            }
        }
        public int Length
        {
            get { return array.Length; }
        }

        public MyList()
        {
            array = new int[3];
        }
    }
}
