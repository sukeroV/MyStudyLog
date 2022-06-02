using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MStudyLog._220602
{
    struct Stugent
    {
        string Name;
        int Age;
        int Birthday;
        bool sex;
        public void Speak()
        {
            Console.WriteLine("{0},{1},{2},{3}",Age, Name, sex, Birthday);
        }
        public void SetStugent(string Name)
        {
            this.Name = Name;
        }

    }
    public class T2Struct
    {
        public T2Struct()
        {
            Console.WriteLine("结构体");
            Stugent stugent = new Stugent();
            stugent.SetStugent("he");
            stugent.Speak();
        }
    }
}
