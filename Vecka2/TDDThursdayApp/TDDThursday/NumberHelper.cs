namespace TDDThursday
{
    // See https://aka.ms/new-console-template for more information
    public static class NumberHelper
    {
        public static int[] HighAndLow(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return new int[] { 0, 0 };
            else if (numbers.Length == 1) return new int[] { numbers[0], numbers[0] };

            var high = numbers[0];
            var low = numbers[0];
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > high) high = numbers[i];
                else if (numbers[i] < low) low = numbers[i];
            }
            return new int[] { low, high };
        }

        public static int[] MoveTheZeroes(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return new int[] { 0 };
            else if (numbers.Length == 1) return numbers;

            var loopLength = numbers.Length - 1;
            for (var i = 0; i <= loopLength; i++)
            {
                if (numbers[i] == 0)
                {
                    for (int j = i; j <= loopLength - 1; j++)
                    {
                        numbers[j] = numbers[j + 1];
                    }
                    numbers[loopLength] = 0;
                    loopLength--;
                }
            }
            return numbers;
        }

        public static int OddNumber(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return -1;

            List<int> checkedNumbers = new();

            for (int i = 0; i < numbers.Length; i++)
            {
                var count = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (checkedNumbers.Contains(numbers[i])) break;
                    if (numbers[j] == numbers[i]) count++;
                }
                if(!checkedNumbers.Contains(numbers[i])) checkedNumbers.Add(numbers[i]);
                if (count % 2 == 1) return numbers[i];
            }
            return -1;
        }
    }
}