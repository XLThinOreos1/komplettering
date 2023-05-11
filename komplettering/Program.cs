Random RNG = new Random();
int RandomNumber;
bool AnswerGood = false;

Console.WriteLine("What is your name?");
string name = Console.ReadLine();

// Runs the game until the player is right
while (!AnswerGood)
{
    RandomNumber = RNG.Next(1, 11);
    Console.WriteLine("Guess a number from 1 to 10");
    NumberInputValidation();
    Console.Clear();
}
Console.WriteLine("Wow you guessed it correctly!\nYou won!");
Console.ReadLine();


// Funktion som checkar ifall användarens input är ett tal och ifall det är det så gör den en bool sant.
// Om det inte är det så säger den att det inte är ett tal och man försöker igen.
void NumberInputValidation()
{
    try
    {
        int UserInput = int.Parse(Console.ReadLine());
        
        if (UserInput == RandomNumber)
        {
            AnswerGood = true;
        }
    }
    catch
    {
        Console.WriteLine("That is not a valid input!\nTry again!");
    }
}

// En återanvändbar funktion som kollar ifall talet är jämn eller udda.
bool IsEven(int value)
{
    if (value % 2 == 0)
    {
        return true;
    }
    return false;
}
