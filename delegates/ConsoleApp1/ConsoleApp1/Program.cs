namespace Delegates
{
    public static class Program
    {
        
        delegate bool Check<T>(T item);
        public static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, -4, -8, -10 };

            
            Console.WriteLine(Sum(array, IsNegative));

            Check<string> checkStr = CheckLengthBiggerThan;
            Console.WriteLine(checkStr.Invoke("salam")); 

        }

        static int Sum(int[] array, Check<int> check)
        {
            int sum = 0;

            foreach (var arrayItem in array)
            {
                if (check(arrayItem))
                {
                    sum += arrayItem;
                }

            }
            return sum;
        }


        public static bool IsOdd(int number)
        {
            return (number % 2 != 0);
        }

        public static bool IsEven(int number)
        {
            return (number % 2 == 0);
        }

        public static bool IsNegative(int number)
        {
            return (number <0);
        }

        public static bool CheckLengthBiggerThan(string word)
        {
            return (word.Length < 5);
        }
    }
}