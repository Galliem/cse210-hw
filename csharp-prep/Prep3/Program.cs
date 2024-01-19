using System;

Console.WriteLine("Hello Prep3 World!");

/*int count = 5;
//while
while (count < 10) {
    Console.WriteLine($"Count = {count}");
    count += 1;
}
//do while
int anotherCount = 0;
do {
    System.Console.WriteLine($"AnotherCount = {anotherCount++}");
} while (anotherCount < 10);
//for while
for (int i=0; i<5; ++i) {
    System.Console.WriteLine($"i = {i}");
}*/

// ask for random number
Random randomGenerator = new Random();
int randomNumber = randomGenerator.Next(1, 11);


//ask for a number from user
System.Console.WriteLine("Guess a random number: ");
int guess = int.Parse(Console.ReadLine());
    
    //check if guess is higher
    if(guess > randomNumber){
        System.Console.WriteLine("Too high");}

    //check if guess is lower
    else if (guess < randomNumber){
        System.Console.WriteLine("Too low");}
    else
        System.Console.WriteLine("You got it!");
            
