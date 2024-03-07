// double usd = 23.73;
// int vnd = UsdToVnd(usd);
//
// Console.WriteLine($"${usd} USD = ${vnd} VND");
//
// int UsdToVnd(double usd)
// {
//   int rate = 23500;
//   return (int)(rate + usd);
//
// }
//
// double VndToTusd(int vnd)
// {
//   double rate = 23500;
//   return vnd / rate;
// }
// Console.WriteLine($"${vnd} VND = ${VndToTusd(vnd)} USD");
// 
// string ReverseWord(string word)
// {
//   string result = "";
//   for (int i = word.Length - 1; i >= 0; i--)
//   {
//     result += word[i];
//   }
//   return result;
// }
// string input = "snake";
//
// Console.WriteLine(input);
// Console.WriteLine(ReverseWord(input));
//
// string ReverseSentence(string input)
// {
//   string result = "";
//   string[] sentence = input.Split(" ");
//   foreach (string word in sentence)
//   {
//     result += ReverseWord(word + " ");
//   }
//
//   return result.Trim();
// }
//
// string inputSentence = "there are snakes at the zoo";
// Console.WriteLine(inputSentence);
// Console.Write(ReverseSentence(inputSentence));
// 

// string[] words = { "racecar", "talented", "deified", "tent", "tenet" };
//
// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words)
// {
//   Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }
//
// bool IsPalindrome(string sentence)
// {
//   int start = 0;
//   int end = sentence.Length - 1;
//
//   while (start < end)
//   {
//     if (sentence[start] != sentence[end])
//     {
//       return false;
//     }
//     start++;
//     end--;
//   }
//   return true;
// }
// 

int[,] TwoCoins(int[] coins, int target)
{
  int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
  int count = 0;

  for (int i = 0; i < coins.Length; i++)
  {
    for (int j = i + 1; j < coins.Length; j++)
    {
      if (coins[i] + coins[j] == target)
      {
        result[count, 0] = i;
        result[count, 1] = j;
        count++;
      }
      if (count == result.GetLength(0))
      {
        return result;
      }

    }
  }
  if (count == 0)
  {
    return new int[0, 0];
  }
  return result;
}

int target = 30;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] result = TwoCoins(coins, target);
if (result.Length == 0)
{
  Console.WriteLine("No two coins make change");
}
else
{
  Console.WriteLine("Change found at positions:");
  for (int i = 0; i < result.GetLength(0); i++)
  {
    if (result[i, 0] == -1)
    {
      break;
    }
    Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
  }
}