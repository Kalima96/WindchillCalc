namespace WindchillCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool restart = true; //Bool variabel satt till true för att styra att programmet ska startas om sålänge användaren anger Ja

            while (restart) // while loopen delar samma variabel som boolen och håller programmet igång tills användaren väljer att avsluta
            {

                Console.WriteLine("Vill du starta windchillberäknaren?");
                Console.WriteLine("Ange Ja/Nej\n");

                string UserInput = Console.ReadLine().ToLower(); // skapar en string som sparar användarens val (ja) eller (nej)
                while (UserInput != "ja" && UserInput != "nej") // En till while loop som kontrollerar att användaren anger endast ja eller nej
                {
                UserInput = Console.ReadLine().ToLower(); // .ToLower() Gör så att stora bokstäver skrivs om till små i konsolen
                    
                }
                switch (UserInput) //Switch satsen Hanterar användarens val. Ifall de skriver ja så kommer programmet att börja räkna ut windchill, nej så avslutas det
                {
                    case "ja": // Ett verktyg för att hantera olika värden av en variabel. Koden körs om användaren skriver ja.
                        Console.WriteLine("Skriv in lufttemperaturen i Celsius\n");
                        string Userinput_Temp = Console.ReadLine(); // String variabel som sparar användarens val av temperatur.
                        double T = double.Parse(Userinput_Temp); // double T Håller lufttemperaturen som användaren matar in i Celsius som ett numeriskt värde.


                        Console.WriteLine("Skriv in vindhastigheten i km/h\n");
                        string Userinput_Vind = Console.ReadLine(); // String variabel som sparar användarens val av vindhastighet
                        double V = double.Parse(Userinput_Vind); // double V Håller vindhastigheten som användaren matar in i Km/h som ett numeriskt värde.

                        double WCT; //  double variabel för att lagra den beräknade windchill-faktorn.

                        // Formeln som används för att beräkna windchill temperaturen
                        WCT = 13.12 + (0.6215 * T) - (11.37 * Math.Pow(V, 0.16)) + (0.3965 * T * Math.Pow(V, 0.16));

                        Console.Write("\n");                  
                        Console.WriteLine("Uträkning klar\n");
                        
                        Console.WriteLine($"Det känns som {WCT:F1} Km/h"); // {F1} är förkortning på en float som är en formatsträng för att visa ett flyttal med decimaler.
                        
                        // Sorterar resultatet beroende på användarens val och vad beräkningen av Windchill temperaturen blir med hjälp av if och else sats.
                        if (WCT > -25)
                        {
                            Console.WriteLine("Kallt\n");
                        }
                        else if (-25 >= WCT && WCT >= -35)
                        {
                            Console.WriteLine("Mycket kallt\n");
                        }
                        else if (WCT <= -35 && WCT > -60)
                        {
                            Console.WriteLine("Risk för frostskada\n");
                        }
                        else
                        {
                            Console.WriteLine("Stor risk för frostskada\n");
                        }

                        break; // används för att avsluta caset och hoppar ut ur switch satsen


                    case "nej": // Om användaren väljer "nej" avslutas programmet.
                        restart = false; // Bool variabeln blir till false om användaren väljer nej vilket avslutar loopen och programmet.
                        Console.Write("\n");
                        Console.WriteLine("Programmet avslutas. Tack och hej!");

                        break;

                }
            }
        }
    }
}