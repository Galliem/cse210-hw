using System;
using System.Collections.Generic;

Console.WriteLine("Enter a list of numbers, type 0 when finished.");
int userNumber = 3;
int sum = 0;
// Lists - new keyword
List<int> numbers = new List<int>();

do while (userNumber != 0)
    {
        string userInput = System.Console.ReadLine();
        userNumber = int.Parse(userInput);

        if (userNumber != 0)
        {
            numbers.Add(userNumber);
        }
        //iterate over items
        foreach (int  i in numbers)
        {
            sum += i;
        }
        System.Console.WriteLine($"The total is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        foreach (int i in numbers)
        {
            int max = numbers[0];
            if (i > max)
            {
                max = i;
                System.Console.WriteLine($"The max is : {max}");
            }
        }
    }
