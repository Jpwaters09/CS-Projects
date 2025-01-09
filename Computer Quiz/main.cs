////////////////////////////////////////////////
// Computer Quiz                              //
// Language: C#                               //
// Author: Jacob Waters                       //
// Github: github.com/jpwaters09              //
// Copyright (c) 2025 Jacob Waters            //
// Contact me: jpwaters.github@gmail.com      //
////////////////////////////////////////////////

using System;
using System.Threading;

namespace ComputerQuiz
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Computer Quiz:");
            Thread.Sleep(2000);
            Console.Clear();

            Console.Write("Press enter To Start: ");
            Console.ReadLine();
            Console.Clear();

            int score = 0;
            string answer;

            Console.WriteLine("Question 1!");
            Thread.Sleep(4000);
            Console.Clear();

            Console.Write("What Does CPU Stand For? ");
            answer = Console.ReadLine();

            if (answer.ToLower() == "central processing unit")
            {
                score++;
                Console.Clear();
                Console.WriteLine("Correct!");
                Console.WriteLine($"\nYou Have Got {score}/4 Questions Correct So Far!");
                Console.WriteLine($"\nYou Have Got {(((double)score) / 4) * 100}% Correct So Far!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect!");
                Console.WriteLine($"\nYou Have Got {score}/4 Questions Correct So Far!");
                Console.WriteLine($"\nYou Have Got {(((double)score) / 4) * 100}% Correct So Far!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            Console.WriteLine("Question 2!");
            Thread.Sleep(4000);
            Console.Clear();

            Console.Write("What Does GPU Stand For? ");
            answer = Console.ReadLine();

            if (answer.ToLower() == "graphics processing unit")
            {
                score++;
                Console.Clear();
                Console.WriteLine("Correct!");
                Console.WriteLine($"\nYou Have Got {score}/4 Questions Correct So Far!");
                Console.WriteLine($"\nYou Have Got {(((double)score) / 4) * 100}% Correct So Far!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect!");
                Console.WriteLine($"\nYou Have Got {score}/4 Questions Correct So Far!");
                Console.WriteLine($"\nYou Have Got {(((double)score) / 4) * 100}% Correct So Far!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            Console.WriteLine("Question 3!");
            Thread.Sleep(4000);
            Console.Clear();

            Console.Write("What Does RAM Stand For? ");
            answer = Console.ReadLine();

            if (answer.ToLower() == "random access memory")
            {
                score++;
                Console.Clear();
                Console.WriteLine("Correct!");
                Console.WriteLine($"\nYou Have Got {score}/4 Questions Correct So Far!");
                Console.WriteLine($"\nYou Have Got {(((double)score) / 4) * 100}% Correct So Far!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect!");
                Console.WriteLine($"\nYou Have Got {score}/4 Questions Correct So Far!");
                Console.WriteLine($"\nYou Have Got {(((double)score) / 4) * 100}% Correct So Far!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            Console.WriteLine("Question 4!");
            Thread.Sleep(4000);
            Console.Clear();

            Console.Write("What Does PSU Stand For? ");
            answer = Console.ReadLine();

            if (answer.ToLower() == "power supply unit")
            {
                score++;
                Console.Clear();
                Console.WriteLine("Correct!");
                Console.WriteLine($"\nYou Have Got {score}/4 Questions Correct So Far!");
                Console.WriteLine($"\nYou Have Got {(((double)score) / 4) * 100}% Correct So Far!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect!");
                Console.WriteLine($"\nYou Have Got {score}/4 Questions Correct So Far!");
                Console.WriteLine($"\nYou Have Got {(((double)score) / 4) * 100}% Correct So Far!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            Console.WriteLine("End Of Computer Quiz!");
            Thread.Sleep(4000);

            Console.WriteLine($"\nYou Have Got {score}/4 Questions Correct!");
            Thread.Sleep(1000);
            Console.WriteLine($"\nYou Have Got {(((double)score) / 4) * 100}% Correct!");
            Thread.Sleep(2000);

            if (score == 4)
            {
                Console.Clear();
                Console.WriteLine("You Have Got 100%");
                Thread.Sleep(1000);
                Console.WriteLine("\nYou Won!");
                Thread.Sleep(2000);
                Console.Clear();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Please Try The Computer Quiz Again!");
                Thread.Sleep(1000);
                Console.WriteLine("\nYou Lost!");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
