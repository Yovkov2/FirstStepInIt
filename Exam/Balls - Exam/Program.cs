int countBalls = int.Parse(Console.ReadLine());

int sum = 0;

int redBalls = 0;
int orangeBalls = 0;
int yellowBalls = 0;
int whiteBalls = 0;
int otherBalls = 0;
double divideBalls = 0; 
for (int i = 0; i < countBalls; i++)
{
    string color = Console.ReadLine();
    if(color == "white")
    {
        whiteBalls++;
        sum += 20;
    }
    else if(color == "red")
    {
        redBalls++;
        sum += 5;
    }
    else if(color == "orange")
    {
        orangeBalls++;
        sum += 10;
    }
    else if(color == "yellow")
    {
        yellowBalls++;
        sum += 15;
    }
    else if(color == "black")
    {
        
        sum /= 2;
        divideBalls++;
    }
    else
    {
        otherBalls++;
    }
}
Console.WriteLine($"Total points: {sum}");
Console.WriteLine($"Red balls: {redBalls}");
Console.WriteLine($"Orange balls: {orangeBalls}");
Console.WriteLine($"Yellow balls: {yellowBalls}");
Console.WriteLine($"White balls: {whiteBalls}");
Console.WriteLine($"Other colors picked: {otherBalls}");
Console.WriteLine($"Divides from black balls: {divideBalls}");

