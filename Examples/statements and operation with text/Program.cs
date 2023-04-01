using System;

class Program
{
    static void Main()
    {
        int n, m, i, j;
        char c = ' ';
        string[] a;

        string[] inputs = Console.ReadLine().Split();
        n = int.Parse(inputs[0]);
        m = int.Parse(inputs[1]);

        for (i = 0; i < n; i++)
        {
            a = Console.ReadLine().Split();
            //if first digit is " ";
            if (a[0][0] == c)
            {
                Console.WriteLine("NO");
                return;
            }

            c = a[0][0];

            for (j = 1; j < m; j++)
                if (a[j][0] != c)
                {
                    Console.WriteLine("NO");
                    return;
                }
        }

        Console.WriteLine("YES");
    }
}
