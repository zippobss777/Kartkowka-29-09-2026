namespace Kartkówka
{
    /* Wiek ucznia - Napisz program, który pobiera wiek ucznia. Program
       ma zaakceptować wyłącznie liczbę całkowitą od 10 do 18. Jeśli poda
       liczbę poniżej 10 to komunikat za mało, jeśli powyżej 18 za dużo.
       Jeśli użytkownik poda tekstem liczbę dziesiętną albo wartość spoza
       zakresu, program ma wyświetlić odpowiedni komunikat. */
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("========================");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Podaj wiek ucznia: ");
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            string? wiek = Console.ReadLine();

            if (decimal.TryParse(wiek, out decimal wiekUcznia) && wiekUcznia >= 10 && wiekUcznia <= 18)
            {
                if (wiekUcznia >= 10 && wiekUcznia <= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"\nWiek wynosi: ");
                    Console.WriteLine($"{wiekUcznia}");
                }

                
            }
            else if (wiekUcznia < 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\nWiek jest za niski!");
            }

            else if (wiekUcznia > 18)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nWiek jest za wysoki!");
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
    }
}