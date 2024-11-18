using System.Runtime.ConstrainedExecution;

string[] saker = ["leksak1","leksak2","leksak3","leksak4","leksak5"];

string[] namn = ["Dean","Rasmus","Martin","Joakim","Anton"];

int[] nummer = [1,3,5,7,9];

for (int i = 0; i < 5; i++)
{
    int r = Random.Shared.Next(0,5);
    int r2 = Random.Shared.Next(0,5);
    int r3 = Random.Shared.Next(0,5);

    Console.WriteLine($"{namn[r]} ger {saker[r2]} betyget {nummer[r3]}");
}

Console.ReadLine();