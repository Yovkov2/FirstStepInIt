int needTimeMin = int.Parse(Console.ReadLine());
int needTimeSec = int.Parse(Console.ReadLine());

double length = double.Parse(Console.ReadLine());
int secRun = int.Parse(Console.ReadLine());

int sumKontrola = needTimeMin * 60 + needTimeSec;
double timeWillDecrease = length / 120;
double sumDecrease = timeWillDecrease * 2.5;
double sumMarin = (length / 100) * secRun - sumDecrease;

if(sumMarin <= sumKontrola)
{
    Console.WriteLine($"Marin Bangiev won an Olympic quota! His time is {sumMarin:F3}.");
}
else
{
    Console.WriteLine($"No, Marin failed! He was {sumMarin - sumKontrola:f3} second slower.");
}
