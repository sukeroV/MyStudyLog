
///
///contravariant and covariant
///
/// 
delegate T MyFunc_invert<out T>();
// delegate T TestOut<out T>();//协变
delegate T TestOut<out T>();
// delegate void TestIn<in T>(T t);//逆变
delegate void TestIn<in T>(T t);
//里氏替换原则
class Father
{
    
}

class Son : Father
{
    
}

namespace MStudyLog
{
    
    public class T4contravariant
    {
        public void M()
        {
            //协变 父类总是能被子类替换
            TestOut<Son> os = () =>
            {
                return new Son();
            };
            //MyFunc_invert<Father> cf = os;
            TestOut<Father> of = os;
            Father f = of();
            
            //协变  子类总是能被父类替换
            TestIn<Father> iF = (value) =>
            {
                //return new Son();
            };
            //MyFunc_invert<Father> cf = os;
            TestIn<Son> iS = iF;
            iS(new Son());
            
        }
        
    }
    //总结
    //协变 out
    //逆变 in
    //用来修饰泛型代替符（T）的  只能用于修饰接口和委托中的泛型
    
    //作用两个
    //1.out 只做返回  in 只做参数
    //里氏替换  用于out和in修饰的 泛型委托  可以相互转载（有父子关系的泛型）
    //协变 父类泛型委托装子类泛型委托
    //协变 子类泛型委托装父类泛型委托
}