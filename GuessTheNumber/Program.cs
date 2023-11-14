// See https://aka.ms/new-console-template for more information
Init();
static void Init()
{
    int randomNumber = RandomizeNumber();
    Run(randomNumber);
}
static void Run(int randomNumber)
{
    Console.WriteLine("Guess a number between 1 and 100!");
    var answer = Console.ReadLine();
    int answerAsNumber = Convert.ToInt32(answer);
    checkIfRight(answerAsNumber, randomNumber);
}
static int RandomizeNumber()
{
    Random rand = new Random();
    var randomNumber = rand.Next(0, 99) + 1;
    return randomNumber;
}
static void checkIfRight(int answerAsNumber, int randomNumber)
{
    if (answerAsNumber == randomNumber)
    {
        Console.WriteLine($"{answerAsNumber} is the right number!");
        Restart();
    } else if (answerAsNumber < randomNumber)
    {
        Console.WriteLine($"{answerAsNumber} is too low!");
        Run(randomNumber);
    } else if (answerAsNumber > randomNumber)
    {
        Console.WriteLine($"{answerAsNumber} is too high!");
        Run(randomNumber);
    }
}
static void Restart()
{
    Console.WriteLine("New game? (Yes/No)");
    string reply = Console.ReadLine();
    if (reply.ToLower() == "yes")
    {
        Init();
    } else if (reply.ToLower() == "no")
    {
        Console.WriteLine("Okay, suit yourself");
    }
}