using System.Net.Mail;
using System.Text.RegularExpressions;

namespace SUT23_Övning_iGrupp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> AnvändareLista = new List<string>();

            WelcomeMessage();
            Login();
            Navigation();
            
            SearchUser(AnvändareLista);

        }


        static void SearchUser(List<string> AnvändareLista)
        {

            string search = Console.ReadLine();

            if (((IList<string>)AnvändareLista).Contains(search))
            {
                foreach (var item in search)
                {
                    Console.WriteLine(AnvändareLista.Contains(search));
                }
                Console.WriteLine("Användare hittad!");
            }
            else
            {
                Console.WriteLine("Ingen användare hittades, sök igen!");
            }



        }
        public static List<string[]> Registrera()
        {
            Console.WriteLine("Hejsan, skriv ditt namn :");
            string Namn = Console.ReadLine();
            Console.WriteLine("Personnummer: ");
            string Pnummer = Console.ReadLine();
            Console.WriteLine("Epost: ");
            string Epost = Console.ReadLine();
            Console.WriteLine("Adress :");
            string Adress = Console.ReadLine();
            Console.WriteLine("Te´lefonnumer: ");
            string Tele = Console.ReadLine();



            string[] namn = { Namn };
            string[] PNummer = { Pnummer };
            string[] epost = { Epost };
            string[] adress = { Adress };
            string[] tele = { Tele };





            List<string[]> Andänvarelista = new List<string[]>();



            Andänvarelista.Add(namn);
            Andänvarelista.Add(PNummer);
            Andänvarelista.Add(epost);
            Andänvarelista.Add(adress);
            Andänvarelista.Add(tele);





            return Andänvarelista;



        }

        static void Login()
        {
            bool keepGoing = true;
            while (keepGoing)
            {



                string[] users = { "anas", "philip", "rasmus", "jonathan" };
                Console.WriteLine("Var god skriv in ditt användarnamn:");
                string username = Console.ReadLine().ToLower();
                foreach (string user in users)
                {



                    if (username == user)
                    {
                        Console.WriteLine($"Välkommen: {username}");
                        keepGoing = false;
                    }
                }

                if (keepGoing)
                {



                    Console.WriteLine("Fel användarnamn, försök igen");
                }




            }
        }

        public static string[] RegistreraAnvändare()
        {



            string Namn = Console.ReadLine();
            string Personnummer = Console.ReadLine();
            string Epost = Console.ReadLine();





            string[] användare = { Namn, Personnummer, Epost };





            return användare;


        }

        public static void IsMailValid()
        {

            Console.WriteLine("Skriv in din mail!");
            var email = Console.ReadLine();
            try
            {
                Console.Clear();
                Thread.Sleep(500);
                MailAddress mail = new MailAddress(email);
                Console.WriteLine("Rätt format!");
            }
            catch (Exception e)
            {
                Console.Clear();
                Thread.Sleep(500);
                Console.WriteLine("Fel format!");
            }
        }
        public static bool Personnumr()
        {
            string[] personnummerArray = new string[1];

            Console.Write("Ange ett personnummer (YYYYMMDD-XXXX): ");
            string input = Console.ReadLine();

            personnummerArray[0] = input;
            string pattern = @"^(19|20)\d{2}(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])-\d{4}$";
            if (Regex.IsMatch(input, pattern))
            {

                Console.WriteLine("Valid");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid");
                return false;
            }



        }
        public static void HittaPostort()
        {



            string[] postnummer = { "43232", "41101", "21110", "30220", "11111" };
            string[] postort = { "Varberg", "Göteborg", "Malmö", "Halmstad", "Stockholm" };



            Console.WriteLine("Vad är ditt postnummer?");
            Console.WriteLine(postnummer);
            string input = Console.ReadLine();



            if (input == postnummer[0])
            {
                Console.WriteLine("Din postort är : " + postort[0]);
                Console.ReadLine();
            }
            if (input == postnummer[1])
            {
                Console.WriteLine("Din postort är : " + postort[1]);
                Console.ReadLine();
            }
            if (input == postnummer[2])
            {
                Console.WriteLine("Din postort är : " + postort[2]);
                Console.ReadLine();
            }
            if (input == postnummer[3])
            {
                Console.WriteLine("Din postort är : " + postort[3]);
                Console.ReadLine();
            }
            if (input == postnummer[4])
            {
                Console.WriteLine("Din postort är : " + postort[4]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Finns ej");
            }


        }
        public static void WelcomeMessage()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Random random = new Random();
            string[] WMessages = new string[]
            {
                "Hej och Välkommen!",
                "Så kul att du är här!",
                "Välkommen till menyn",
                "Hoppas att din dag är fantastisk! :)",
                "Hello World",


            };
            string RandomMessage = WMessages[random.Next(WMessages.Length)];
            Console.WriteLine(RandomMessage);
            Console.WriteLine();



        }
        public static void Navigation()
        {
            bool myBool = true;
            while (myBool)
            {
                Console.WriteLine("[1- ID Check]");
                Console.WriteLine("[2- Check E-Mail]");
                Console.WriteLine("[3- Create USer]");
                Console.WriteLine("[4- Print User Info]");
                Console.WriteLine("[5- HittaPostort()]");
                Console.WriteLine("[5- Sök]");
                Console.WriteLine("[7-] Avsluta programmet");
                Console.Write("Välj mellan menyval 1-5: ");
                int.TryParse(Console.ReadLine(), out int menu);
                switch (menu)
                {
                    case 1:
                        
                        Console.Clear();
                        Console.WriteLine("Du valde menyval 1\n");
                        Personnumr();

                        break;



                    case 2:
                        Console.Clear();
                        Console.WriteLine("Du valde menyval 2\n");
                        IsMailValid();

                        break;



                    case 3:
                        Console.Clear();
                        Console.WriteLine("Du valde menyval 3\n");
                        Registrera();
                        break;



                    case 4:
                        Console.Clear();
                        Console.WriteLine("Du valde menyval 4\n");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Du valde menyval 4\n");
                        HittaPostort();
                        break;

                    

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Du valde menyval 5, nu avslutas programmet...\n");
                        myBool = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ogiltigt menyval...\n");
                        break;



                }
            }

        }
    }
}