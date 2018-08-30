using System;


namespace Even_numbers_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // wanted my range of integers to be 0 to 50, so i is less than or equal to 50
            for (int i = 0; i <= 50; i++)
            {
                if (IsEven(i))
                    Console.WriteLine(i);
            }


            Console.ReadLine();
           
            
        }

        private static bool IsEven(int i)
        {
            //returns true if integer is divisible by 2
            return i % 2 == 0;
        }


    }
}
