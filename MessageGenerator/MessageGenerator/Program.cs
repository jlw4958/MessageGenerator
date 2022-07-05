using System;
using System.Globalization;
using System.Threading;

namespace MessageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] alphArray = new char[95];

            //number for populating the array
            int num = 0;

            //populating the array with letters, numbers, and symbols
            //for (int i = 32; i < 126; i++)
            //{
            //    alphArray[num] = (char)i;
            //    num++;
            //}

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

            AlphabetShuffle(alphArray, "Eat your chicken nuggets >:(");
        }

        public static void AlphabetShuffle(char[] array, string word)
        {
            ////all lowercase for now!
            //word = word.ToLower();

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

