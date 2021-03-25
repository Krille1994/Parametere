using System;
using System.Reflection.Metadata;

namespace Parametere
{
    class Program
    {
        static void Main(string[] args)
        {
            SiHallo("Henrik");
            SiHallo("Erik");
            SiHallo("Flemming");
            SiHallo("Tobias");
            SiHallo("Sindre");
            SiHallo("Stian");
            Console.WriteLine();

            HundreX(1);
            HundreX(69);
            HundreX(420);
            HundreX(1337);
            Console.WriteLine();

            // Uten params nøkkelordet ville det sett sånn ut:
            // var listeMedBitches = new Folk(new string[] {"Henrik", "Flemming", "Stian", "Erik", "Sindre", "Tobias"})

            var listeMedBitches = new Folk("Henrik", "Flemming", "Stian", "Erik", "Sindre", "Tobias", "Sigve");

            var bitch = listeMedBitches.FindBitch("Kjell");
            Console.WriteLine(bitch);

            var bitch2 = listeMedBitches.FindBitch("Stian");
            Console.WriteLine(bitch2);
        }
            // Metode som tar imot en parameter typ string og skriver dette i consollen
        static void SiHallo(string navn)
        {
            Console.WriteLine($"Hallo {navn} :D");
        }

        // Metode som tar imot en parameter typ int og skriver ut tallet ganger 100

        static void HundreX(int tall)
        {
            Console.WriteLine(tall * 100);
        }
    }
}
