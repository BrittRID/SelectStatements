using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            //int favNumber = 7;
            //Console.WriteLine("Guess my favorite number. Hint: Below 10");
            //int userguess = int.Parse(Console.ReadLine());

            // if (userguess < favNumber)
            //{
            //   Console.WriteLine("TOO LOW!");
            //}
            // else if (userguess > favNumber)
            // {
            //      Console.WriteLine("TOO HIGH");
            // }
            // else if (userguess == favNumber)
            //{
            //    Console.WriteLine("You were correct here is a prize");
            //}
            // else
            // {
            //    Console.WriteLine("Nevermind");
            // }
            string subject = "c#";
            Console.WriteLine("Choose a subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {

                case "c#":
                    Console.WriteLine("You are in the right class");
                    break;
                case "Jave":
                    Console.WriteLine("c# is better than jave");
                    break;

                default:
                    Console.WriteLine("What is the game plan sister!!!!");
                    break;





            }


        }
    }
}
