//code Writen By Kent Butler
//Date written 1/15/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            DateTime birthday;
            Console.WriteLine("Welcome to the Age App!");
            Console.WriteLine("To calculate your age we'll need to recieve your birth year, birth month, and birth day. ");

            for(; ; )
            { 
                Console.Write("Please enter your birth year: ");
                year = ValidNumber();

                Console.Write("Please enter your birth month: ");
                month = ValidNumber();

                Console.Write("Please enter your birth day: ");
                day = ValidNumber();

                if(NotValidYear(year))
                {
                    Console.WriteLine("Please add a valid year.");
                    continue;
                }
                if(NotValidMonth(month))
                {
                    Console.WriteLine("Please add a valid month.");
                    continue;
                }
                if (NotValidDay(day))
                {
                    Console.WriteLine("Please add a valid day.");
                    continue;
                }

                break;
            } 

            birthday = new DateTime(year, month, day);

            Console.WriteLine("You are currently " + 
                ((DateTime.Today.Year - birthday.Year) - HasHadBirthdayCheck(birthday.DayOfYear)) + " years and " +
                (Math.Abs(DateTime.Today.DayOfYear - birthday.DayOfYear)) + " days old.");

            if(Math.Abs(DateTime.Today.DayOfYear - birthday.DayOfYear) == 0)
            {
                Console.WriteLine("Its your Birthday! Happy Birthday!");
            }
        }

        private static int HasHadBirthdayCheck(int dayOfYear)
        {
            if (DateTime.Today.DayOfYear > dayOfYear)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static bool NotValidYear(int year)
        {
            if (year > 1900 && year < DateTime.Today.Year)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool NotValidMonth(int month)
        {
            if (month < 13 && month > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool NotValidDay(int day)
        {

            if (day < 31 && day > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int ValidNumber()
        {
            String input;
            bool validInput;
            int inputNum;

            do
            {
                input = Console.ReadLine();
                validInput = int.TryParse(input, out inputNum);
                if (!validInput)
                {
                    Console.WriteLine("Please type a valid Number");
                    validInput = false;
                }
                else if (inputNum < 1)
                {
                    Console.WriteLine("Please type a number greater than zero.");
                    validInput = false;
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);

            return inputNum;
        }
    }
}
