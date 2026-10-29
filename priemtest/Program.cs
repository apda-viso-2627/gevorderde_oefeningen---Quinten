Console.WriteLine("P| Priemgetal tester");
Console.WriteLine("E| Exit");
string keuze = Console.ReadLine();
if (keuze == "P")
{
    while (true)
    {
        Console.WriteLine("Voer een getal in (boven 2): ");
        bool priem = true;

        if (!Int32.TryParse(Console.ReadLine(), out int getal))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ongeldige invoer. Voer een geldig geheel getal in.");
            Console.ResetColor();
        }



        if (getal <= 2)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Voer een getal in dat groter is dan 2.");
            Console.ResetColor();
        }

        for (int i = 2; i < getal; i++)
        {
            if (getal % i == 0)
            {
                priem = false;
                break;
            }
        }

        if (priem)
        {
            Console.WriteLine($"{getal} is een priemgetal.");
        }
        else
        {
            Console.WriteLine($"{getal} is geen priemgetal.");
        }

        if (getal == 0)
        {
            Console.WriteLine("Het programma wordt afgesloten.");
            break;
        }
        for (int i = 2; i <= getal; i++)
        {
            if (getal % i == 0)
            {
                priem = false;
                break;
            }
        }
    }
}
