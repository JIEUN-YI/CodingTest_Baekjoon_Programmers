 int.TryParse(Console.ReadLine(), out int count);
 int[] numbers = new int[count];
 string[] answer = Console.ReadLine().Split(" ");
 if (answer.Length != count)
 {
     return;
 }
 for (int i = 0; i < count; i++)
 {
     int.TryParse(answer[i].ToString(), out int num);
     numbers[i] = num;
 }

 Array.Sort(numbers);
 Console.Write($"{numbers[0]} {numbers[count - 1]}");