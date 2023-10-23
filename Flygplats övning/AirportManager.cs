using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flygplats_övning
{
    internal class AirportManager
    {
        List<Passagerare> passagerareList = new List<Passagerare>();
        List<Flygplan> flygplanList = new List<Flygplan>();
        List<Flights> flightList = new List<Flights>();
        bool quit = false;

        public AirportManager() 
        {
            passagerareList.Add(new Passagerare("Bob"));
            passagerareList.Add(new Passagerare("Jake"));
            passagerareList.Add(new Passagerare("Sarah"));
            passagerareList.Add(new Passagerare("Bengan"));
            passagerareList.Add(new Passagerare("Tori"));
            flygplanList.Add(new Flygplan("Ryan air", 5));
            flygplanList.Add(new Flygplan("Sas", 2));
            flygplanList.Add(new Flygplan("Jet time", 3));
        }
        public void MainMenu()
        {
            while (quit == false)
            {
                Console.Clear();
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1. Lista alla flygplanen.");
                Console.WriteLine("2. Lista alla passagerare.");
                Console.WriteLine("3. Skapa Flight.");
                Console.WriteLine("4. Lista flights.");
                Console.WriteLine("5. Lägg till passagerare i flight.");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ListFlygplan();
                        break;
                    case "2":
                        ListPassagerare();
                        break;
                    case "3":
                        CreateFlight();
                        break;
                    case "4":
                        ListFlights();
                        break;
                    case "5":
                        AddPassagerareToFlight();
                        break;
                }
            }
        }
        public void ListFlygplan()
        {
            Console.WriteLine("Flygplanen vi har är: ");
            foreach (Flygplan flygplan in flygplanList)
            {
                Console.WriteLine("Namn: " + flygplan.Name + ", Säten: " + flygplan.Seats + ", ID : " + flygplan.Id);
                
            }
            Console.WriteLine("Tryck Enter för att komma vidare: ");
            Console.ReadKey();
        }
        public void ListPassagerare()
        {
            Console.WriteLine("Passagerare som finns är: ");
            foreach (Passagerare passagerare in passagerareList)
            {
                Console.WriteLine("Namn: " + passagerare.Name + " ID : " + passagerare.Id);
            }
        }
        public void CreateFlight()
        {
            Console.Clear();
            bool flight = true;
            while (flight == true)
            {
                ListFlygplan();
                Console.WriteLine("Vilket flygplans id vill du lägga till i flighten: ");
                int input = int.Parse(Console.ReadLine());
                foreach (Flygplan flygplan in flygplanList)
                {
                    if (input == flygplan.Id)
                    {
                        flightList.Add(new Flights(flygplan));
                        return;
                    }
                }

            }
        }
        public void ListFlights()
        {
            Console.WriteLine("Flighter som finns är: ");
            foreach (Flights flights in flightList)
            {
                Console.WriteLine("Flight ID: " + flights.FlightNumber + " Flygplanet är: " + flights.Flygplan.Name);
                
                
            }
            Console.ReadKey();
        }
        public void AddPassagerareToFlight()
        {
            Console.Clear();
            bool loop = true;
            while (loop == true)
            {
                ListFlights();
                Console.WriteLine("Vilket Flight vill du lägga till passagerare till?");
                Console.WriteLine("Skriv in Flight ID");
                int input = int.Parse(Console.ReadLine());
                foreach (Flights flights in flightList)
                {
                    if (input == flights.FlightNumber)
                    {
                        ListPassagerare();
                        foreach (Passagerare passagerare in passagerareList)
                        {
                            Console.WriteLine("Vilken passagerare vill du lägga till?");
                            Console.WriteLine("Skriv in deras ID");
                            int input2 = int.Parse(Console.ReadLine());
                            if (input2 == passagerare.Id)
                            {
                                Console.WriteLine("Lägger till passagerare i flight.");
                                flightList.Add(new Flights(passagerare));
                                Console.ReadKey();
                                return;
                            }
                        }
                        
                    }
                }
            }
        }
    }
}
