int kilogramsFood = int.Parse(Console.ReadLine()) * 1000;

string command = Console.ReadLine();
int totalEatenFood = 0;

while (command != "Adopted")
{
    int dayFood = int.Parse(command);
    totalEatenFood += dayFood;

    if (totalEatenFood > kilogramsFood)
    {
        Console.WriteLine($"Food is not enough. You need {totalEatenFood - kilogramsFood} grams more.");
        return;
    }

    command = Console.ReadLine();
}

int leftovers = kilogramsFood - totalEatenFood;
Console.WriteLine($"Food is enough! Leftovers: {leftovers} grams.");