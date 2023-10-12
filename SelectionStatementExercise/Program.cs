﻿using System;

namespace SelectionStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Number Guessing Game 
            var r = new Random();
            var favNumber = r.Next(1 , 1000);
            int userInput;

            do
            {
                Console.WriteLine("Pick a number from 1- 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (favNumber != userInput);
        }
    }
}
