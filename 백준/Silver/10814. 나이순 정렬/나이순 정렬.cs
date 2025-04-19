namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int count);
            Member[] members = new Member[count];
            int index = 0;
            while(count > 0)
            {
                string[] answer = Console.ReadLine().Split(" ");
                int.TryParse(answer[0], out int age);
                Member member = new Member(index, age, answer[1]);
                members[index] = member;
                index++;
                count--;
            }
            Array.Sort(members, (a, b) =>
            {
                if (a.age > b.age)
                {
                    return 1;
                }
                else if (a.age < b.age)
                {
                    return -1;
                }
                else
                {
                    if (a.index < b.index)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
            });
            foreach (Member member in members)
            {
                 Console.WriteLine(member.age + " " + member.name);
            }
        }
        class Member
        {
            public int index;
            public int age;
            public string name;
            public Member( int index, int age, string name)
            {
                this.index = index;
                this.age = age;
                this.name = name;
            }
        }
    }
}
