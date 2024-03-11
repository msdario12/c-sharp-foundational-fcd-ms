﻿string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

string overallStatusMessage = "";
try
{
  Workflow1(userEnteredValues);
  Console.WriteLine("'Workflow1' completed successfully.");
}
catch (DivideByZeroException ex)
{
  Console.WriteLine("An error occurred during 'Workflow1'.");
  Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
  foreach (string[] userEntries in userEnteredValues)
  {
    // processStatusMessage = Process1(userEntries);
    try
    {
      Process1(userEntries);
      Console.WriteLine("'Process1' completed successfully.");
      Console.WriteLine();
    }
    catch (FormatException ex)
    {

      Console.WriteLine("'Process1' encountered an issue, process aborted.");
      Console.WriteLine(ex.Message);
      Console.WriteLine();

    }
    catch (DivideByZeroException ex)
    {

      Console.WriteLine("'Process1' encountered an issue, process aborted.");
      Console.WriteLine(ex.Message);
      throw;
    }
  }

  // return operationStatusMessage;
}

static void Process1(String[] userEntries)
{
  string returnMessage = "";
  int valueEntered;

  foreach (string userValue in userEntries)
  {
    bool integerFormat = int.TryParse(userValue, out valueEntered);

    if (integerFormat == true)
    {
      if (valueEntered != 0)
      {
        checked
        {
          int calculatedValue = 4 / valueEntered;
        }
      }
      else
      {
        returnMessage = "Invalid data. User input values must be non-zero values.";
        throw new DivideByZeroException(returnMessage);
      }
    }
    else
    {
      returnMessage = "Invalid data. User input values must be valid integers.";
      throw new FormatException(returnMessage);
    }
  }

}