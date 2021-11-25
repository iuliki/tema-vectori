using System;

namespace TemaVectori
{
    class Program
    {
        static void Main(string[] args)
        { 

            Console.WriteLine("Hello World!");
        }

        static void Print(int[] array)
        {
            if( array is null)
            {
                Console.WriteLine("array is null");
                return;
            }
            Console.Write("array= ");
            for(int i=0;i<array.Length;i++)
            {
                int element = array[i];
                Console.Write(alemenet);
                if(i<array.length -1)
                {
                    Console.Write(",");
                }
            }
        }
    }
}
