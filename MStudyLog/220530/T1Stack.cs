using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220530
{

    public class Node
    {
        private string[] strings = null;
        //private int NowPointerPos = -1;
        private int Index = -1;
        public string getStack()
        {
            if (Index > -1)
            {
                return strings[Index--];
            }
            else
            {
                Console.WriteLine("栈中无数据");
                return null;
            }
            Console.WriteLine("入栈操作完毕");
        }
        public void setStack(string str)
        {
            //strings[0] = str;
                if (Index == -1)
                {
                    strings[++Index] = str;
                }
                else
                {
                    strings[Index++] = str;
                }
        }
    }

    public class T1Stack
    {                
        public void setStack(string str)
        {
            Node node = new Node();
            //node[0] = str;
            //node.setStack(str);
            Stack<int> ints = new Stack<int>();
            ints.Push(100);
            int a = ints.Pop();
            Console.WriteLine(a);
        }
    }
}

