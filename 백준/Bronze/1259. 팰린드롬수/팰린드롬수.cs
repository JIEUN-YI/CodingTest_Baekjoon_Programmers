            bool isCheck = false;
            int answer;
            do
            {
                int.TryParse(Console.ReadLine(), out answer);
                if (answer == 0)
                {
                    return;
                }
                int num = answer;
                List<int> list = new List<int>();
                for (int i = 0; num > 0; i++)
                {
                    int result = num % 10;
                    num /= 10;
                    list.Add(result);
                }
                int[] compare = list.ToArray(); // 비교할 원래 숫자의 역순 배열
                int[] normal = new int[compare.Length]; // 원래의 숫자 순서 배열
                for (int i = 0; i < compare.Length; i++)
                {
                    normal[compare.Length - 1 - i] = compare[i];
                }
                // 각 배열의 숫자를 비교
                for (int i = 0; i < normal.Length; i++)
                {
                    if (compare[i] != normal[i])
                    {
                        isCheck = false;
                        break;
                    }
                    else
                    {
                        isCheck = true;
                    }
                }
                if (isCheck)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            } while (answer !=0);