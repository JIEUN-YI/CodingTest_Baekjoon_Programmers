            while (true)
            {
                string[] answerArr = Console.ReadLine().Split(" ");
                int.TryParse(answerArr[0], out int num1);
                int.TryParse(answerArr[1], out int num2);
                if(num1 == 0 && num2 == 0)
                {
                    break;
                }
                Console.WriteLine(num1 + num2);
            }