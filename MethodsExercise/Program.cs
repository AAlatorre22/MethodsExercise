using System.ComponentModel;
using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1

            //StoryTime();

            //Ecercise 2

            Add();

            Multiply();

            Divide();


             
         
        }

     //Start of Exercise 1
        public static void StoryTime()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite candy bar?");
            string candy = Console.ReadLine();

            Console.WriteLine("Write an adjective");
            string adj = Console.ReadLine();

            Console.WriteLine("Write a second adjective");
            string adj2 = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite place to visit?");
            string place = Console.ReadLine();

            Console.WriteLine("What is your least favorite emotion?");
            string emot = Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            double num = Double.Parse(Console.ReadLine());


            string story = $"Hello, my name is {name}. I am very excited to tell you about this time that I ate {num} {candy} bars! " +
                $"I had such a craving for some {candy} bars that I got into my {adj} {color} car and drove all the way to {place} to buy some! " +
                $"It wasn't until I ate all the {candy} bars that I realized I made a {adj2} mistake and spent the rest of the day feeling {emot}.";

            Console.WriteLine(story);

        }
                      
        //Start of Exercise 2
           public static void Add()
        {
            Console.WriteLine("We are going to add two numbers together! Please input the first number to add.");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input the second number to add.");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double sum = firstNum + secondNum;
            Console.WriteLine($"Your answer is {sum}!");
            //Console.WriteLine(sum);
        }

        public static void Multiply()
        {
            Console.WriteLine();
            Console.WriteLine("Now we will do some multiplication! Please input first number to multiply.");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input second number to multiply.");
            double secondNum = Double.Parse(Console.ReadLine());

            Console.WriteLine();

            double product = firstNum * secondNum;

            Console.WriteLine($"Your answer is {product}!");
        }

        public static void Divide()
        {
            Console.WriteLine();
            Console.WriteLine("Lastly we will do some division! Please input dividend.");
            double firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input divisor.");
            double secondNum = double.Parse(Console.ReadLine());
            
            double division = firstNum / secondNum;

            Console.WriteLine($"Your answer is {division}!");
        }
        



    }
}
