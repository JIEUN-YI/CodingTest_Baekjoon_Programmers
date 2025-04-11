            int.TryParse(Console.ReadLine(), out int line);
            for (int i = 1; i <= line; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }