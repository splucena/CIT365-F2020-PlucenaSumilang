using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Test
{
    class Program
    {
        public int num = 2;
        public Program() { num++; }
        ~Program() { num++;  }
        static int Test(out int x, int y=4) {
            x = 6;
            return x * y;
        }

        enum Test2 { A, B, C=5, D};
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //double width, height, woodLength, glassArea;
            //string widthString, heightString;

            //widthString = Console.ReadLine();
            //width = double.Parse(widthString);

            //heightString = Console.ReadLine();
            //height = double.Parse(heightString);

            //woodLength = 2 * ( width + height ) * 3.25;
            //glassArea = 2 * (width * height);

            //Console.WriteLine("The length of the wood is" + woodLength + " feet");
            //Console.WriteLine("The area of the glass is " + glassArea + " square meters");
            int a;
            int z = Test(out a);
            Console.WriteLine(a + z);

            int x = 4;
            int y = 9;
            x = (y % x != 0) ? y / x : y;
            Console.WriteLine(x);

            int aa = 4;
            int b = 6;
            b = aa++;
            Console.WriteLine(++b);

            int[,,] array = new int[4, 5, 3];
            Console.WriteLine(array.Length);

            string s = "Sololearn";
            int x1 = s.Length;
            int y1 = s.IndexOf("e");
            Console.WriteLine(x1 % y1);

            int[] arr = { 8, 5, 4 };
            Array.Reverse(arr);
            double x2 = Math.Pow(arr[0], 2);
            Console.WriteLine(arr[0]);
            Console.WriteLine(x2);

            int u = 0;
            try
            {
                u /= u;
                u += 1;
            } catch (Exception e)
            {
                u += 3;
            } finally
            {
                u += 4;
            }
            Console.WriteLine(u);

            Program p = new Program();
            Console.WriteLine(p.num);
            int en = (int)Test2.D;
            Console.WriteLine(en);
        }
    }
}
