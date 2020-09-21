using System;

namespace TheExpertSystem


{




    class Program
    {

        /*

        Title: How Long Have You Been Alive
        Application Type: Console
        Description: Figure out how many minutes, hours, days, weeks and months user has been alive
        Author: Emily Crull
        Date Created: 9/20/2020
        Last Modified:

        */




        static void Main(string[] args)
        {

            string birthDate;
            int birthMonthNumber;

            System.Console.BackgroundColor = System.ConsoleColor.Black;
            System.Console.ForegroundColor = System.ConsoleColor.DarkYellow;



            //***** Opening Screen ******

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t Let's figure out how long you have been alive!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t (Press any key to continue >>>>)");
            Console.ReadKey();
            Console.Clear();



            //***** Instructions Screen *****
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t Instructions: You'll enter your birthday and then find out how many minutes, hours, days, weeks, and months that translates to.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t (Press any key to continue >>>>)");
            Console.ReadKey();
            Console.Clear();



            //***** User Input Screen *****

            Console.WriteLine("\t\tWhen were you born?");
            Console.WriteLine();
            Console.Write("Enter your birthdate(mm/dd/yyyy): ");
            birthDate = Console.ReadLine();
            string sub1 = birthDate.Substring(0, 2);
            string sub2 = birthDate.Substring(3, 2);
            string sub3 = birthDate.Substring(6, 4);
            Console.Clear();



            //***** Results Screen *****

            birthMonthNumber = Convert.ToInt32(sub1);
            if (birthMonthNumber == 01)
                Console.Write("That's cool. You were born on January {0}, {1}. ", sub2, sub3);
            if (birthMonthNumber == 02)
                Console.Write("That's cool. You were born on February {0}, {1}. ", sub2, sub3);
            if (birthMonthNumber == 03)
                Console.Write("That's cool. You were born on March {0}, {1}. ", sub2, sub3);
            if (birthMonthNumber == 04)
                Console.Write("That's cool. You were born on April {0}, {1}. ", sub2, sub3);
            if (birthMonthNumber == 05)
                Console.Write("That's cool. You were born on May {0}, {1}. ", sub2, sub3);
            if (birthMonthNumber == 06)
                Console.Write("That's cool. You were born on June {0}, {1}. ", sub2, sub3);
            if (birthMonthNumber == 07)
                Console.Write("That's cool. You were born on July {0}, {1}. ", sub2, sub3);
            if (birthMonthNumber == 08)
                Console.Write("That's cool. You were born on August {0}, {1}. ", sub2, sub3);
            if (birthMonthNumber == 09)
                Console.Write("That's cool. You were born on September {0}, {1}. ", sub2, sub3);
            if (birthMonthNumber == 10)
                Console.Write("That's cool. You were born on October {0}, {1}. ", sub2, sub3);
            if (birthMonthNumber == 11)
                Console.Write("That's cool. You were born on November {0}, {1}. ", sub2, sub3);
            if (birthMonthNumber == 12)
                Console.Write("That's cool. You were born on December {0}, {1}. ", sub2, sub3);
            Console.WriteLine();
            Console.WriteLine();
            DateTime howLongAlive = DateTime.Parse(birthDate);
            TimeSpan yourAge = DateTime.Now.Subtract(howLongAlive);
            double weeksAlive = (DateTime.Now - howLongAlive).TotalDays / 7;
            double monthsAlive = weeksAlive / 12;
            Console.WriteLine("Fun fact: You have been alive for {0:n0} minutes, {1:n0} hours, {2:n0} days, {3:n0} weeks, and {4:n0} months.", Convert.ToInt32(yourAge.TotalMinutes), Convert.ToInt32(yourAge.TotalHours), Convert.ToInt32(yourAge.TotalDays), Convert.ToInt32(weeksAlive), Convert.ToInt32(monthsAlive));
            Console.WriteLine();
            bool validResponse;
            bool longTime = false;
            string longTimeResponse;

            do
            {
                validResponse = true;
                Console.Write("Does that feel like a long time? ");
                longTimeResponse = Console.ReadLine().ToLower();
                Console.Clear();
                if (longTimeResponse == "yes")
                {
                    longTime = true;
                    Console.WriteLine("Well, you know what they say, 'You're only as old as you feel'!");
                    Console.WriteLine();
                    Console.WriteLine("\t\t (Press any key to continue >>>>)");
                    Console.ReadKey();
                    break;
                }

                else if (longTimeResponse == "no")
                {

                    longTime = false;
                    Console.WriteLine("Look at you...just a young pup. So much experience to gain....wisdom to attain. Enjoy the journey!");
                    Console.WriteLine();
                    Console.WriteLine("\t\t (Press any key to continue >>>>)");
                    Console.ReadKey();
                    break;

                }

                else
                {
                    validResponse = false;
                    Console.WriteLine("Please respond with a 'yes' or 'no'.");
                    Console.WriteLine();
                    //Console.ReadLine();

                }

            } while (!validResponse);

            //***** Closing Screen *****

            Console.Clear();
            Console.WriteLine("\t\tI'm glad you were born.");
            Console.ReadKey();

        }
    }
    }

