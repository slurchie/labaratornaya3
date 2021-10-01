using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork250921
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1
            Console.WriteLine("1.1");
            Console.Write("Введите число(трёхзначное): ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            if ((chislo >= 100) && (chislo < 1000))
            {
                if (chislo/100==chislo%10)
                {
                    Console.WriteLine("число является перевёртышем " +chislo);
                }
                else
                {
                    Console.WriteLine("Число не является полиндромом" + chislo);
                }
            }
            else
            {
                Console.WriteLine("ввели неправильное число");
            }

            //1.2
            Console.WriteLine("1.2");
            Console.Write("Введите значение а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дивметр головы d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int m;
            if (a < b)
            {
                m = a + 2;
            }
            else
            {
                m = b + 2;
            }
            if (d <= m)
            {
                Console.WriteLine("Проходит");
            }
            if (d > m)
            {
                Console.WriteLine("Не проходит");
            }

            //1.3
            Console.WriteLine("\n 1.3 \n Введите номер для недели");
            int day = Convert.ToInt32(Console.ReadLine());
            if (day==1)
            {
                Console.WriteLine("понедельник");
            }    
            if (day==2)
                {
                Console.WriteLine("вторник");
            }
            if(day==3)
            {
                Console.WriteLine("среда");
            }
            if (day==4)
            {
                Console.WriteLine("четверг");
            }
            if (day==5)
            {
                Console.WriteLine("пятница");
            }
            if (day == 6)
            {
                Console.WriteLine("суббота");
            }
            if (day == 7) 
            {
                Console.WriteLine("воскресенье");
            }
            if (day>7)
            {
                Console.WriteLine("неподходящее значение");
            }

            //1.4
            Console.WriteLine("1.4");
            try
            {
                int karta = Convert.ToInt32(Console.ReadLine());
                if (karta >= 6 && karta <= 14)
                {
                    if (karta == 11)
                    {
                        Console.WriteLine("валет");
                    }
                    if (karta == 12)
                    {
                        Console.WriteLine("дама");
                    }
                    if (karta==13)
                    {
                        Console.WriteLine("король");
                    }
                    if (karta==14)
                    {
                        Console.WriteLine("туз");
                    }
                    Console.WriteLine($"Карта- {karta}");

                }
                else
                {
                    throw new Exception("Вы ввели неправильное число");
                }
            }
            catch (FormatException error)
            {
                Console.WriteLine(error);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            finally
            {
                Console.WriteLine("блок завершён");
            }
            

            
            //1.5
            Console.WriteLine("\n 1.5 \n Введите расстояние от Земли 1-10км: ");
            d = Convert.ToInt32(Console.ReadLine());
            int r = 6350;double h;
            for (d = 1; d < 10; d++) ;
            {
                h = Math.Sqrt((d + r) * (d + r) - (r * r));
                Console.WriteLine("расстояние= " + h);
            }

            //1.6
            Console.WriteLine("1.6");
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=9;++i)
            {
             Console.WriteLine(n + " x " + i + " = " + (n * i));
            }

            //1.7
            Console.WriteLine("1.7");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int klvo = 0;int sum = 0;
                while(number>=0)
                {
                    klvo++;
                    sum += number;
                    number = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"среднее арифметическое: {sum / klvo}");
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            finally
            {
                Console.WriteLine("блок завершён");
            }
            //1.8
            Console.WriteLine("1.8");
            int nmnumber = 0;
            double[] numbers = new double[10];
            for (int i =0;i<10;i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 1;i<10;i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    nmnumber = i +1;
                    break;
                }
            }
            Console.WriteLine($"номер числа: {nmnumber}");
            //1.9
            Console.WriteLine("1.9");
            int num= Convert.ToInt32(Console.ReadLine());
            int summa = 0, counter = 0;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                counter++;
                if (counter % 3 != 0) ;
                continue;
                summa += num;
            }
            while (num != 0);
            Console.WriteLine($"сумма: {summa}");
            //1.10
            Console.WriteLine("1.10");
            summa = 0;
        Start:
            num = Convert.ToInt32(Console.ReadLine());
            if(num!=0)
            {
                summa += num;
                goto Start;
            }
            Console.WriteLine($"сумма: {summa}");
            Console.ReadLine();
        }
    }
}
