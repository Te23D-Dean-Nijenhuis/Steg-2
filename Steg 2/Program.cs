using System.Runtime.ConstrainedExecution;

List<string> saker = ["leksak1","leksak2","leksak3","leksak4","leksak5"];

List<string> namn = ["Dean","Rasmus","Martin","Joakim","Anton"];

List<string> stader = [];

List<int> nummer = [1,3,5,7,9];

// for (int i = 0; i < 5; i++)
// {
//     int r = Random.Shared.Next(0,5);
//     int r2 = Random.Shared.Next(0,5);
//     int r3 = Random.Shared.Next(0,5);

//     Console.WriteLine($"{namn[r]} ger {saker[r2]} betyget {nummer[r3]}");
// }

// Console.ReadLine();

bool run = true;
string stad;

while (run)
{
    Console.WriteLine("skriv in ett namn på en stad eller skriv exit om du vill lämna.");
    stad = Console.ReadLine();
    if (stad.ToLower() == "exit")
    {
        run = false;
        for (int i = 0; i < stader.Count; i++)
        {
            Console.WriteLine(stader[i]);
        }

    } else
    {
        stader.Add(stad);
    }
}

Console.ReadLine();