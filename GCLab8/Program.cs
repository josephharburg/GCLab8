using System;

namespace GCLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            string[] students =
             {
                "Joseph H",
                "Margaret K",
                "John H",
                "Barb S",
                "Tom H",
                "Mike H"
                };
            string[] homeTown =
                {
                "Ann Arbor, Michigan",
                "Milford, New Jersey",
                "New York, New York",
                "Bloomfield Hills, Michigan",
                "Eugene, Oregon",
                "Olympia, Washington"
                };
            string[] currentJob =
                {
                "Service Sales Rep",
                "Baker",
                "Pyschologist",
                "Teacher",
                "Doctor",
                "Therapist"
                };
            string[] major = {
                "C#/.net",
                "Culinary Arts",
                "Psycology",
                "Education",
                "Eastern Medicine",
                "Social Work" };
            while (repeat)
            {
                Console.WriteLine("Hi! Welcome to the Student DataBase Main Menu.");
                //get number into variable and validate
                for (int index = 0; index < students.Length; index++)
                {
                    Console.WriteLine($"{index + 1}: {students[index]}");
                }
                int studentNumber = Validator(students);
                //get student name into variable
                string studentName = students[studentNumber];
                Console.WriteLine($"\nYou have chosen {studentName}.");
                //get information about student selected
                bool repeatOne = true; 
                while (repeatOne)
                {
                    getInfo(studentName, studentNumber, homeTown, currentJob, major);
                    repeatOne = repeator(studentName);
                }
                repeat = repeator("another student");
                if (repeat == false)
                {
                    Console.WriteLine("Goodbye!");
                }
            }

        }
        public static int Validator(string[] array)
        {
            int number = 0;
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Please Enter a Student Number (1-6):");
                try
                {
                    string userInput = Console.ReadLine();
                    number = int.Parse(userInput) - 1;
                    repeat = false;
                    string studentName = array[number];
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Im sorry that is not a student number! Please enter a number between 1 and 6!");
                    repeat = true;

                }
                catch (OverflowException)
                {
                    Console.WriteLine("Im sorry that is not a student number! Please enter a number between 1 and 6!");
                    repeat = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number please!");
                    repeat = true;
                }
               
            }
            return number;


        }
        public static void getInfo(string student, int studentNum, string[] hometown, string[] job, string[] major)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine($"\nWhat would you like to know about {student}?\n\tYou can choose: Hometown, Job, or Major.");
                string whatInfo = Console.ReadLine().ToLower();
                if (whatInfo == "hometown")
                {
                    Console.WriteLine($"{student}'s hometown is {hometown[studentNum]}.");
                    repeat = false;

                }
                else if (whatInfo == "job")
                {
                    Console.WriteLine($"{student}'s current job is {job[studentNum]}.");
                    repeat = false;
                }
                else if (whatInfo == "major")
                {
                    Console.WriteLine($"{student}'s major is {major[studentNum]}.");
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Im sorry that wasnt a choice!");
                }
            }

        }
        public static bool repeator(string learnMore)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine($"Would you like to know more about {learnMore}?");
                string userRepeat = Console.ReadLine().ToLower();

                if (userRepeat == "n" || userRepeat == "no")
                {
                    Console.WriteLine("Ok, No problem!");
                    repeat = false;
                }
                else if (userRepeat == "y" || userRepeat == "yes")
                {
                    userRepeat = "y";
                    repeat = false;
                    return true;
                }
                else
                {
                    Console.WriteLine("Please put a yes, y, no, or n.");
                }
                
            }
            return repeat;
        }

    }



}
