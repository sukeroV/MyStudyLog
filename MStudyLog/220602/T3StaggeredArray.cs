using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220602
{
    public class T3StaggeredArray
    {
        int[][] arr;
        int[][] arr2 = new int[4][];
        int[][] arr3 = new int[3][] {new int[] {1,3}, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 } };
        public T3StaggeredArray()
        {
            Console.WriteLine(arr2.Length);
            Console.WriteLine(arr2.GetLength(0));
        }
    }
}
