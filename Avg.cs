namespace MyAvgLib
{
    public class Avg
    {
        public static double Average(double a, double b)
        {
            double average;
            average = (a + b) / 2;
            return average;
        }

        public static double Average(double a, double b, double c)
        {
            double average;
            average = (a + b + c) / 3;
            return average;
        }
    }
}