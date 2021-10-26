using System;
using System.Collections.Generic;

namespace GCDevBuildPasswordLabCodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userNames = new List<string>();
            List<string> passWords = new List<string>();
            Console.WriteLine("Please enter a username that is between 7 and 12 characters");
            Console.WriteLine("Username must have atleast one number.");
            Console.WriteLine("Username must have atlease one letter.");
            string name = GetUserInput("Please enter a valid username");
            bool validName = UserNameCheck(name);
            Console.WriteLine(validName);
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);

            string input = Console.ReadLine();
            return input;
        }

        public static bool UserNameCheck(string name)
        {
            bool inRange = RangeCheck(7, 12, name.Length);
            //incorportate numcheck method 
            bool hasNum = CheckforNums(name);
            //incorporate letetrcheck method
            bool hasLetters = CheckForLetters(name);


            return inRange && hasNum && hasLetters;

        }

        public static bool RangeCheck(int min, int max, int num)
        {
            if(num > min && num <= max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckforNums(string name)
        {
            char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };

            for(int i = 0; i<nums.Length; i++)
            {
                char num = nums[i];

                if(name.Contains(num))
                {
                    return true;
                }
            }

            //Hey nothing got found lets return false
            return false;
        }

        public static bool CheckForLetters(string input)
        {
            for(char charcter = 'A'; charcter < 'z'; charcter++)
            {
                
                if(char.IsLetter(charcter) && input.Contains(charcter))
                {
                    Console.WriteLine(charcter);//check to see if it's working
                    return true;
                }
                else
                {

                }
            }

            return false;
        }
    }

   
}
