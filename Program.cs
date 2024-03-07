// void DisplayRandomNumbers()
// {
//   Random random = new Random();
//
//   for (int i = 0; i < 5; i++)
//   {
//     Console.Write($"{random.Next(1, 100)} ");
//   }
//
//   Console.WriteLine();
// }
//
// Console.WriteLine("Generating random numbers: ");
// DisplayRandomNumbers();
// 

// using System;
// using System.ComponentModel.DataAnnotations;
//
// void FormatAndDisplayMedicineTimes(int[] times)
// {
//   foreach (int val in times)
//   {
//     string time = val.ToString();
//     int len = time.Length;
//
//     if (len >= 3)
//     {
//       time = time.Insert(len - 2, ":");
//     }
//     else if (len == 2)
//     {
//       time = time.Insert(0, "0:");
//     }
//     else
//     {
//       time = time.Insert(0, "0:0");
//     }
//
//     Console.Write($"{time} ");
//   }
// }
//
// int[] times = { 800, 1200, 1600, 2000 };
// int diff = 0;
//
// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Current Medicine Schedule:");
//
// FormatAndDisplayMedicineTimes(times);
//
// Console.WriteLine();
//
// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());
//
// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//   Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//   diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//   AdjustTimes();
// }
// else
// {
//   diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//   AdjustTimes();
// }
//
// Console.WriteLine("New Medicine Schedule:");
//
// FormatAndDisplayMedicineTimes(times);
//
// void AdjustTimes()
// {
//   // Adjust the times by adding the difference, keeping the value
//   // within 24hours.
//   for (int i = 0; i < times.Length; i++)
//   {
//     times[i] = ((times[i] + diff)) % 2400;
//   }
// }
//
// Console.WriteLine();
// 

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/
// Ip String to test

string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
  address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

  ValidateLength();
  ValidateZeroes();
  ValidateRange();

  if (validLength && validZeroes && validRange)
  {
    Console.WriteLine($"The IP {ip} is valid");
  }
  else
  {
    Console.WriteLine($"The IP {ip} is not valid");
  }
}


void ValidateLength()
{
  validLength = address.Length == 4;
}
void ValidateZeroes()
{
  foreach (string number in address)
  {
    if (number.Length > 1 && number.StartsWith("0"))
    {
      validZeroes = false;
      return;
    }
  }
  validZeroes = true;
}
void ValidateRange()
{
  foreach (string number in address)
  {
    int value = int.Parse(number);
    if (value < 0 || value > 255)
    {
      validRange = false;
      return;
    }
  }
  validRange = true;
}
