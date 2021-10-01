using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.2
            Console.WriteLine("1.2");
            Console.Write("Введите первое число: ");
            int ch1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число 2: ");
            int ch2 = Convert.ToInt32(Console.ReadLine());
            int n1 = ch1;int n2 = ch2; 
            if (ch1<0)
            { 
                n1 = -ch1;
            }
            if (ch2<0)
            {
                n2 = -ch2;
            }
            if (n1>n2)
            {
                ch1 = ch1 / 2;
            }
            Console.WriteLine("Число 1: " + ch1);
            //1.3
            Console.WriteLine("\n 1.3 \n Введите назвние животного");
            string nameanimal = Console.ReadLine();
            string mouth = "wide";
            nameanimal = nameanimal.ToLower();
            if (nameanimal == "alligator")
            {
                mouth = "small";
            }
            Console.WriteLine(mouth);
    
            //3.1
            Console.WriteLine("3.1");
            int a, b, c,d; a = 1;b = 2;c = 3;
            while (Math.Abs((float)c/b - (float)b/a)>=0.001)
                {
                d = a;
                a += b;
                c = b;
                b = d;
            }
            Console.WriteLine("получившееся число: {1}/{0}", c, b);

            //3.3
            Console.WriteLine("3.3");
            Console.WriteLine("a)");
            int posled = 100; 
            while (posled>=80)
            {
                Console.WriteLine($"{posled}");
                posled--;
            }
            Console.WriteLine("b)");
            int k = 100;
            do
            {
                Console.WriteLine($"{k}");
                --k;
            } while (k >= 80);
             
            //3.5
            Console.WriteLine("3.5");
            int num = 5;
            Console.WriteLine("a)");
            for (int i =1;i<6;i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(num + " ");
                Console.WriteLine();
            }
            Console.WriteLine("b)");
            num = 1;
            for (int i = 5;i>0;--i)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(num + " ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
