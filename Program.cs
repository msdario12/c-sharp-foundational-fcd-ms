
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
  PlayGame();
}

bool ShouldPlay()
{
  string userInput = "";
  while (userInput != "exit")
  {
    string? readValue = Console.ReadLine();
    if (readValue != null)
    {
      userInput = readValue;
      userInput.ToLower().Trim();
      return userInput == "y" || userInput == "yes";
    }
  }
  return false;
}

int GetRollValue()
{
  return random.Next(1, 7);
}

int GetTargetValue()
{
  return random.Next(1, 6);
}

bool WinOrLose(int target, int roll)
{
  return roll > target;
}

void PlayGame()
{
  var play = true;

  while (play)
  {
    var target = GetTargetValue();
    var roll = GetRollValue();

    Console.WriteLine($"Roll a number greater than {target} to win!");
    Console.WriteLine($"You rolled a {roll}");
    Console.WriteLine(WinOrLose(target, roll));
    Console.WriteLine("\nPlay again? (Y/N)");

    play = ShouldPlay();
  }
}