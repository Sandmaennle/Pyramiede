Console.WriteLine("Hallo, wie hoch soll ihre Pyramide sein?");

int höhe = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Welches Zeichen soll als Inhalt gewählt werden?");
string s = Console.ReadLine();

string s1 = s + s;

for (int i = höhe; i > 0; i--)
{
    for (int j = i; j > 1; j--)
    {
        Console.Write(" ");
    }

    Console.WriteLine(s);
    s += s1;
}

Console.ReadKey();