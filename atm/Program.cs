using System;
using System.Collections.Generic;

namespace atm
{ 
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] banknotes = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            Atm(0, 0, n, banknotes, new Stack<int>());
            Console.WriteLine("end");
        }

        public static void Atm(int curSum, int l, int maxSum, int[] banknotes, Stack<int> stack)
        {
            if (curSum == maxSum)
            {
                foreach (int a in stack)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();
            }
            else
            {
                if (l == banknotes.Length)
                {
                    return;
                }

                if (curSum + banknotes[l] <= maxSum)
                {
                    stack.Push(banknotes[l]);
                    Atm(curSum + banknotes[l], l, maxSum, banknotes, stack);
                    stack.Pop();

                }
                Atm(curSum, l + 1, maxSum, banknotes, stack);
            }
        }
    }
}
