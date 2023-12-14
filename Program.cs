using System;

class Program
{
    static void Main()
    {
        int n = 3; // Проверяем для степени 3

        for (int x = 1; x <= 100; x++)
        {
            for (int y = 1; y <= 100; y++)
            {
                for (int z = 1; z <= 100; z++)
                {
                    if (Math.Pow(x, n) + Math.Pow(y, n) == Math.Pow(z, n))
                    {
                        Console.WriteLine("Теорема Ферма верна для n={0}, x={1}, y={2}, z={3}", n, x, y, z);
                        return;
                    }
                }
            }
        }
        Console.WriteLine("Теорема Ферма не верна для n={0}", n);
    }
}