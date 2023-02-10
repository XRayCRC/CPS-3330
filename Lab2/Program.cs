using Task5;

namespace TestAvg
{
    /* Lab 2 Task 5
     * Christian-Ray Conrad
     * CPS 3330 - 03
    public class Avg */
    public class TestAverage
    {
        public static void Main(string[] args)
        {
            //Get Number of Nums from user
            Console.Write("How many numbers will you provide (2 or 3)? ");
            double howMany = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a Value for 'a': ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a Value for 'b': ");
            double b = Convert.ToDouble(Console.ReadLine());

            
            if (howMany == 3)
            {
                //Get Third value if applicable
                Console.Write("Enter a Value for 'c': ");
                double c = Convert.ToDouble(Console.ReadLine());

                //Compute avg of 3 nums
                Console.WriteLine("$Provided Numbers {0}, {1}, {2}. \nThe Average is {3}", a, b, c, 
                   Task5.Avg.aver(a,b,c));
            }
            else
            {
                //Compute average of 2 nums
                Console.WriteLine("$Provided Numbers {0}, {1}. \nThe Average is {2}", a, b,
                    Task5.Avg.aver(a,b));
            }
        }
    }
}
