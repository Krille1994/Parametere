using System.Collections.Generic;

namespace Parametere
{
    public class Folk
    {
        public List<string> MyBitches;


        public Folk(params string[] mybiches)
        {
            MyBitches = new List<string>(mybiches);
        }

        // Metode som tar imot en parameter typ string og ser om den finnes i listen MyBitches og skriver ut hallo til den bitchen

        public string FindBitch(string bitch)
        {
            foreach (var t in MyBitches)
            {
                if (t == bitch)
                {
                    return $"Du er min bitch {t}";
                }
            }
            return $"Fant ingen bitch med navn {bitch}. Vil du bli min bitch?";
        }
    }
}