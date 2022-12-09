using System;

public class Program
{

    public static void Main()
    {
        // 첫째 줄에 연도가 주어진다. 연도는 1보다 크거나 같고, 4000보다 작거나 같은 자연수이다.

        int Year = int.Parse(Console.ReadLine());

        if ( Year >= 1 || Year <= 4000) 

        // 첫째 줄에 윤년이면 1, 아니면 0을 출력한다.
        // What is 윤년?
        // 윤년은 연도가 4의 배수이면서, 100의 배수가 아닐 때 또는 400의 배수일 때이다.

        // if 윤년인지 아닌지 판단문

        if( Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0 )
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }

    }
}