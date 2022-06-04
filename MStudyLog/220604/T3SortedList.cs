using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220604
{
    public class T3SortedList
    {
        public T3SortedList()
        {
            SortedList<int,string> list = new SortedList<int,string>();
            list.Add(2, "e");
            list.Add(4, "g");
            list.Add(6, "t");
            list.Add(3, "f");
            list.Add(0, "z");
            List<string> strings = new List<string>();
            IList<string> keyValuePairs = list.Values;
            foreach (string keyValuePair in keyValuePairs) Console.WriteLine(keyValuePair);



        }
    }
}
