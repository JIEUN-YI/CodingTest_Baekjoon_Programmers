using System;

public class Example
{
    public static void Main()
    {
        int.TryParse(Console.ReadLine(), out int n);
         Console.Clear();
 int[,] triangle = new int[n, n];

 for(int i = 0; i < n; i++)
 {
     for (int j = 0; j < n; j++)
     {
         if (j <= i)
         {
             Console.Write("*");
         }
         continue;
     }
     Console.Write("\n");
     continue;
 }
    }
}