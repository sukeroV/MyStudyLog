using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region 索引器的概念
//可以像数组一样通过索引其中元素。
#endregion

#region 索引器语法
//访问修饰符 返回值 this[参数类型 参数名，参数类型 参数名......]
//{
//内部写法和规则和索引器相同
//get{}
//set{}
//} 
#endregion

#region 索引器中可以写逻辑

#endregion
namespace MStudyLog._220529
{
    class Person
    {
        int ID;
        public int this[int index]
        {
            get { Console.WriteLine(index); return ID; }
            set {ID = value; Console.WriteLine(value); }
        }
    }

    /*
    class Person2
    {
        int id;
        string name;
        Person2[] person2s;

        public Person2(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Person2 this[int index]
        {
            get { Console.WriteLine(index); return this.person2s[index]; }
            set { Console.WriteLine(index); person2s[index] = value; }
        }
        
    }
    */
    internal class Indexer
    {
        Person person;
        //Person2  person2;

        public Indexer()
        {
            //1
            Console.WriteLine("索引器");
            person = new Person();
            person[0] = 1000;
            Console.WriteLine(person[0]);
            int index = 990;


            //2
            /*
            person2 = new Person2(0,"Root");
            person2[0] = new Person2(1,"一号");
            person2[1] = new Person2(2,"二号");
            Console.WriteLine(person2[0]);
            Console.WriteLine(person2[1]);
            */

        }

    }
}
