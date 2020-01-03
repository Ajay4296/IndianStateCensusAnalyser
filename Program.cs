using System;

namespace AlgorithmProgram
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("1 for vending ");
            Console.WriteLine("2 for calender");
            Console.WriteLine("3 for temperature conversion");
            Console.WriteLine("4 for monthly payment");
            Console.WriteLine("5 for binary search string");
            Console.WriteLine("6 for triplet");
            Console.WriteLine("7 for sqrt of non negative number");
            Console.WriteLine("8 for stopwatch");
            Console.WriteLine("9 for prime range");
            Console.WriteLine("10 for swap nibbles");
            Console.WriteLine("11 for insertion sort");
            Console.WriteLine("12 for factorial");
            Console.WriteLine("13 for roll dice");

            Console.WriteLine("enter the choice");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Vending obj = new Vending();
                    obj.ismachine(5357);
                    break;
                case 2:
                    DayofWeeks obj1= new DayofWeeks();
                    obj1.Calender();
                    break;
                case 3:
                    Temperature obj2 = new Temperature();
                    obj2.conversiom();
                    break;
                case 4:
                    MonthlyPayment obj3 = new MonthlyPayment();
                    obj3.Calculate();
                    break;
                case 5:
                    string[] s = { "abhishek", "ankit", "arvind", "meet", "sandeep", "ayush" };
                    string x = "ankit";
                    BinarySearchString obj4 = new BinarySearchString();
                    int result = obj4.search(s, x);
                    if (result == -1)
                    {
                        Console.WriteLine("element not found");
                    }
                    else
                    {
                        Console.WriteLine("element found");
                    }
                    break;
                case 6:
                    sumofthree obj5 = new sumofthree();
                    obj5.iszero();
                    break;
                case 7:
                    Sqrt obj6 = new Sqrt();
                    obj6.isSqrt();
                    break;
              
                 
                    break;
                case 9:
                    Primerange obj8 = new Primerange();
                    obj8.isprime();
                    break;
                case 10:
                    Console.WriteLine("enter the number to convert");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Swapnibbles.isSwap(n));
                    break;
                case 11:
                    int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
                    Console.WriteLine("\nOriginal Array Elements :");
                    InsertionSort.inputArray(numbers);
                    Console.WriteLine("\nSorted Array Elements :");
                    InsertionSort.sorting(numbers);
                    Console.WriteLine("\n");
                    break;
                case 12:
                    Factorial obj9 = new Factorial();
                    obj9.isfactorial();
                    break;
                case 13:
                    Rolldie obj10 = new Rolldie();
                    obj10.Dice();
                    break;
            }
        }
    }
}
