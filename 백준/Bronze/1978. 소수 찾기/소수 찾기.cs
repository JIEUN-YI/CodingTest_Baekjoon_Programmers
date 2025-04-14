           int.TryParse(Console.ReadLine(), out int count);
           string answer = Console.ReadLine();
           string[] answerArr = answer.Split(" ");
           int[] numbers = new int[count];
           bool isMeasure = false;
           int result = 0;
           for (int i = 0; i < numbers.Length; i++)
           {
               int.TryParse(answerArr[i], out numbers[i]);
           }

           for (int i = 0; i < numbers.Length; i++)
           {
               if (numbers[i] == 2)
               {
                   isMeasure = true;
               }
               else
               {
                   for (int j = 2; j < numbers[i]; j++)
                   {
                       if (numbers[i] % j == 0)
                       {
                           isMeasure = false;
                           break;
                       }
                       else
                       {
                           isMeasure = true;
                       }
                   }
               }
                   if (isMeasure)
                   {
                       result++;
                   }
           }
           Console.WriteLine(result);