namespace Tasklar_for17may
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Console.Write("n-i daxil edin:");
            //int n = int.Parse(Console.ReadLine());
            //int[] mass = new int[n];

            //for (int i = 0; i < mass.Length; i++)
            //{
            //    Console.Write($"mass[{i}]=");
            //    mass[i] = int.Parse(Console.ReadLine());
            //}
            //int min = mass[0];
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[i] < min && mass[i] % 2 == 0)
            //    {
            //        min = mass[i];
            //    }Console.WriteLine($"massivin en kicik cut elementi {min}-dir.");
            //}
            #endregion

            #region task2  
            //Console.Write("n-i daxil edin:");
            // int n = int.Parse(Console.ReadLine());
            // int[] mass = new int[n];
            // for (int i = 0; i < mass.Length; i++)
            // {
            //     Console.Write($"mass[{i}]=");
            //     mass[i] = int.Parse(Console.ReadLine());
            // }
            // int min = mass[0];
            // int max = mass[0];
            // for(int i = 0; i < mass.Length; i++)
            // {
            //     if (mass[i] < min)
            //     {
            //         min = mass[i];
            //     }
            //     if (mass[i] > max)
            //     {
            //         max = mass[i];
            //     }
            // }
            // Console.WriteLine($"min:{min} ve max:{max}");
            // int b =min;
            // min = max;
            // max = b;
            // Console.WriteLine($"Yerlerin deyisdikden sonra min:{min} ve max:{max}");
            #endregion
            Console.Write("N-i daxil edin:");
            int n = int.Parse(Console.ReadLine());
            double[] mass = new double[n];
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"mass[{i}]=");
                mass[i] = double.Parse(Console.ReadLine());
            }
            double sum = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                sum += mass[i];
                if (mass[i] == 0) break;
            }
            Console.WriteLine(sum);

        }
    }
}
 