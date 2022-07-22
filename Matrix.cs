using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5__Arrays_and_Indexers_
{
    class Matrix
    {
        int[][] arr;

        public Matrix(int n, int m)
        {
            arr = new int[Math.Abs(n)][];
            for(int i = 0; i < Math.Abs(n); i++)
            {
                arr[i] = new int[Math.Abs(m)];
            }
            Fill();
        }

        public void Fill()
        {
            var rand = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(10, 50);
                }
            }
        }




    }
}
