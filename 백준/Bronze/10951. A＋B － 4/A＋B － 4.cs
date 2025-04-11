            while (true)
            {
                string answer = Console.ReadLine();
                if (answer == null)
                {
                    break;
                }

                string[] answerArr = answer.Split(" ");
                int.TryParse(answerArr[0], out int num1);
                int.TryParse(answerArr[1], out int num2);

                Console.WriteLine(num1 + num2);
            }