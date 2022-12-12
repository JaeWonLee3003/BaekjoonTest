using System;

public class Program
{

    public static void Main()
    {
        string[] Time = Console.ReadLine().Split();
        int H = int.Parse(Time[0]);
        int M = int.Parse(Time[1]);
        if (H < 0 || H > 24 || M < 0 || M > 59) return;


        if (M < 45) // 대충 시간이 0보다 작을때 23으로 해주고 분이 0보다 작을때 +60을 해주면되느데
        {
            H--;
            M += 15;
            if (H < 0)
            {
                H = 23;
            }
        }      
        else
        {
            M -= 45;
        }
        Console.WriteLine(H + " " + M);

    }
}