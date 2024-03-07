string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

void CreateEmail(string name, string lastName, string domain = "hayworth.com")
{
  string message = name.ToLower().Substring(0, 2) + lastName.ToLower() + "@" + domain;
  Console.WriteLine(message);
}

for (int i = 0; i < corporate.GetLength(0); i++)
{
  // display internal email addresses
  string name = corporate[i, 0];
  string lastName = corporate[i, 1];
  CreateEmail(name, lastName);

}

for (int i = 0; i < external.GetLength(0); i++)
{
  // display external email addresses
  string name = external[i, 0];
  string lastName = external[i, 1];
  CreateEmail(name, lastName, "contoso.com");
}