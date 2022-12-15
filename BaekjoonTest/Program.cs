using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Program
{

    public static void Main()
    {



        //입력

        //첫째 줄에는 영수증에 적힌 총 금액 X가 주어진다. Ex) 25000
        string[] intputPrice = Console.ReadLine().Split();
        int X = int.Parse(intputPrice[0]); // 영수증에 적힌 총 금액 
                                           // 
                                           // 둘째 줄에는 영수증에 적힌 구매한 물건의 종류의 수 N이 주어진다.   
        string[] intputtypeNum = Console.ReadLine().Split();
        int N = int.Parse(intputtypeNum[0]); // 영수증에 적힌 구매한 물건의 종류의 수 Ex ) 5
                                             // 종류의 수 라는 것은 반복 하는 수 와 마찬가지이다.

        int result = 0; // 모든 금액 x 개수 = 결과를 담아줄 변수이다.
        int result1 = 0; // 대리로 담길 결과



        // 1. 제한을 먼저 걸어준다.        
        if (1 <= X && X <= 1000000000)
        {
            if (1 <= N && N <= 100)
            {
                // 2. 제한에 걸리지 않고 입력에 성공했다면.
                // 3. 물건의 가격과 개수를 입력을 해야한다.
                // 4. 그 전에 물건의 종류의 개수 만큼 입력을 해야 하기 때문애
                // 5. 종류의 개수 만큼 반복해준다.

                for (int i = 0; i < N; i++) // N 이 5라면 5번 반복 즉 종류 5개를 더하기 위해 반복한다.
                {
                    string[] inputPrice = Console.ReadLine().Split(); // A 가격과 B 종류 개수를 입력받을 문자열
                    int A = int.Parse(inputPrice[0]); // 20000
                    int B = int.Parse(inputPrice[1]); // 5

                    if (1 <= A && A <= 1000000) // A 의 제한
                    {
                        if (1 <= B && B <= 10) // B 의 제한
                        {
                            // 한번 돌아갈 때 마다 A * B 하여 result 에 담는다.
                            result1 = A * B;
                            result += result1;
                        }
                    }

                }

                    // 계산한 총 금액이 영수증에 적힌 총 금액과 일치하면 Yes를 출력한다.
                    // 일치하지 않는다면 No를 출력한다.
                    if (result == X) // 
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                
            }
        }
    }
}