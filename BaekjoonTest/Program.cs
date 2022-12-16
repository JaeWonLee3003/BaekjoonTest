using System;
// StringBuilder를 사용하기 위해서.
using System.Text;



class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int result = 0; // 정답

        if (1 <= N && N <= 1000000)
        {
            //if( N % 3 != 0 && N % 2 != 0)
            //{
            //   N -= 1;
            //  result += 1;
            //}

            while (N % 3 != 0)
            {
                N -= 1; result++;
                while (N % 3 == 0)
                {
                    N /= 3; result++;
                    if (N == 1)
                    {
                        Console.WriteLine(result);
                        return;
                    }
                }
            }
            
        }
    }
}
