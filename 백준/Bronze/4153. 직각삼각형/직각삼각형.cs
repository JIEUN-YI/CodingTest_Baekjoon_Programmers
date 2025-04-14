int[] numbers;
do
{
    string read = Console.ReadLine();
    string[] nums = read.Split(" ");
    numbers = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        int.TryParse(nums[i], out numbers[i]);
    }

    Array.Sort(numbers);
    if (numbers[0] == 0 && numbers[1] == 0 && numbers[2] == 0)
    {
        return;
    }
    else if ((numbers[2] * numbers[2]) == (numbers[0] * numbers[0]) + (numbers[1] * numbers[1]))
    {
        Console.WriteLine("right");
    }
    else
    {
        Console.WriteLine("wrong");
    }
} while (numbers[0] != 0 && numbers[1] != 0 && numbers[2] != 0);