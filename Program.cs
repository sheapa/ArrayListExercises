using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayListExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**************************************************************************************
            //* Exercise 1/5                                                                       *
            //**************************************************************************************
            var friends = new List<string>();
            var friendCount = 0;
            while (true)
            {
                Console.Write("Please enter names of your friends. When finished enter blank spaces to see result. ");
                friends.Add(Console.ReadLine());

                if (String.IsNullOrEmpty(friends[friendCount]))
                {
                    friends.RemoveAt(friendCount);
                    break;
                }

                friendCount++;
            }
            switch (friends.Count())
            {
                case 0:
                    Console.WriteLine("No one likes your post :(");
                    break;
                case 1:
                    Console.WriteLine(friends[0] + " likes your post!");
                    break;
                case 2:
                    Console.WriteLine(friends[0] + " & " + friends[1] + " likes your post!");
                    break;
                default:
                    Console.WriteLine(friends[0] + " & " + friends[1] + " & " + (friends.Count() - 2) + " others like your post!");
                    break;

            }

            //**************************************************************************************
            //* Exercise 2/5                                                                       *
            //**************************************************************************************
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();

            Char[] nameArray = new char[name.Length];
            for (int a = 0; a < name.Length; a++)
            {
                nameArray[a] = name[a];
            }

            Array.Reverse(nameArray);
            var nameReverse = string.Join("", nameArray);
            Console.WriteLine("Your name in reverse: " + nameReverse);

            //**************************************************************************************
            //* Exercise 3/5                                                                       *
            //**************************************************************************************
            var nums = new List<int>();
            Console.WriteLine("please enter 5 numbers.");

            while (true)
            {
                Console.WriteLine("input a number: ");
                var input = Int32.Parse(Console.ReadLine());
                var repeat = false;

                foreach (var num in nums)
                {
                    if (input == num)
                    {
                        Console.WriteLine("error " + input + " already exhists in array. please try again.");
                        repeat = true;
                    }
                }
                if (repeat == false)
                {
                    nums.Add(input);
                }

                if (nums.Count() == 5)
                {
                    nums.Sort();
                    break;
                }
            }
            Console.WriteLine("your 5 unique numbers are: ");
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            //**************************************************************************************
            //* Exercise 4/5                                                                       *
            //**************************************************************************************
            var numerals = new List<int>();

            Console.WriteLine("Please input a series of numbers. When finished input 'Quit' to exit.");

            while (true)
            {
                Console.Write("Input number then press enter: ");
                var userInput = Console.ReadLine();
                if (userInput == "Quit" || userInput == "quit")
                {
                    break;
                }
                else
                {
                    numerals.Add(Int32.Parse(userInput));
                }
            }

            var dist = numerals.Distinct();

            Console.WriteLine("Your unique set of numbers is: ");

            foreach (var d in dist)
            {
                Console.WriteLine(d);
            }

            //**************************************************************************************
            //* Exercise 5/5                                                                       *
            //**************************************************************************************
            while (true)
            {
                Console.WriteLine("Please enter a list of comma seperated numbers. Example '1, 2, 3, ...' ");
                var numerosString = Console.ReadLine();
                var numerosArray = Array.ConvertAll(numerosString.Split(','), int.Parse);

                if (numerosArray.Count() == 0 || numerosArray.Count() < 5)
                {
                    Console.WriteLine("Invalid List. Please try again.");
                }
                else
                {
                    Console.WriteLine("Your 3 Smallest Numers are: ");
                    Array.Sort(numerosArray);
                    for (var i = 0; i <= 2; i++)
                        Console.WriteLine(numerosArray[i]);
                }

            }
        }
    }
}