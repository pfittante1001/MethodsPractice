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

            int value = ParseCheck("test");
            Console.WriteLine("This is a valid number {0}",value);
            //Console.WriteLine("The user will retire in {0} years where {1} represents the value calculate.", retireYears, age);
        }

        public static int ParseCheck(string randomStr)
        {
           
            int tempInt;
            while (int.TryParse(randomStr,out tempInt)== false)
            {
                Console.WriteLine("Please enter a valid number");
                randomStr = Console.ReadLine();
            }
            return tempInt;
        }
        public static void FavoriteFood( string name, string food)
        {
            Console.WriteLine("{0} favorite food is {1} ", name, food);
        }

        public static int RetirementCalc(int userAge)
        {
            int years;
            switch (userAge)
            {
                case 1:
                    years = 2;
                    break;
                case 2:
                    years = 2;
                    break;
                default:
                    years = 50;
                    break;            
                    
            }

            return years;
        }
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

       
    }




}
