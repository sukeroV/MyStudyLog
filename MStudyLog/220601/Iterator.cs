using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region 迭代器
    
#endregion
namespace MStudyLog._220601
{
    #region 迭代器完整 1
    class CustomList : IEnumerable,IEnumerator
    {
        private int[] list;
        //从-1开始
        private int Pos = -1;
        public CustomList()
        {
            list = new int[] {1,2,3,4,5,6,7,8};
        } 

        #region IEnumerable               
        public IEnumerator GetEnumerator()
        {
            return this; //IEnumerable
        }
        #endregion

        #region IEnumerator
        public object Current
        {
            get { return list[Pos]; }
        }
        public bool MoveNext()
        {
            //移动光标
            ++Pos;
            //是否溢出
            return Pos < list.Length;
        }

        public void Reset()
        {
            Pos = -1;
        }
        #endregion

    }
    #endregion
    #region 迭代器语法糖 2
    class CustomList2 : IEnumerable
    {
        private int[] list;
        public CustomList2()
        {
            list = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Length; i++)
            {
                //yield 配合迭代器使用
                yield return list[i];
            }
            //or
            // yield return list[0] ...[1]
        }
    }
    #endregion

    #region 调用
    public class Iterator
    {
        
        public Iterator()
        {
            #region 1
            CustomList list = new CustomList();
            //foreach本质
            //1.先获取in后面后面的IEnumerable中的方法
            foreach (int item in list)
            {
                 Console.WriteLine(item);
            }
            #endregion
            #region 2
            
            CustomList2 customList2 = new CustomList2();
            foreach(int item in customList2)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine(customList2.GetEnumerator);
            #endregion
        }
        


    }
    #endregion
}
