using System;

namespace StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homework 1 Student Grade

            //First, last name, and studentid

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your student ID number?");
            double studentID = Convert.ToDouble(Console.ReadLine());

            //Getting User Grades
            Console.WriteLine("What is your overall percentage grade for homeworks?");
            double gradeHomework = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participations?");
            double gradeParticipation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double gradeQuiz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            double gradeMidterm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final?");
            double gradeFinal = Convert.ToDouble(Console.ReadLine());

            //Computing final grade and outputting
            double gradeTotal = gradeParticipation * 0.08 + gradeHomework * 0.12 + gradeMidterm * 0.4 + gradeFinal * 0.4;

            Console.WriteLine(firstName + " " + lastName + " (" + studentID + ") your final grade is:" + gradeTotal + "%");
        }
    }
}
