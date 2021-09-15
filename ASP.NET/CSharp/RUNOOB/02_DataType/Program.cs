using System;

namespace DataTypeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of bool: {0}", sizeof(bool));
            Console.WriteLine("Size of int: {0}", sizeof(int));
            
            object obj;
            obj = 100;
            Console.WriteLine(obj);

            dynamic d = "20";
            Console.WriteLine(d);
            // Console.WriteLine("type of d: {0}", typeof(d));
            // Console.WriteLine("size of d: {0}", sizeof(d));

            String str1 = "runoob.com";
            string str2 = @"C:\Windows";
            string str3 = "C:\\Windows";
            
            // Console.ReadLine();
        }
    }
}