public static class Program
{
    public static void Main(string[] args)
    {
        CustomList<int> numbers = new CustomList<int>();

        for (int i = 0; i < 10; i++)
        {
            numbers.Add(i);
        }

        numbers.GetAll();
        Console.WriteLine(numbers.Contains(2));
        numbers.Remove(2);
        Console.WriteLine(numbers.Contains(2));
        Console.WriteLine(numbers.Any());
        Console.WriteLine(numbers.FirstOrDefault());
        Console.WriteLine(numbers.ElementAtOrDefault(5));
        numbers.Clear();
        Console.WriteLine(numbers.Any());

    }
}
