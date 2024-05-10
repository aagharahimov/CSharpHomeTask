public static class Program
{
    public static void Main(string[] args)
    {

        //1.
        Console.WriteLine("task1:");
        Animal animal1 = new Animal();
        Animal animal2 = new Animal("shir", "pishik", "qizili", 5);
        animal1.GetDetails();
        animal2.GetDetails();
        Console.WriteLine();


        //2.
        Console.WriteLine("task2:");
        Building building1 = new Building("bina", 3, 8, "axundov 35");
        building1.GetVolume();
        Console.WriteLine();


        //3.
        Console.WriteLine("task3:");
        Student student1 = new Student("Agasi", "Agarahimov", 18, new int[] { 34, 78, 12, 98, 34 }, new int[] { 50, 80, 99 }, new int[] { 40, 80, 90, 99 }, 100, new bool[] { true, true, true, false, true });
        student1.CalculateGPA();
        Console.WriteLine();

        //4.
        Console.WriteLine("task4:");
        Gun assaultGun = new Gun("AK47", 30, 30, 90, "assault");
        assaultGun.Fire();
        assaultGun.GetGunState();

        Gun sniperGun = new Gun("AWP", 5, 3, 20, "sniper");
        sniperGun.Fire();
        sniperGun.GetGunState();

        sniperGun.Reload();
        sniperGun.GetGunState();
        Console.WriteLine();


        //5.
        Console.WriteLine("task5:");
        Calculator calculator = new Calculator();

        double num1, num2;
        char operation;

        Console.WriteLine("Enter the first number: ");
        while (!calculator.TryParseInput(Console.ReadLine(), out num1)) { }

        Console.WriteLine("Enter the second number: ");
        while (!calculator.TryParseInput(Console.ReadLine(), out num2)) { }

        Console.WriteLine("Enter the operation (+, -, *, /):");
        while (!calculator.TryParseOperation(Console.ReadLine(), out operation)) { }

        calculator.SetNum1(num1);
        calculator.SetNum2(num2);
        calculator.SetOperation(operation);

        calculator.PerformCalculation();
        

    }

    public class Animal
    {
        public string Name;
        public string Breed;
        public string Color;
        public int Age;


        public Animal()
        {

        }

        public Animal(string name, string breed, string color, int age) : this()
        {
            Name = name;
            Breed = breed;
            Color = color;
            Age = age;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Breed: {Breed}, Color: {Color}, Age: {Age}");
        }


    }

    public class Building
    {
        public string Name;
        public int Height;
        public int Area;
        public string Adress;
        public int Volume;

        public Building(string name, int height, int area, string adress)
        {
            Name = name;
            Height = height;
            Area = area;
            Adress = adress;
        }

        public void GetVolume()
        {
            Volume = Area * Height;
            Console.WriteLine($"2. Name:{Name}, Height={Height}, Area={Area}m2, Adress:{Adress}");
            Console.WriteLine($"volume is {Volume}m3");
        }
    }

    public class Student
    {
        public string Name;
        public string Surname;
        public int age;
        public int[] homeworkGrades;
        public int[] projectGrades;
        public int[] quizGrades;
        public int FinalGrade;
        public bool[] continuity;
        public double GPA;

        public Student(string name, string surname, int age, int[] homeworkGrades, int[] projectGrades, int[] quizGrades, int finalGrade, bool[] continuity)
        {
            Name = name;
            Surname = surname;
            this.age = age;
            this.homeworkGrades = homeworkGrades;
            this.projectGrades = projectGrades;
            this.quizGrades = quizGrades;
            FinalGrade = finalGrade;
            this.continuity = continuity;
        }

        public void CalculateGPA()
        {
            // Calculate weighted averages for each component
            double homeworkAvg = CalculateAverage(homeworkGrades) * 0.2;
            double projectAvg = CalculateAverage(projectGrades) * 0.2;
            double quizAvg = CalculateAverage(quizGrades) * 0.2;
            double newFinalGrade = FinalGrade * 0.3;
            double continuityScore = CalculateContinuityScore() * 0.1;

            // Calculate total GPA
            GPA = homeworkAvg + projectAvg + quizAvg + newFinalGrade + continuityScore;

            // Determine achievement level
            if (GPA > 95)
                Console.WriteLine("HighHonour");
            else if (GPA > 85)
                Console.WriteLine("Honor");
            else if (GPA > 65)
                Console.WriteLine("Normal");
            else
                Console.WriteLine("Fail");
        }

        private double CalculateAverage(int[] grades)
        {
            if (grades.Length == 0)
                return 0;

            double sum = 0;
            foreach (int grade in grades)
            {
                sum += grade;
            }
            return sum / grades.Length;
        }

        private double CalculateContinuityScore()
        {
            int continuityCount = 0;
            foreach (bool isContinuous in continuity)
            {
                if (isContinuous)
                    continuityCount++;
            }
            return (double)continuityCount / continuity.Length;
        }
    }

    public class Gun
    {
        public string Name;
        public int MaxCapacity;
        public int CurrentBullet;
        public int TotalBullet;
        public string Type;

        public Gun(string name, int maxCapacity, int currentBullet, int totalBullet, string type)
        {
            Name = name;
            MaxCapacity = maxCapacity;

            if (currentBullet > maxCapacity)
            {
                Console.WriteLine("Current bullet max capacity den cox ola bilmez");
                CurrentBullet = maxCapacity;
            }
            else
            {
                CurrentBullet = currentBullet;
            }

            TotalBullet = totalBullet;
            Type = type;
        }

        public void Fire()
        {
            if (Type == "assault")
            {
                Console.WriteLine("Butun bulletler atilir.");
                CurrentBullet = 0;
            }
            else if (Type == "sniper")
            {
                if (CurrentBullet > 0)
                {
                    Console.WriteLine("bir gulle atilir.");
                    CurrentBullet--;
                }
                else
                {
                    Console.WriteLine("gulle bitdi.");
                }
            }
        }

        public void Reload()
        {
            int bulletsToReload = MaxCapacity - CurrentBullet;
            if (bulletsToReload > TotalBullet)
            {
                Console.WriteLine("tam reload olunamayacag.");
                bulletsToReload = TotalBullet;
            }
            CurrentBullet += bulletsToReload;
            TotalBullet -= bulletsToReload;
            Console.WriteLine("reload olundu.");
        }

        public void GetGunState()
        {
            Console.WriteLine($"Name: {Name}, Current Bullet: {CurrentBullet}, Remaining Total Bullet: {TotalBullet}, Type: {Type}"); 
        }
    }

    public class Calculator
    {
        public double num1;
        public double num2;
        public char operation;

        public void SetNum1(double num1)
        {
            this.num1 = num1;
        }

        public void SetNum2(double num2)
        {
            this.num2 = num2;
        }

        public void SetOperation(char operation)
        {
            this.operation = operation;
        }

        public void PerformCalculation()
        {
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: 0a bolme yoxdur.");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }

        public bool TryParseInput(string input, out double result)
        {
            if (double.TryParse(input, out result))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
                return false;
            }
        }

        public bool TryParseOperation(string input, out char result)
        {
            if (char.TryParse(input, out result))
            {
                if (result == '+' || result == '-' || result == '*' || result == '/')
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid operation (+, -, *, /):");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid operation (+, -, *, /):");
                return false;
            }
        }
    }
}

