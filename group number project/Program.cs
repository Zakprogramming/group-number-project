static void Main()
{
    Random random = new Random();

    int returnValue = random.Next(1, 100);
    Console.WriteLine("What is your guess?"); 
    string Guess = Console.ReadLine();
    int intGuess= Convert.ToInt32(Guess);

    while (intGuess != returnValue)
    {
        
        while (intGuess < returnValue)
        {
            Console.WriteLine("The number is Bigger.");
            Guess = Console.ReadLine();
            intGuess = Convert.ToInt32(Guess);

        }
        while (intGuess > returnValue)
        {
            Console.WriteLine("No, the number I am thinking of is lower than " + Guess + " .  Can you guess what it is");
            Guess = Console.ReadLine();
            intGuess = Convert.ToInt32(Guess);
        }
    }
    while (intGuess == returnValue)
    {
        Console.WriteLine("Well done! The answer was " + returnValue);
        Console.ReadLine();
    }
}

Main();