using System;


namespace Even_numbers_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 50; i++)
            {

                if (IsEven(i))
                    Console.WriteLine(i);


            }


            Console.ReadLine();
           
            
        }

        private static bool IsEven(int i)
        {
            return i % 2 == 0;
        }


    }
}
