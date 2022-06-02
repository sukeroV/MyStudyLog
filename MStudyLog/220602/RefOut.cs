using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ref  实参
//out  返回

namespace MStudyLog._220602
{
    public class RefOut
    {
        //临时测试 传递数组
        //测试完毕 传递数组为实参
        public RefOut()
        {
            int[] a  = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            foreach (int i in a) Console.Write("Before:"+ i+ "\0\0\0");
            Console.WriteLine();
            Ts1(a);
            foreach (int i in a) Console.Write("after:"+i + "\0\0\0");
            Console.WriteLine();
        }

        public void Ts1(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                int Temp = ints[i];
                ints[i] = ints[ints.Length-1];
                ints[ints.Length-1] = Temp;
            }
            //foreach (int i in ints) Console.Write(i);
        }
    }
}
