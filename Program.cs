Console.WriteLine("Hallo, wie hoch soll ihre Pyramide sein?");

int höhe = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Welches Zeichen soll als Inhalt gewählt werden?");
string s = Console.ReadLine();

int länge = s.Length;

string leerzeichen = "";

for (int i = 0; i < länge; i++)
{
    leerzeichen += " ";
}

string s1 = s + s;

Console.WriteLine("Soll die Pyramide auf dem Kopf stehen? y/n");
string s2 = Console.ReadLine();
string s3;

while(s2 != "y" && s2 != "n")
{
    Console.WriteLine("Sie müssen entweder y (yes) oder n (no) eingeben");
    s2 = Console.ReadLine();
}

if (s2 == "n")
{
    for (int i = höhe; i > 0; i--)
    {
        for (int j = i; j > 1; j--)
        {
            Console.Write(leerzeichen);
        }

        Console.WriteLine(s);
        s += s1;
    }
}
else
{
    for (int i = 0; i < höhe; i++)
    {
        s3 = s;
        for (int j = i; j < höhe-1; j++) 
        {
            s3 += s1;
        }
        Console.WriteLine(s3);
        for (int l = -1; l < i; l++)
        {
            Console.Write(leerzeichen);
        }
    }
}

Console.ReadKey();