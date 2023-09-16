using Homework8C;

namespace Homework_8_c_;

internal class Run_1: MyClass
{
    public void runDelegate(MyDelegate del,string str)
    {
        del.Invoke(str);
    }
}