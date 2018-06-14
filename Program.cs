using System;

class Program
{
    // https://www.acmicpc.net/problem/2439
    static void Main(string[] args)
    {
        int row = int.Parse(Console.ReadLine().Split()[0]);
        
        for (int i = 0; i < row; i++)
        {
            for (int j = row - 1; j > i; j--)
            {
                Console.Write(" ");
            }
            
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
        }
    }

    // https://www.acmicpc.net/problem/2438
    /*
    static void Main(string[] args)
    {
        int row = int.Parse(Console.ReadLine().Split()[0]);

        for (int i = 1; i <= row; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
    */

    // https://www.acmicpc.net/problem/2739
    /*
    static void Main(string[] args)
    {
        int dan = int.Parse(Console.ReadLine().Split()[0]);

        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine("{0} * {1} = {2}", dan, i, dan * i);
        }
    }
    */

    // https://www.acmicpc.net/problem/2742
    /*
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine().Split()[0]);

        while (input > 0)
        {
            Console.WriteLine("{0}", input--);
        }
    }
    */

    // https://www.acmicpc.net/problem/2741
    /*
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine().Split()[0]);

        for (int i = 1; i <= input; i++)
        {
            Console.WriteLine("{0}", i);
        }
    }
    */

    // https://www.acmicpc.net/problem/2839
    /*
    static void Main(string[] args)
    {
        string input = Console.ReadLine().Split()[0];
        int sugar = int.Parse(input);
        int packages = 0;

        while (sugar % 5 > 0)
        {
            if (sugar > 5 || sugar == 3)
            {
                sugar -= 3;
                packages++;
            }
            else if (sugar < 5)
            {
                Console.WriteLine("-1");
                return;
            }
        }

        packages = sugar / 5 + packages;

        Console.WriteLine(packages);
    }
    */
}
