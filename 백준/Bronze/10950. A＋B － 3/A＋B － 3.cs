            int.TryParse(Console.ReadLine(), out int count);
            for (int i = 0; i < count; i++)
            {
                string[] answerArr = Console.ReadLine().Split(" ");
                int.TryParse(answerArr[0], out int num1);
                int.TryParse(answerArr[1], out int num2);
                Console.WriteLine(num1 + num2);
            }