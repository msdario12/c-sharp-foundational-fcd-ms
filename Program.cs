string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("Shool A");
PlanSchoolVisit("Shool B", 3);
PlanSchoolVisit("Shool C", 2);

RandomizeAnimals();

void PlanSchoolVisit(string schoolName, int groups = 6)
{
  RandomizeAnimals();
  string[,] group = AssingGroup();
  Console.WriteLine(schoolName);
  PrintGroup(group);
}

void RandomizeAnimals()
{
  Random random = new Random();
  for (int i = 0; i < pettingZoo.Length; i++)
  {
    int r = random.Next(i, pettingZoo.Length);

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;

  }
}

string[,] AssingGroup(int groups = 6)
{
  string[,] result = new string[groups, pettingZoo.Length / groups];
  int start = 0;
  for (int i = 0; i < groups; i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i, j] = pettingZoo[start++];
    }
  }
  return result;

}
void PrintGroup(string[,] group)
{
  for (int i = 0; i < group.GetLength(0); i++)
  {
    Console.Write($"Group {i + 1}:");
    for (int j = 0; j < group.GetLength(1); j++)
    {
      Console.Write($"{group[i, j]}  ");
    }
    Console.WriteLine();
  }
}