namespace Flygplats_övning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            AirportManager manager = new AirportManager();
            manager.MainMenu();
        }
    }
}