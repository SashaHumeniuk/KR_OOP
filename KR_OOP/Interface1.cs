using System;

namespace ConsoleApp1
{
    class Points
    {
        protected double a { get; set; }
        protected double b { get; set; }
        public Points(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
    }

    class Rectangle : Points
    {
        protected double c { get; set; }
        public Rectangle(double a, double b, double c) : base(a, b)
        {
            this.c = c;
        }

        public void Kuzov()
        {
            int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            int n = numbers.Length;
            int k = n / 2;
            int temp;
            for (int i = 0; i < k; i++)
            {
                temp = numbers[i];
                numbers[i] = numbers[n - i - 1];
                numbers[n - i - 1] = temp;
            }
            foreach (int i in numbers)
            {
                Console.Write($"{i} \t");
            }
        }
        }
    //task2
        interface ICar
        {
            string Type();
            double Kuzov();
            double Size();
        }

        class KUZOV : ICar
        {
            protected double a { get; set; }

            public KUZOV(double a)
            {
                this.a = a;
            }

            public double Size()
            {
                return a;
            }

            public double Kuzov()
            {
                double s = a;
                return s;
            }

            public string Type()
            {
                return "Sedan";
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle(2002, 2002, 2003);
                r.Kuzov();
                Console.WriteLine();
                KUZOV[] s = {
                new KUZOV (2002),
                new KUZOV (2002),
                new KUZOV (2003)
            };
                foreach (KUZOV str in s)
                {
                    Console.WriteLine($"Тип авто: {str.Type()}\nРік: {str.Size()}\nДвигун: {str.Kuzov()}");
                }
            }
        }
    }
