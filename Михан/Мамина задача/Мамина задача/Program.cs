using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Мамина_задача
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 100;
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double s1 = 0;
            double s2 = 0;
            double s3 = 0;
            double s4 = 0;


            for (int i = 0; i < k; i++)
            {

                if (s1 == 8 && s2 == 13 && s3 == 6 && s4 == 8)
                {
                    Console.WriteLine($"a:{a}  b:{b}  c:{c}  d:{d}");
                }
                a += 0.1;
                s1 = a + b;
                s2 = a + c;
                s3 = c - d;
                s4 = b + d;

                for (int i1 = 0; i1 < k; i1++)
                {

                    if (s1 == 8 && s2 == 13 && s3 == 6 && s4 == 8)
                    {
                        Console.WriteLine($"a:{a}  b:{b}  c:{c}  d:{d}");
                    }
                    b += 0.1;
                    s1 = a + b;
                    s2 = a + c;
                    s3 = c - d;
                    s4 = b + d;
                    for (int i2 = 0; i2 < k; i2++)
                    {

                        if (s1 == 8 && s2 == 13 && s3 == 6 && s4 == 8)
                        {
                            Console.WriteLine($"a:{a}  b:{b}  c:{c}  d:{d}");
                        }
                        c += 0.1;
                        s1 = a + b;
                        s2 = a + c;
                        s3 = c - d;
                        s4 = b + d;
                        for (int i3 = 0; i3 < k; i3++)
                        {
                            if (s1 == 8 && s2 == 13 && s3 == 6 && s4 == 8)
                            {
                                Console.WriteLine($"a:{a}  b:{b}  c:{c}  d:{d}");
                            }
                            d += 0.1;
                            s1 = a + b;
                            s2 = a + c;
                            s3 = c - d;
                            s4 = b + d;

                        }
                        d = 0;
                    }
                    c = 0;
                }
                b = 0;
                
            }
            Console.WriteLine("Коней работы");



            Console.ReadKey();
        }
    }
}
