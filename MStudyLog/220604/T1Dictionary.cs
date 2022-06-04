using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 官网地址
//https://docs.microsoft.com/zh-cn/dotnet/api/system.collections.generic.dictionary-2?view=net-6.0
#endregion

namespace MStudyLog._220604
{
    public class T1Dictionary
    {
        public T1Dictionary()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("he", "heshaolang");
            //dic.Add("he", "heshaolang");  //同键是错的
            dic.Add("xi", "xidada");
            Console.WriteLine(dic["he"]);
            bool bool1 = dic.ContainsKey("he2");
            Console.WriteLine(bool1);

            bool v = dic.TryGetValue("he",out string str);
            Console.WriteLine(v+"  "+str);

            int int1 = dic.Count();
            Console.WriteLine(int1);

            Dictionary<string,string>.KeyCollection strings = dic.Keys;
            foreach (string key in strings)
                Console.WriteLine(key);

            Dictionary<string,string>.ValueCollection strings2 = dic.Values;
            foreach (string value in strings2)
                Console.WriteLine(value);

            dic.Remove("xi");
        }
    }
}
