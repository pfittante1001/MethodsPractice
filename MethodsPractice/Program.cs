using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {


        static void Main(string[] args)
        {
            //Hello();
            //World();
            //NameInput("pete");
            //Console.WriteLine(SumNum(5, 5));
            //FavoriteFood("pete", "icecream");
            //int age = 1;
            //int retireYears = RetirementCalc(age);


            //int value = ParseCheck("test");
            //Console.WriteLine("This is a valid number {0}",value);

            //Console.WriteLine("Please enter two numbers to add: ");
            //int[] sumArray = new int[2];

            //for (int i = 0; i <=1; i++)
            //{
            //    Console.Write("Please enter your number: ");
            //    sumArray[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(sumIt(sumArray[0], sumArray[1]));

            //Console.WriteLine("Home many number would you like to sum? ");
            //int numAdd = int.Parse(Console.ReadLine());
            //int[] sumArray = new int[numAdd];

            //Console.WriteLine("Please enter {0} numbers to add: ", numAdd);
            //for (int i = 0; i <sumArray.Length; i++)
            //{
            //    Console.Write("Please enter your numbers: ");
            //    sumArray[i] = int.Parse(Console.ReadLine());
            //}

            //int total = sumIt(sumArray, numAdd);
            //Console.WriteLine(total);   

            //Console.WriteLine(doubleIt(7));

            //Console.WriteLine(sumDigits(123));

            int[] maxArray = { 23, 56, 82000, 13, 96, 10000 };
            Console.WriteLine(findMax(maxArray, 6));
        }

        //public static int ParseCheck(string randomStr)
        //{

        //    int tempInt;
        //    while (int.TryParse(randomStr,out tempInt)== false)
        //    {
        //        Console.WriteLine("Please enter a valid number");
        //        randomStr = Console.ReadLine();
        //    }
        //    return tempInt;
        //}
        //public static void FavoriteFood( string name, string food)
        //{
        //    Console.WriteLine("{0} favorite food is {1} ", name, food);
        //}

        //public static int RetirementCalc(int userAge)
        //{
        //    int years;
        //    switch (userAge)
        //    {
        //        case 1:
        //            years = 2;
        //            break;
        //        case 2:
        //            years = 2;
        //            break;
        //        default:
        //            years = 50;
        //            break;            

        //    }

        //    return years;
        //}
        //Example of a void methods which doesnt return an into or double ets
        //static void Hello()
        //{
        //    Console.Write("Hello ");
        //}

        //static void World()
        //{
        //    Console.Write("World\n");
        //}

        //Example of a void method which take a string and prints that string
        //static void NameInput(string name)
        //{
        //    Console.WriteLine(name);
        //}

        //Int method that take in two int and returns an int
        //static int SumNum(int num1, int num2)
        //{
        //    int sum = num1 + num2;
        //    return sum;
        //}

        //public static int sumIt(int num1, int num2)
        //{
        //    int total = num1 + num2;

        //    return total;
        //}
         
        //public static int sumIt(int[] newArray, int size)
        //{
        //    int sum = 0;
        //   for (int i = 0; i < size; i++)
        //    {
        //       sum += newArray[i];
        //    }

        //    return sum;
        //}

        //public static int doubleIt(int num1)
        //{
        //    int total = 0;
        //    total = num1 * 2;
        //    return total;
        //}

        //public static int sumDigits(int num1)
        //{
        //    String num1Str = num1.ToString();
        //    char[] arr = num1Str.ToCharArray();
        //    int[] numArray = new int[3];
        //    string[] numStr1 = new string[3];

        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        numStr1[i] = arr[i].ToString();
        //        numArray[i] = int.Parse(numStr1[i]);
        //        sum += numArray[i];

        //    }
            
        //    return sum;
        //}

        public static int findMax(int[] arr, int size)
        {
            int temp = 0;
            for(int i = 0; i < size; i++)
            {
                   if (arr[i] > temp)
                    {
                        temp = arr[i];
                    }
                    
                }
                
                return temp;
            }
            
        

    }
}
