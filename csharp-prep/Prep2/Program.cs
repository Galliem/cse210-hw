using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        int grade_percentage = Convert.ToInt32(Console.ReadLine());
            String letters = "";

            if (grade_percentage <= 60){
                letters = "D";
            }
            else if (grade_percentage >= 60 && grade_percentage <= 71){
                letters = "D";
            }
            else if (grade_percentage >= 70 && grade_percentage < 81){
                letters = "C";
            }
            else if (grade_percentage >= 80 && grade_percentage < 91){
                letters = "B";
            }
            else if (grade_percentage >= 90){
                letters = "A";
            }

            Console.WriteLine($"Grade: {letters}");

            if (grade_percentage >= 70 ){
                Console.WriteLine("You Passed!");
            }

            else if (grade_percentage <= 70){
                Console.WriteLine("You didn't pass. Please try again.");
            }

    }
}