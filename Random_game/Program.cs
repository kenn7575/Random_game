int numberOfDice = GetInputAndConvertToInt("How many dice do you want");
Console.Clear();
int trys = 0;
int numberOfSixs= 0;
Random rnd = new Random();
for (int j = 0; j == 0;)
{
    for (int i = 0; numberOfDice != i; i++)
    {
        int currentDice = rnd.Next(1, 7);
        if (currentDice == 6) { numberOfSixs++; }
    }
    if (numberOfSixs != numberOfDice)
    {
        numberOfSixs = 0;
        trys++;
    }
    else
    {
        break;
    }
}
Console.WriteLine(trys);
int GetInputAndConvertToInt(string message)
{
    bool valid = false;
    int output_value = 0;
    while (!valid)
    {
        Console.WriteLine(message);
        string input_value = Console.ReadLine();
        bool result = Int32.TryParse(input_value, out output_value);
        if (result)
        {
            valid = true;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Error: could not convert '{0}' to a double", input_value);
        }
    }
    return output_value;
}