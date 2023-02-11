namespace Iterative_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer value between 1 and 100..");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the series name: 1 for odd, 2 for even.");
                int series = Convert.ToInt32(Console.ReadLine());

                if (series == 1)
                {
                    //odd
                    Console.WriteLine($"You have selected the odd series. The numvers between {0} and {num} are");
                    PrintOddNum(num);
                }

                else if (series == 2)
                {
                    //even
                    Console.WriteLine($"You have selected the even series. The numvers between {0} and {num} are");
                    PrintEvenNum(num);
                }

                else
                {
                    Console.WriteLine("Invalid choice.!");
                }


                Console.ReadLine();
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }


            static void PrintOddNum(int uLimit)
            {
                //while , do while, for , foreach
                // 0-15, 

                int num = uLimit;

                int i = 0;
                while (i <= num)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
            }

            static void PrintEvenNum(int uLimit)
            {
                int num = uLimit;

                int i = 0;
                while (i <= num)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                    i++;
                }
            }
        }
    }
}