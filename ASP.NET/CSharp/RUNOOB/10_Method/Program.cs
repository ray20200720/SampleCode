using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int FindMax(int num1, int num2)
        {
            int result;

            if(num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }

        public int factorial(int num)
        {
            int result;

            if(num == 1)
            {
                return 1;
            }
            else
            {
                result = factorial(num-1) * num;
                return result;
            }
        }

        void swap(int x, int y)
        {
            
        }

        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();


            // ret = n.FindMax(a, b);
            // Console.WriteLine("最大值是： {0}", ret );

            Console.WriteLine("6 的階乘是： {0}", n.factorial(6));
            Console.WriteLine("7 的階乘是： {0}", n.factorial(7));
            Console.WriteLine("8 的階乘是： {0}", n.factorial(8));
            //Console.ReadLine();
        }
    }

    class Test
    {
        // static void Main(string[] args)
        // {
        //     int a = 100;
        //     int b = 200;
        //     int ret;
        //     NumberManipulator n = new NumberManipulator();

        //     ret = n.FindMax(a, b);
        //     Console.WriteLine("最大值是： {0}", ret );
        //     //Console.ReadLine();
        // }
    }
}