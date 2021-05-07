using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTestApp
{
    class MyList :IEnumerable, IEnumerator
    {
        private int position = -1; //배열의 현재 위치값
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

        //IEnumarator
        public object Current
        {
            get { return array[position]; } //현재값 foreach에만 필요
        }

        public MyList()
        {
            array = new int[3]; //0,1,2
        }

        //IEnumerable 메서드
        public bool MoveNext()
        {
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1; //초기화
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
