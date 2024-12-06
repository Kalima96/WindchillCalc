namespace WindchillCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;

            while (restart)
            {

                Console.WriteLine("Vill du starta windchillberäknaren?");
                Console.WriteLine("Ange Ja/Nej\n");

                string UserInput = Console.ReadLine().ToLower();
                while (UserInput != "ja" && UserInput != "nej")
                {
                UserInput = Console.ReadLine().ToLower();

                }
                switch (UserInput)
                {
                    case "ja":
                        Console.WriteLine("Skriv in lufttemperaturen i Celsius");
                        Console.Write("\n");

                        string Userinput_Temp = Console.ReadLine();
                        double T = double.Parse(Userinput_Temp);


                        Console.WriteLine("Skriv in vindhastigheten i km/h");
                        Console.Write("\n");
                        string Userinput_Vind = Console.ReadLine();
                        double V = double.Parse(Userinput_Vind);

                        double WCT;

                        WCT = 13.12 + (0.6215 * T) - (11.37 * Math.Pow(V, 0.16)) + (0.3965 * T * Math.Pow(V, 0.16));

                        Console.Write("\n");                  
                        Console.WriteLine("Uträkning klar\n");
                        
                        Console.WriteLine($"Det känns som {WCT:F1} Km/h"); // {F1} är förkortning på en float som är en formatsträng för att visa ett flyttal med decimaler.
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

                        break;


                    case "nej":
                        restart = false;
                        Console.Write("\n");
                        Console.WriteLine("Programmet avslutas. Tack och hej!");

                        break;

                }
            }
        }
    }
}