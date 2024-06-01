using System;
using System.Collections;


public static class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("enter string: ");
        string str = Console.ReadLine();
        var reversedStr = "";

        Stack myStack = new Stack();
        foreach (char chr in str)
        {
            myStack.Push(chr);
        }

        while (myStack.Count > 0)
        {
            reversedStr += myStack.Pop();
        }
        Console.WriteLine(reversedStr);



        //myStack.Push(1);
        //myStack.Push("salam");
        //myStack.Push(true);

    }
}