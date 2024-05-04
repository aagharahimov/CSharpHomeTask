

public static class Program
{

    public static void Main(string[] args)
    {
        PrintMultiplication(5, 6);
        PrintSquare(4);
        SumofArray(new int[] { 4, 5, 6, 7, 8 });
        PrintWelcome("Agasi", "Agarahimov");
        ReverseString("Agasi");
        DivisiblebySeven(4);
        ReturnSpaceCount("Bu Cumlede 5 eded boshluq var.");
        Perimeter(5);
        Perimeter(8, 3, 7);
        
    }

    public static void PrintMultiplication(int num1, int num2)
    {

        Console.WriteLine($"1. hasil={num1 * num2} ");
    }

    public static void PrintSquare(int num)
    {
        Console.WriteLine($"2. {num} ededinin kvadrati = {num * num}");
    }

    public static void SumofArray(int[] array)
    {
        int sum = 0;
        foreach (int i in array)
        {
            sum += i;
        }
        Console.WriteLine($"3. arraydaki ededlerin cemi {sum}");
    }

    public static void PrintWelcome(string name, string surname)
    {
        Console.WriteLine($"4.  Welcome {name} {surname}");
    }

    public static void ReverseString(string str)
    {
        string reversed_str = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed_str += str[i];
        };
        Console.WriteLine($"5.  verilen string = {str}, reversed string {reversed_str}");
    }

    public static void DivisiblebySeven(int num)
    {
        if (num % 7 == 0)
        {
            Console.WriteLine($"6. {num} 7e bolunur");
        }
        else
        {
            if ((num % 7) < 4)
            {
                for (int i = num; i >= 0; i--)
                {
                    if ((i % 7) == 0)
                    {
                        Console.WriteLine($"6.  edede en yaxin yeddiye bolunen eded {i}");
                        break;
                    }
                    
                    else
                        continue;
                }
            }
            else if ((num % 7) > 3)
            {
                for (int i = num; i <= num + 6; i++)
                {
                    if ((i % 7) == 0)
                    {
                        Console.WriteLine($"6.    edede en yaxin yeddiye bolunen eded {i}");
                        break;
                    }
                    else
                        continue;
                }
            }


        }


    }


    public static void ReturnSpaceCount(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == ' ') 
            { 
                count++;
            }

        }
        Console.WriteLine($"8. {str} cumlesinde {count} sayda boshluq var.");
    }

    public static void Perimeter(int sideLength)
    {
        int perimeter;
        perimeter = 4 * sideLength;
        Console.WriteLine($"7.  terefi {sideLength} olan kvadratin perimetri = {perimeter}");
    }

    public static void Perimeter(int side1, int side2, int side3)
    {
        int perimeter;
        perimeter = side1 + side2 + side3;
        Console.WriteLine($"7.  terefi {side1}, {side2}, {side3} olan trianglein perimetri {perimeter} dir");
    }
}


