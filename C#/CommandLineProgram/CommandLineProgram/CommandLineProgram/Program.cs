using System;                                                       // 使用外部库System

namespace CommandLineProgram                                        // 命名空间, 其名称为CommandLineProgram
{                                                                   // 程序开始
    internal class Program                                          // 主类Program
    {
        public static int i;                                        // 定义一个公共静态整型变量i

        public static void loop(int a)                              // 定义一个公共静态函数loop, 其参数为整型a
        {                                                           // 函数体开始
            i = 0;                                                  // 定义i为0
            while (i <= a)                                          // 当i小于等于a时执行...
            {                                                       // 循环体开始
                Console.WriteLine(i);                               // 输出i的值并换行
                i++;                                                // 定义i的值为i+1 (简便写法)
            }                                                       // 循环体结束
        }                                                           // 函数体结束

        public static void prepare(long x1, long x2)                // 定义一个公共静态函数prepare, 其参数为长整型x1, x2
        {                                                           // 函数体开始
            if (x1 > x2)                                            // 若x1大于x2则...
            {                                                       // 条件语句块开始
                Console.WriteLine("x1 is greater than x2.");        // 输出"x1 is greater than x2."
            }                                                       // 条件语句块结束
            if (x1 < x2)                                            // 若x1小于x2则...
            {                                                       // 条件语句块开始
                Console.WriteLine("x1 is less than x2.");           // 输出"x1 is less than x2."
            }                                                       // 条件语句块结束
            if (x1 == x2)                                           // 若x1等于x2则...
            {                                                       // 条件语句块开始
                Console.WriteLine("x1 is equals to x2.");           // 输出"x1 is equals to x2."
            }                                                       // 条件语句块结束
            Console.ReadLine();                                     // 等待回车输入
        }                                                           // 函数体结束

        static void Main(string[] args)                             // 主函数Main
        {                                                           // 函数体开始
            loop(100);                                              // 执行函数loop, 参数为100
            Console.ReadLine();                                     // 等待回车输入
            loop(10);                                               // 执行函数loop, 参数为10
            Console.ReadLine();                                     // 等待回车输入
            prepare(100, 10);                                       // 执行函数prepare, 参数为100, 10
            prepare(10, 100);                                       // 执行函数prepare, 参数为10, 100
            prepare(100, 100);                                      // 执行函数prepare, 参数为100, 100
        }                                                           // 函数体结束
    }                                                               // 类结束
}                                                                   // 程序结束
