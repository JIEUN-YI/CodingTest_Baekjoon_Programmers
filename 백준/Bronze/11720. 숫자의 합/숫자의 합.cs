int.TryParse(Console.ReadLine(), out int count);
string numbers = Console.ReadLine();
char[] numberArr = numbers.ToCharArray();
if (numberArr.Length > count)
{
    return;
}
int sum = 0;
foreach(char c in numberArr)
{
    int.TryParse(c.ToString(), out int num);
    sum += num;
}
Console.WriteLine(sum);