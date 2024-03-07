// int[] schedule = { 800, 1200, 1600, 2000 };
//
// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//   int diff = 0;
//   if (MathF.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//   {
//     Console.WriteLine("Invalid GMT");
//   }
//   else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//   {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//   }
//   else
//   {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//   }
//   for (int i = 0; i < times.Length; i++)
//   {
//     int newTime = ((times[i] + diff)) % 2400;
//     Console.WriteLine($"{times[i]} -> {newTime}");
//   }
// }
//
// DisplayAdjustedTimes(schedule, 6, -6);
// 
string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;
RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
  if (inviteOnly)
  {
    // search guestList before adding rsvp
    bool found = false;
    foreach (string guest in guestList)
    {
      if (guest.Equals(name))
      {
        found = true;
        break;
      }
    }
    if (!found)
    {
      Console.WriteLine($"Sorry, {name} is not on the guest list.");
      return;
    }
  }

  rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
  count++;
}

void ShowRSVPs()
{
  Console.WriteLine("\nTotal RSVPs:");
  for (int i = 0; i < count; i++)
  {
    Console.WriteLine(rsvps[i]);
  }
}