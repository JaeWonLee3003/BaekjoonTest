using System;
using System.Collections.Generic;

public class Program
{

    public static void Main()
    {
        // if 모두 같은 눈이 나오는 경우에는 10,000원+(같은 눈)×1,000원의 상금을 받게 된다. 
        // else 모두 다른 눈이 나오는 경우에는(그 중 가장 큰 눈)×100원의 상금을 받게 된다.  

        // 같은 눈이 2개만 나오는 경우에는 1,000원 + (같은 눈)×100원의 상금을 받게 된다. 

        // 예제 입력            예제 출력
        // 3 3 6                1300
        // 2 2 2                12000
        // 6 2 5                600



        string[] inputDice = Console.ReadLine().Split();

        int A = int.Parse(inputDice[0]);
        int B = int.Parse(inputDice[1]);

        while(0 < A && 0 < B)
        {
            Console.WriteLine(A+B);
            return;
        }

    }
}