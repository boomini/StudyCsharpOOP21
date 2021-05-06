using System;

namespace ArrayClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array 클래스 사용");

            int[] array = new int[] { 5, 7, 3, 1, 9, 10, 4, 8, 2, 6 };

            foreach(var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Array.Sort(array); //오름차순 정렬
            foreach(var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            Array.Reverse(array); //내림차순 정렬
            foreach ( var item in array)
            {
                Console.Write($"{item}\t");
            }
            // Array array1 = new Array() { 5, 7, 3, 1, 9, 10, 4, 8, 2, 6 };
            Console.WriteLine();
            int index7 = Array.IndexOf(array, 7);
            Console.WriteLine($"7의 위치는 {index7}");

            Array.Resize<int>(ref array, 11);
            array[10] = 100;
            foreach(var item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i=0; i<matrix.GetLength(0); i++)
            {
                for (int j=0; j<matrix.GetLength(1); j++)
                {
                    Console.Write($"[{i},{j}] : {matrix[i,j]}\t");
                }
                Console.WriteLine();
            }
           
        }
    }
}
