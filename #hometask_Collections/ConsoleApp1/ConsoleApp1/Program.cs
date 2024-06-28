using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("string daxil edin: ");
        string str = Console.ReadLine();
        Console.WriteLine(Stack.Reverse(str));
    }
}

class Stack
{
    private int top;
    private int capacity;
    private char[] array;

    public Stack(int capacity)
    {
        this.capacity = capacity;
        array = new char[capacity];
        this.top = -1;
    }

    public bool IsFull()
    {
        return this.top == this.capacity - 1;
    }

    public bool IsEmpty()
    {
        return this.top == -1;
    }

    public void Push(char value)
    {
        if (!this.IsFull())
        {
            this.array[++this.top] = value;
        }
    }

    public char Pop()
    {
        return this.IsEmpty() ? '\u0000' : this.array[this.top--];
    }

    public static string Reverse(string str)
    {
        char[] charArr = str.ToCharArray();
        int size = charArr.Length;
        Stack stack = new Stack(size);

        for (int i = 0; i < size; i++)
        {
            stack.Push(charArr[i]);
        }

        for (int i = 0; i < size; ++i)
        {
            charArr[i] = stack.Pop();
        }

        return new string(charArr);
    }
}
