using System;

namespace L2Z1
{
    public class Program
    {
        static void Main()
        {
            Program p = new Program();
            string task;
            do
            {
                Console.WriteLine("\nWhat task do you need?\nPrint '0' to exit.");
                task = Console.ReadLine();
                switch (task)
                {
                    case "0": break;
                    case "1": p.first(); break;
                    case "2": p.second(); break;
                    case "3": p.third(); break;
                    case "5": p.fifth(); break;
                    default: Console.WriteLine("Try again. (tasks '1', '2', '3', '5' are available and '0' to exit)"); break;
                }
            } while (task != "0");

        }
        public void first()
        {
            Console.WriteLine("\n\t\t1\n\n");
            bool ok;
            Console.WriteLine("Enter the postal code:");
            do
            {
                ok = true;
                string index = Console.ReadLine();
                switch (index)
                {
                    case "58000": Console.WriteLine("The city is Chernivtsi."); break;
                    case "01000": Console.WriteLine("The city is Kyiv."); break;
                    case "29000": Console.WriteLine("The city is Khmelnytskyi."); break;
                    case "79000": Console.WriteLine("The city is Lviv."); break;
                    case "10000": Console.WriteLine("The city is Zhytomyr."); break;
                    case "54000": Console.WriteLine("The city is Mykolaiv."); break;
                    case "88000": Console.WriteLine("The city is Uzhhorod."); break;
                    case "21000": Console.WriteLine("The city is Vinnytsia."); break;
                    case "91000": Console.WriteLine("The city is Luhansk."); break;
                    case "63000": Console.WriteLine("The city is Poltava."); break;
                    case "65000": Console.WriteLine("The city is Odesa."); break;
                    default: ok = false; break;

                }
                if (ok == false) Console.WriteLine("Try another postal code. (58000, 01000, 29000, 79000, 10000, 54000, 88000, 21000, 91000, 63000, 65000)");
            } while (ok == false);
            Console.WriteLine("__________________________\n");
        }
        public void second()
        {
            Console.WriteLine("\n\n\n\t\t2\n\n");

            double a = 1, b = 2, dx = 0.025, y;
            double x = a;
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("\tx \t\t|\t\t y = f(x)");
            Console.WriteLine("_____________________________________________________\n");
            do
            {
                y = Math.Log(x, 2);
                var vx = Convert.ToSingle(x);
                var vy = Convert.ToSingle(y);
                Console.WriteLine("\t{0} \t\t|\t\t {1}\n", vx, vy);
                x += dx;
            } while (x <= b);
            Console.WriteLine("_____________________________________________________\n");
        }
        public void third()
        {
            Console.WriteLine("\n\n\n\t\t3\n\n");

            int e = 0;
            bool el = false;
            Console.WriteLine("How many elements do you need?");
            while (el == false)
            {
                e = int.Parse(Console.ReadLine());
                if ((e > 1) & ((e % 1) == 0)) el = true;
                else Console.WriteLine("Try again.");
            }
            int[] a = new int[e];
            bool check = true;
            for (int i = 0; i < e; i++)
            {
                Console.WriteLine("Enter {0:G} number.", i + 1);
                do
                {
                    a[i] = int.Parse(Console.ReadLine());
                    if ((a[i] % 1) == 0) check = false;
                } while (check);
            }
            int neg = 0;
            int min = int.MaxValue;
            for (int i = 0; i < e; i++)
            {
                if (a[i] < 0) neg++;
                if (Math.Abs(a[i]) < min) min = Math.Abs(a[i]);
            }
            int sum = 0;
            bool start = false;
            for (int i = 0; i < e; i++)
            {
                if (i >= 1)
                {
                    if (Math.Abs(a[i - 1]) == min)
                    {
                        if (start == true) sum = 0;
                        else start = true;
                    }
                    if (start) sum += a[i];
                }
                if (i == e - 1)
                {
                    if (Math.Abs(a[i]) == min) sum = 0;
                }
            }
            Console.WriteLine("The number of negative elements is {0:G}.", neg);
            Console.WriteLine("The sum of elements located after the absolute minimum number equals {0:G}.\n", sum);
            Console.WriteLine("\n___________________________________RANDOM_____________________________________\n");
            Random aRand = new Random();
            int[] b = new int[e];
            for (int i = 0; i < e; i++)
            {
                b[i] = aRand.Next(-100, 100);
                Console.WriteLine("{0:G} number is {1:G}.", i + 1, b[i]);
            }
            neg = 0;
            min = int.MaxValue;
            for (int i = 0; i < e; i++)
            {
                if (b[i] < 0) neg++;
                if (Math.Abs(b[i]) < min) min = Math.Abs(b[i]);
            }
            sum = 0;
            start = false;
            for (int i = 0; i < e; i++)
            {
                if (i >= 1)
                {
                    if (Math.Abs(b[i - 1]) == min)
                    {
                        if (start == true) sum = 0;
                        else start = true;
                    }
                    if (start) sum += b[i];

                }
                if (i == e - 1)
                {
                    if (Math.Abs(a[i]) == min) sum = 0;
                }
            }
            Console.WriteLine("The number of negative elements is {0:G}.", neg);
            Console.WriteLine("The sum of elements located after the absolute minimum number equals {0:G}.\n", sum);
            Console.WriteLine("______________________________________________________________________________\n");
        }
        public void fifth()
        {
            Console.WriteLine("\n\n\n\t\t5\n\n");
            int n = 0;
            int m = 0;
            bool el = false;
            Console.WriteLine("How many rows do you need?");
            while (el == false)
            {
                n = int.Parse(Console.ReadLine());
                if ((n >= 1) & ((n % 1) == 0)) el = true;
                else Console.WriteLine("Try again.");
            }
            Console.WriteLine("How many columns do you need?");
            el = false;
            while (el == false)
            {
                m = int.Parse(Console.ReadLine());
                if ((m >= 1) & ((m % 1) == 0)) el = true;
                else Console.WriteLine("Try again.");
            }
            int[,] A = new int[n, m];
            bool check = true;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.WriteLine("Enter A[{0:G}, {1:G}]", (i + 1), (j + 1));
                    do
                    {
                        A[i, j] = int.Parse(Console.ReadLine());
                        if ((A[i, j] % 1) == 0) check = false;
                    } while (check);
                }
            }
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (A[i, j] < min) min = A[i, j];
                    if (A[i, j] > max) max = A[i, j];
                }
            }
            Console.WriteLine("The maximum number is {0:G} and the minimum number is {1:G}.", max, min);
            int m_ax = 0;
            int m_in = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (A[i, j] == min) m_in++;
                    if (A[i, j] == max) m_ax++;
                }
            }
            Console.WriteLine("There are {0:G} maximum numbers and {1:G} minimum numbers.\n", m_ax, m_in);
            Console.WriteLine("\n___________________________________RANDOM_____________________________________\n");
            Random aRand = new Random();
            int[,] B = new int[n, m];
            check = true;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    B[i, j] = aRand.Next(-100, 100);
                    Console.WriteLine("A[{0:G}, {1:G}] = {2:G}.", (i + 1), (j + 1), B[i, j]);
                }
            }
            min = int.MaxValue;
            max = int.MinValue;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (B[i, j] < min) min = B[i, j];
                    if (B[i, j] > max) max = B[i, j];
                }
            }
            Console.WriteLine("The maximum number is {0:G} and the minimum number is {1:G}.", max, min);
            m_ax = 0;
            m_in = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (B[i, j] == min) m_in++;
                    if (B[i, j] == max) m_ax++;
                }
            }
            Console.WriteLine("There are {0:G} maximum numbers and {1:G} minimum numbers.\n", m_ax, m_in);
            Console.WriteLine("______________________________________________________________________________\n");
        }
        public static int negative(int e, int[] a)
        {
            int neg = 0;
            for (int i = 0; i < e; i++)
            {
                if (a[i] < 0) neg++;
            }
            Console.WriteLine("The number of negative elements is {0:G}.", neg);
            return neg;
        }
        public static int sum_of(int e, int[] a)
        {
            int min = int.MaxValue;
            for (int i = 0; i < e; i++)
            {
                if (Math.Abs(a[i]) < min) min = Math.Abs(a[i]);
            }
            int sum = 0;
            bool start = false;
            for (int i = 0; i < e; i++)
            {
                if (i >= 1)
                {
                    if (Math.Abs(a[i - 1]) == min)
                    {
                        if (start == true) sum = 0;
                        else start = true;
                    }
                    if (start) sum += a[i];
                }
                if (i == e - 1)
                {
                    if (Math.Abs(a[i]) == min) sum = 0;
                }
            }
            Console.WriteLine("The sum of elements located after the absolute minimum number equals {0:G}.\n", sum);
            return sum;

        }
    }
}
