using System;

namespace task_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_serv = 6;
            int sum = 0;
            float sum_n = 0;
            int[] arr_serv = new int[]{5, 1, 6, 2, 4};
            for (int i = 0; i < (n_serv - 1); i++) {
                sum += arr_serv[i];
            }
            sum_n = n_serv * (n_serv + 1) / 2;
            Console.WriteLine(sum_n - sum);

            Console.ReadKey();
            
        }
    }
}
