using System;

namespace MethodsExercise
{
    public class Program

    {
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
          
        }
        public static int Subtract(int num1, int num2)
        {
            int answer = num1 - num2;
            return answer; 
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }


        public static int Division(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {

            int result = Add(2, 6);
            Console.WriteLine($"The value is {result}");

            int result2 = Subtract(6 , 1);
            Console.WriteLine($"my answer is {result2}");

            int result3 = Multiply(6 , 2);
            Console.WriteLine($"My result is {result3}");

            int result4 = Division(72, 3);
            Console.WriteLine($"The value is {result4}");


            Console.WriteLine("What is your name?"); 
            string name = Console.ReadLine(); 

            Console.WriteLine("What is your favourite colour");
            string favColour = Console.ReadLine() ;

            Console.WriteLine("what is your favourite animal");
            string favAnimal = Console.ReadLine() ;

            // Display the collected information to the user

            Console.WriteLine($"Hello, {name}! Your favorite color is {favColour}, and your favorite animal is {favAnimal}.");
    
       }
    
       
    
    
    }
}


 
