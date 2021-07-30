using System;

namespace Reverse_array
{
    class Program
    {
        public static int[] Numarr = new int[] { 5, 8, 12, 45, 34, 65 };
        static void Main(string[] args) //Clean me up
        {
            Console.WriteLine("The numbers are: ");
            numCheck();
            Console.WriteLine("\r\nthe revered array is ");
            arrayreverse();
            segregateNums();        
        }
        public static void numCheck()
        {
            int i = Numarr.Length;
            int arrlen = Numarr.Length;
            foreach (int num in Numarr)
            {
                if (Numarr[i - 1] == Numarr[i - 1])
                {
                    {
                        Console.WriteLine(num);
                    }
                }
            }
        }
        public static void arrayreverse()
        {
            for (int i = 0; i != Numarr.Length ; i++)
            {
                int temp = Numarr[Numarr.Length - i - 1];
                Numarr[Numarr.Length - i - 1] = temp;
                Console.WriteLine(temp);
            }
        }
        public static void segregateNums()
        {
            int k = Numarr.Length;
            int[] odds = new int[k - 1];
            int[] evens = new int[k - 1];
            int x = 0;
            int y = 0;
            Console.WriteLine("\r\nThe odd numbers are: ");
            for (int i = 0; i < Numarr.Length; i++)
            {
                if (Numarr[i] % 2 != 0)
                {
                    evens[x] = Numarr[i];
                    x++;
                    Console.WriteLine(Numarr[i]);
                }
            }
            Console.WriteLine("\r\nThe even numbers are: ");
            for (int i = 0; i < Numarr.Length; i++)
            { 
                if (Numarr[i] % 2 == 0)
                {
                    odds[y] = Numarr[i];
                    y++;
                    Console.WriteLine(Numarr[i]);
                }          
            }
        }
    }
}

