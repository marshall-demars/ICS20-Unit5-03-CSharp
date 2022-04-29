// Created by: Marshall Demars
// Created on: Apr 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program finds which types of movies are recommended for age
        int age;

        // input
        Console.WriteLine("This program lets you input your age");
        Console.WriteLine("");
        Console.WriteLine("The program will then tell you what types of movies you should be watching based off your age");
        Console.WriteLine("");
        Console.WriteLine("Input your age");
        age = Convert.ToInt32(Console.ReadLine());

        // process
        Console.WriteLine("");
        if (age >= 17)
        {
            Console.WriteLine("You can watch R rated movies alone!");
        }
        else if (age >= 13)
        {
            Console.WriteLine("You can watch PG-13 rated movies alone!");
        }
        else if (age >= 5)
        {
            Console.WriteLine("You can watch PG and G rated movies!");
        }
        else if (age <= 5)
        {
            Console.WriteLine("You probably can't watch too many movies");
        }
        Console.WriteLine("\nDone.");
    }
}