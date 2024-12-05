using System;

public class Program
{
    public static int Persistence(int num)
    {
        int count = 0;

        while (num >= 10)
        {
            int product = 1;

            while (num > 0)
            {
                product *= num % 10;  
                num /= 10;  
            }

            num = product; 
            count++;  
        }

        return count;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число для вычисления мультипликативной стойкости:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Мультипликативная стойкость: {Persistence(num)}");
    }
}
