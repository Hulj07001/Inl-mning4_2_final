using System;
namespace inlämning4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int tal;
                int störst = 0; //Måste ha ett värde för att kunna jämföras och bytas ut.


                string svar = null;
                do
                {
                    Console.WriteLine("Skriv in ett heltal");
                    tal = int.Parse(Console.ReadLine());
                    Console.WriteLine("Vill du fortsätta? j/n.");
                    svar = Console.ReadLine().ToLower();

                    if (tal >= störst) //if satsen gör att om det givna "tal" är större än det nuvarande "störst" så byts "störst" ut med "tal".
                    {
                        störst = tal;
                    }

                } while (svar == "j");
                {
                    Console.WriteLine($"Det största talet du gav var: {störst}."); // $ dollatecknet gör att man kan ha en variabel inne i ett "".
                    Console.WriteLine("Avslutar programmet");
                }
            }
            catch
            {
                Console.WriteLine("OBS! Fel vid inmatning."); // Vid felinmatning så visas detta meddelande.
            }
        }
    }
}