#define Unity4
#define Unity5
#undef Unity5

///
///预处理：代码还没编译的时候就进行判断
///Unity进行版本判断
///
using System;
namespace MStudyLog
{
    public class T6preprocessing
    {
        public void a()
        {
           
#if Unity5
            Console.WriteLine("版本Unity5");
#elif Unity4
            Console.WriteLine("Unity4");
#else 
            Console.WriteLine("未知");
#endif
        }
    }
}