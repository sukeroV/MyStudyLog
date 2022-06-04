using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220604
{
    /// <summary>
    /// 对于这个哈希集合 是一个没有值的字典  （T1dictionary.cs）
    /// </summary>
    public class T2HashSet
    {
        public T2HashSet()
        {
            Console.WriteLine("对于这个哈希集合 是一个没有值的字典");
            HashSet<int> list = new HashSet<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            double double1 = list.Average();
            Console.WriteLine(double1);
            //copyto 复制到数组中
            int[] ints = new int[10];
            list.CopyTo(ints,2);
            foreach (int i in ints) Console.WriteLine(i);

            //
            

        }
    }

    /// <summary>
    /// 实现自定义集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MySet<T> : ISet<T>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public bool Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public void ExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsProperSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSubsetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool IsSupersetOf(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Overlaps(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public bool SetEquals(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public void SymmetricExceptWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        public void UnionWith(IEnumerable<T> other)
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Add(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
