using System;

namespace Speed_Coding
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();
            int minValue = -3;
            int maxValue = 3;
            int highestNumber = minValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minValue, maxValue);
                Console.WriteLine(numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (highestNumber < numbers[i])
                {
                    highestNumber = Math.Abs(numbers[i]);
                    //Console.WriteLine($"Neueste höchste Zahl : {highestNumber}");
                }
                if(numbers[i]<=0&&Math.Abs(numbers[i])==highestNumber)
                {
                    highestNumber = Math.Abs(numbers[i]);
                    Console.WriteLine($"Höchste Zahl : {highestNumber}\n" +
                        $"Die Zahl was Negativ, hatte aber den selben Betrag wie die\n" +
                        $"aktuelle höchste bekannte Zahl");
                    if(highestNumber==(maxValue-1))
                    {
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
