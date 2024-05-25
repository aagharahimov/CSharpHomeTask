public static class Program
{
    public static void Main(string[] args)
    {
        string str1 = "agasi";
        string str2 = "Agarahimov";
        Swap(ref str1, ref str2);
    }

    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;

        Console.Write( a);
        Console.Write(" " + b);
    }
}