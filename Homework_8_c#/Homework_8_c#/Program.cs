using Homework_8_c_;
using Homework8C;
using static Homework8C.MyClass;

Console.Write("Enter string: ");
string str = Console.ReadLine();

MyClass cls = new MyClass();
MyDelegate funcDell = cls.Space;
MyDelegate funcDell1 = cls.Reverse;

Run_1 run = new Run_1();
run.runDelegate(funcDell, str);
run.runDelegate(funcDell1, str);