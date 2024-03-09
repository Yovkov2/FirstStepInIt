string size = Console.ReadLine();
string color = Console.ReadLine();
int count = int.Parse(Console.ReadLine());

double sum = 0;

if(size == "Large")
{
    if(color == "Red")
    {
        sum = count * 16;
    }
    else if(color == "Green")
    {
        sum = count * 12;
    }
    else
    {
        sum = count * 9;
    }
}
else if(size == "Medium")
{
    if (color == "Red")
    {
        sum = count * 13;
    }
    else if (color == "Green")
    {
        sum = count * 9;
    }
    else
    {
        sum = count * 7;
    }
}
else
{
    if (color == "Red")
    {
        sum = count * 9;
    }
    else if (color == "Green")
    {
        sum = count * 8;
    }
    else
    {
        sum = count * 5;
    }
}
double razhod =  sum * 0.35;
Console.WriteLine($"{sum - razhod:f2} leva.");
