using System;

namespace Speed_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i+1;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if(((numbers[i] % 3) == 0)&&((numbers[i] % 5)==0))
                {
                    numbers[i] = 12121;
                }
                else if((numbers[i] % 3) == 0)
                {
                    numbers[i] = 22222;
                }
                else if((numbers[i] % 5) == 0)
                {
                    numbers[i] = 11111;
                }

                Console.WriteLine(numbers[i]);
            }
        }
    }
}
