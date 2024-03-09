string serialName = Console.ReadLine();
int seasons = int.Parse(Console.ReadLine());
int episodes = int.Parse(Console.ReadLine());
double time = double.Parse(Console.ReadLine());

double advertisements = time * 0.2;
double timeAdvertisements = time + advertisements;
int specialEpisode = seasons * 10;

double sum = timeAdvertisements * episodes * seasons + specialEpisode;
Console.WriteLine($"Total time needed to watch the {serialName} series is {sum} minutes.");
