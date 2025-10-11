using System;
    public class Vector2
    {
        public int y;
        public int x;

        public Vector2(int y, int x)
        {
            this.y = y;
            this.x = x;
        }

    }

public class Solution {
            public bool[,] Map;
        Vector2 startPos;
        public Vector2 nowPos;

        /// <summary>
        /// 공원 그리기
        /// </summary>
        /// <param name="park"></param>
        public void DrowMap(string[] park)
        {
            Map = new bool[park.Length, park[0].Length];
            for (int y = 0; y < park.Length; y++)
            {
                string input = park[y];
                for (int x = 0; x < input.Length; x++)
                {
                    char c = input[x];
                    switch (c)
                    {
                        case 'O':
                            Map[y, x] = true;
                            break;
                        case 'X':
                            Map[y, x] = false;
                            break;
                        default:
                            Map[y, x] = true;
                            startPos = new Vector2(y, x);
                            break;
                    }
                }
            }
            nowPos = startPos;
        }

        /// <summary>
        /// 변한 Y값의 범위와 이동가능 여부를 확인
        /// </summary>
        /// <param name="nextY"></param>
        /// <returns></returns>
        public bool CheckRangeY(int nextY)
        {
            bool isChecked = false;
            if (nextY >= 0 && nextY < Map.GetLength(0)) // 범위 안에 있는가
            {
                isChecked = true;
                if (!Map[nextY, nowPos.x]) // 이동 가능 한가
                {
                    isChecked = false;
                }
            }
            return isChecked;
        }
        /// <summary>
        /// 변한 X값의 범위와 이동가능 여부를 확인
        /// </summary>
        /// <param name="nextX"></param>
        /// <returns></returns>
        public bool CheckRangeX(int nextX)
        {
            bool isChecked = false;
            if (nextX >= 0 && nextX < Map.GetLength(1))
            {
                isChecked = true;
                if (!Map[nowPos.y, nextX])
                {
                    isChecked = false;
                }
            }
            return isChecked;
        }

        public void RouteCheck(string[] order)
        {
            int.TryParse(order[1], out int count); // count = 움직일 총 횟수
            int nextX = 0;
            int nextY = 0;
            int num = 1;
            switch (order[0]) // 이동 방향
            {
                case "E":
                    while (count > 0) // 움직일 총 횟수 만큼 반복
                    {
                        nextX = nowPos.x + num;
                        if (CheckRangeX(nextX)) // 범위 체크
                        {
                            num++;
                            count--;
                        }
                        else
                        {
                            nextX = nowPos.x;
                            break;
                        }
                    }
                    nowPos.x = nextX;
                    break;
                case "W":
                    while (count > 0)
                    {
                        nextX = nowPos.x - num;
                        if (CheckRangeX(nextX))
                        {
                            num++;
                            count--;
                        }
                        else
                        {
                            nextX = nowPos.x;
                            break;
                        }
                    }
                    nowPos.x = nextX;
                    break;
                case "S":
                    while (count > 0)
                    {
                        nextY = nowPos.y + num;
                        if (CheckRangeY(nextY))
                        {
                            num++;
                            count--;
                        }
                        else
                        {
                            nextY = nowPos.y;
                            break;
                        }
                    }
                    nowPos.y = nextY;
                    break;
                case "N":
                    while (count > 0)
                    {
                        nextY = nowPos.y - num;
                        if (CheckRangeY(nextY))
                        {
                            num++;
                            count--;
                        }
                        else
                        {
                            nextY = nowPos.y;
                            break;
                        }
                    }
                    nowPos.y = nextY;
                    break;
                default:
                    break;
            }
        }
    public int[] solution(string[] park, string[] routes) {
                    DrowMap(park);
            for (int index = 0; index < routes.Length; index++)
            {
                string[] nowOrder = routes[index].Split(" ");
                RouteCheck(nowOrder);
            }
            int[] answer = new int[] { nowPos.y, nowPos.x };

            return answer;
    }
}