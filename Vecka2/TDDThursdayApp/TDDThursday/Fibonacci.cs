namespace TDDThursday
{
    // See https://aka.ms/new-console-template for more information
    public static class Fibonacci
    {
        public static int FibonacciSum(int goal)
        {
            if (goal <= 0) return 0;

            int first = 2, second = 3;
            for (var i = 1; i < goal; i++)
            {
                var next = first+second;
                first = second;
                second = next;
            }
            return second;
        }
    }
}