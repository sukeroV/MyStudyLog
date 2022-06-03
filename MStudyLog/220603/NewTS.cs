using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220603
{
    public class NewTS
    {
        public NewTS()
        {
            int? number = null;
            Console.WriteLine("输入一个小于99999的数");
            string str = Console.ReadLine();
            try
            {
                number = int.Parse(str);
                if (str.Length > 5) 
                {
                    Console.WriteLine("输入错误");
                    Environment.Exit(0);
                } 
            }
            catch
            {
                Console.WriteLine("必须输入数字");
                Environment.Exit(0);
            }
            
            foreach (char i in str) Console.Write(i+"\t");
            Console.WriteLine("此为{0}位数\n", str.Length);
            for (int i = str.Length-1; i >= 0; i--) Console.Write(str[i]+"\t");


        }
    }
}
