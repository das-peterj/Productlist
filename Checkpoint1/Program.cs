string[] productNames = new string[100];
int index = 0;

while (true)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Please input the productnumber: ");
    string input = Console.ReadLine();

    if (input.ToLower().Trim() == "exit")
    {
        break;
    }

    string productLetter = "";
    string checkProductNumber = "";
    int productNumber = 0;
    while (true)
    {
        if (input.Contains("-"))
        {
            productLetter = input.Substring(0, input.IndexOf("-"));
            checkProductNumber = input.Substring(input.IndexOf("-") + 1);
            if (checkProductNumber.Any(char.IsLetter))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Only numerical values are accepted right of the dash.");
                break;   
            }
            productNumber = Int32.Parse(checkProductNumber);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Missing dash from product name. Try again.");
            break;
        }

        if (productNumber < 200) {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("The numerical value can't be lower than 200."); 
            break; 
        }
        else if (productNumber > 500) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The numerical value can't be higher than 500."); 
            break; 
        }
        else if (productLetter.Any(char.IsDigit)) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Numerical values not accepted left of the dash"); 
            break; 
        }
        else
        {
            productNames[index] = input;
            index++;
            break;
        }
    }
}
Console.WriteLine("");
Console.WriteLine("");

Array.Resize(ref productNames, index);
Array.Sort(productNames);

Console.WriteLine("You wrote the following product names (sorted alpabetically)");

foreach(string productName in productNames)
{
    Console.WriteLine(productName);
}



