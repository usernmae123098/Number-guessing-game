System.Console.WriteLine("Hello welcome to my Number Guessing game");


Random random = new(); // Create a new instance of the Random class to generate random numbers
int num1 = random.Next(1, 101); // This will be the target number the user has to guess



System.Console.WriteLine("Please guess a number between 1-100");




// Loop forever until the user guesses correctly

while (true)         
{
     // Read user input from the console
    // Use "null" as a fallback if no input is given (prevents errors)
string input = Console.ReadLine() ?? "null";

  // Try to convert the input to an integer
    if (int.TryParse(input, out int Number))
    {
          // Check if the number is outside the allowed range
        if (Number > 100 || Number <= 0)
        {
            System.Console.WriteLine("it has to be a number between 1-100");
        }
          // Check if the guess matches the random number
        else if (Number == num1)
        {
            System.Console.WriteLine("Well done you got it right");
            break;

        }
  // Check if the guess is too high
        else if (Number > num1)
        {
            System.Console.WriteLine("your guess was greater than the number try again ");

        }
        // Check if the guess is too low
        else if (Number < num1)
        {
            System.Console.WriteLine("your guess was less than the number try again");

        }


    }

    else
    {
            // Handle cases where the input isn’t a valid number
        System.Console.WriteLine("Please enter a valid number");
    }

}




