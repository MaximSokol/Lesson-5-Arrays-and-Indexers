using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5__Arrays_and_Indexers_
{
    class Array
    {
        int[] arr;
        int size;
        Random rand = new Random();
        //------------------------------

        public Array() { }
        public Array(int size) 
        { 
            this.size = size;
            arr = new int[size]; 
        }
        //----------------------------------------------------

        public void FillInTheArray()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 10);
            }
        }
        //----------------------------------------------------

        public void FindMinMaxElements()
        {
            int max = arr[0];
            int min = arr[0];

            for(int i = 0; i <= arr.Length-1; i++)
            {
                Console.WriteLine(arr[i]);
                if (arr[i] > max)
                {
                    max = arr[i];
                } 
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum\t" + max);
            Console.WriteLine("Minimum\t" + min);
        }
        //----------------------------------------------------

        public int CountTotalNumber()
        {
            int total = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            return total;
        }
        //----------------------------------------------------

        public void CountAverage()
        {
            int buffer = 0;
            int res = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                buffer += arr[i];
                res = buffer / size;
            }
            Console.WriteLine("Avg\t" + res);
        }
        //----------------------------------------------------

        public int UnCountableNumbers()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 != 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            return -1;
        }
        //----------------------------------------------------
    }
}
