using System;

class Program
{
    // https://www.acmicpc.net/problem/11721
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        while (input.Length > 10)
        {
            Console.WriteLine(input.Substring(0, 10));
            input = input.Remove(0, 10);
        }
        Console.WriteLine(input);
    }

    // https://www.acmicpc.net/problem/11720
    /*
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine().Split()[0]);
        string numbers = Console.ReadLine();

        int total = 0;
        for (int i = 0; i < n; i++)
        {
            total += int.Parse(numbers[i].ToString());    
        }

        Console.WriteLine(total);
    }
    */

    // https://www.acmicpc.net/problem/8393
    /*
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine().Split()[0]);

        int total = 0;
        for (int i = 1; i <= n; i++)
        {
            total += i;
        }

        Console.WriteLine(total);
    }
    */

    // https://www.acmicpc.net/problem/1924
    /*
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();

        int month = int.Parse(inputs[0]);
        int days = int.Parse(inputs[1]);

        for (int i = month - 1; i > 0; i--)
        {
            switch (i)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days += 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days += 30;
                    break;
                case 2:
                    days += 28;
                    break;
            }
        }

        int remainder = days % 7;
        switch (remainder)
        {
            case 0:
                Console.WriteLine("SUN");
                break;

            case 1:
                Console.WriteLine("MON");
                break;

            case 2:
                Console.WriteLine("TUE");
                break;

            case 3:
                Console.WriteLine("WED");
                break;

            case 4:
                Console.WriteLine("THU");
                break;

            case 5:
                Console.WriteLine("FRI");
                break;

            case 6:
                Console.WriteLine("SAT");
                break;
        }
    }
    */

    // https://www.acmicpc.net/problem/2441
    /*
    static void Main(string[] args)
    {
        int row = int.Parse(Console.ReadLine().Split()[0]);

        for (int i = 0; i < row; i++)
        {
            for (int j = row; j < row + i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0 + i; j < row; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
        }
    }
    */

    // https://www.acmicpc.net/problem/2440
    /*
    static void Main(string[] args)
    {
        int row = int.Parse(Console.ReadLine().Split()[0]);

        for (int i = 0; i < row; i++)
        {
            for (int j = i; j < row; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
    */

    // https://www.acmicpc.net/problem/2439
    /*
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
    */

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
