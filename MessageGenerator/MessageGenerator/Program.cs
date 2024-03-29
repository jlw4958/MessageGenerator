﻿using System;
using System.Globalization;
using System.Threading;
using System.IO;

namespace MessageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse = "";
            char[] alphArray = new char[95];

            alphArray = ArraySetup();

            //getting user input:
            //prompt user
            //receive input
            //check for the following:
            // - empty response

            while (userResponse != "q")
            {
                while (String.IsNullOrEmpty(userResponse))
                {
                    Console.Write("What phrase would you like us to display? (Enter q to quit): ");
                    userResponse = Console.ReadLine();
                    if (String.IsNullOrEmpty(userResponse))
                    {
                        Console.WriteLine("Please provide a response :(");
                    }
                }
                if (userResponse == "q")
                {
                    Console.Write("Are you sure you want to quit? y/n: ");
                    userResponse = Console.ReadLine();
                    if (userResponse.ToLower() == "y")
                    {
                        Console.Write("Goodbye!");
                        break;
                    }
                    else
                    {
                        userResponse = "";
                    }
                }

                AlphabetShuffle(alphArray, userResponse);

                userResponse = "";
            }
        }

        // how do we want our file to be set up?
        // we need username + password + associated phrase
        // all of that can be a part of one string? we'll have one symbol be unavailable for phrases in that case (maybe ^)
        // split on ^
        // username will be array[0], password will be array[1], phrase will be array [2]
        // how do we find the right username in the file?
        //  - line.contains
        // for each line in the file
        // if line.Contains(username)
        //  - prompt for password
        //  - if line.Contains(password)
        //      - populate array
        //      - userResponse = array[2]

        /// <summary>
        /// this method sets up the array of characters we iterate through
        /// </summary>
        /// <returns></returns>
        public static char[] ArraySetup()
        {
            char[] alphArray = new char[95];

            //number for populating the array
            int num = 0;


            //adding lowercase letters first
            for (int i = 97; i < 123; i++)
            {
                alphArray[num] = (char)i;
                num++;
            }

            //populating the array with punctuation, space, and capital letters
            for (int i = 32; i < 96; i++)
            {
                alphArray[num] = (char)i;
                num++;
            }

            return alphArray;
        }

        /// <summary>
        /// this array gives us our final returned word or phrase
        /// </summary>
        /// <param name="array"></param>
        /// <param name="word"></param>
        public static void AlphabetShuffle(char[] array, string word)
        {
            string finalWord = "";

            //comparing to the text
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if ((int)array[j] >= 97 && (int)array[j] <= 122 )
                    {
                        Console.WriteLine(finalWord + array[j]);
                        Thread.Sleep(50);
                    }
                    if (array[j] == word[i])
                    {
                        finalWord += array[j];
                        break;
                    }
                    
                }
            }

            Console.WriteLine(finalWord);
        }
    }
}

