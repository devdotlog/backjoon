using System;

class Program
{
    // https://www.acmicpc.net/problem/1546
    private static void Main(string[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split();

        int[] points = new int[N];

        for (int i = 0; i < inputs.Length; i++)
        {
            points[i] = Convert.ToInt32(inputs[i]);
        }

        Array.Sort(points);

        decimal sum = 0;
        for (int i = 0; i < N; i++)
        {
            sum += points[i];
        }

        Console.Write("{0:#.00}\n", Math.Round(sum * 100 / points[N - 1] / N, 2));
    }
    
    // https://www.acmicpc.net/problem/10871
    /*
    private static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();

        int N = Convert.ToInt32(inputs[0]);
        int X = Convert.ToInt32(inputs[1]);

        string[] sequence = Console.ReadLine().Split();

        for (int i = 0; i < N; i++)
        {
            if (X > Convert.ToInt32(sequence[i]))
            {
                Console.Write("{0} ", sequence[i]);
            }
        }
    }
    */

    // https://www.acmicpc.net/problem/10817
    /*
    private static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();

        int[] buckets = new int[inputs.Length];
        buckets[0] = Convert.ToInt32(inputs[0]);
        buckets[1] = Convert.ToInt32(inputs[1]);
        buckets[2] = Convert.ToInt32(inputs[2]);

        if (buckets[0] > buckets[1])
        {
            Swap(ref buckets[0], ref buckets[1]);
        }

        if (buckets[0] > buckets[2])
        {
            Swap(ref buckets[0], ref buckets[2]);
        }

        if (buckets[1] > buckets[2])
        {
            Swap(ref buckets[1], ref buckets[2]);
        }

        Console.Write("{0}\n", buckets[1]);
    }

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    */

    // https://www.acmicpc.net/problem/9498
    /*
    private static void Main(string[] args)
    {
        var point = Convert.ToInt32(Console.ReadLine());

        if (point >= 90 && point <= 100)
        {
            Console.WriteLine("A");
        }
        else if (point >= 80 && point <= 89)
        {
            Console.WriteLine("B");
        }
        else if (point >= 70 && point <= 79)
        {
            Console.WriteLine("C");
        }
        else if (point >= 60 && point <= 69)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
    */

    // https://www.acmicpc.net/problem/15552
    /*
    private static void Main(string[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());

        while (n-- > 0)
        {
            string[] inputs = Console.ReadLine().Split();
            int output = Convert.ToInt32(inputs[0]) + Convert.ToInt32(inputs[1]);
            Console.Write("{0}\n", output);
        }
    }
    */

    // https://www.acmicpc.net/problem/11721
    /*
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
    */

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
