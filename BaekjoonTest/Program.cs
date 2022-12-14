using System;
using System.Collections.Generic;

public class Program
{

    public static void Main()
    {

        // 예제 입력            예제 출력
        // 14 30 [0] [1]        14 50
        // 20    [0]

        // 이렇게보면 쉽다. 현재 시각의 시는 A 분은 B 요리하는데 걸리는 시간은 C 이다.

        string[] inputTime = Console.ReadLine().Split();
        string[] inputDelay = Console.ReadLine().Split();

        int A = int.Parse(inputTime[0]); // 14
        int B = int.Parse(inputTime[1]); // 30
        int C = int.Parse(inputDelay[0]); // 20



        if (0 <= A && A <= 23)
        {
            if (0 <= B || B <= 59)
            {
                if (0 <= C || C <= 1000)
                {
                    {

                        B += C;

                        if (B > 119) // 60분 이상이면
                        {
                            A += 2; // 1시간을 추가하고
                            B -= 120; // 남은 분을 마저 더 해준다.
                        }

                        if (B > 59) // 60분 이상이면
                        {
                            A += 1; // 1시간을 추가하고
                            B -= 60; // 남은 분을 마저 더 해준다.
                        }

                        if (A > 24)
                        {
                            A = 0;
                        }

                    }
                    Console.WriteLine(A + " " + B);
                }

            }

        }

        // 전 문제와 비슷하게 B가 60이 넘으면  -60 을 해준다.
        // ex ) 50분에서 20분을 더 준다면? 10분으로 바꿔주어야함. 50+20=70-60=10








    }
}