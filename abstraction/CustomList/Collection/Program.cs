using System.Collections;
using System.Globalization;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    ArrayList arrList = new ArrayList();
        //    arrList.Add(1);
        //    arrList.Add("Salam");
        //    arrList.Add(true);

        //    foreach (var arrItem in arrList)
        //    {
        //        Console.WriteLine(arrItem);
        //    }

        //    SortedList sortedList = new SortedList();

        //    sortedList.Add("Name", "Monday");
        //    sortedList.Add("name", "Wednesday");
        //    sortedList.Add("NName", "Tuesday");

        //    foreach (var key in sortedList.Keys)
        //    {
        //        Console.WriteLine(key);
        //    }

            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push("Salam");
            //stack.Push(true);

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());


            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("salam");
            //queue.Enqueue(true);

            
            //Console.WriteLine(queue.Peek());

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //}


            //List<int> numbers = new List<int>();
            //numbers.Add();


            //Dictionary<int, StatusCode> myDictionary = new Dictionary<int, StatusCode>();
            //myDictionary.Add(401, StatusCode.Unathoriazed);
            //myDictionary.Add(404, StatusCode.NotFound);
            //myDictionary.Add(405, StatusCode.Success);

            //Console.WriteLine(myDictionary[401]);



            //HashSet<int> myCollection = new HashSet<int>();
            //myCollection.Add(1);
            //myCollection.Add(2);
            //myCollection.Add(2);

            //Console.WriteLine( "count: "+  myCollection.Count);

            //foreach (int i in myCollection)
            //{
            //    Console.WriteLine(i);
            //}



            //Stack<int> stack = new Stack<int> ();
            //stack.Push (1); 
            //stack.Push (2);


           CustomList<int> numbers = new CustomList<int>();

        }
    }

    enum StatusCode
    {
        Unathoriazed,
        NotFound,
        Success
    }
}