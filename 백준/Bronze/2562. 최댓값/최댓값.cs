Dictionary<int, int> numbers = new Dictionary<int, int>(9);
Dictionary<int, int> answer = new Dictionary<int, int>(9);
for (int i = 0; i < 9; i++)
{
    int.TryParse(Console.ReadLine(), out int num);
    numbers.Add(num, i);
}
// numbers.OrderBy(item => item.Key).ToDictionary(x => x.Key, x => x.Value);
List<int> list = numbers.Keys.ToList();
list.Sort();
list.Reverse();

foreach (int num in list)
{
    answer.Add(num, numbers[num]);
}
Console.WriteLine(answer.First().Key);
Console.WriteLine(answer.First().Value + 1);