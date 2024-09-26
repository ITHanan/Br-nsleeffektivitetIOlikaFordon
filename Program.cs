namespace BränsleeffektivitetIOlikaFordon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa en Console App som jämför bränsleeffektivitet i olika fordon. Vi måste använda 2 OOP Principer

            Console.WriteLine("Enter the amount of fuel consumed in liters ");
            string bränsleLiterSomString = Console.ReadLine()!;
            int bränsleLiter = Convert.ToInt32(bränsleLiterSomString);

            Console.WriteLine("Enter distans in KM");
            string distansSomString = Console.ReadLine()!;
            int KM = Convert.ToInt32(distansSomString);

           Vehicle ferrari = new Vehicle();
            ferrari.fuelconsumeing = bränsleLiter;
            ferrari.distancetraveling= KM;

            double eficientcy = ferrari.Calculatbränsleeffektivitet();
            Console.WriteLine($"bränsleFörbeukningen är :{eficientcy}");

            Console.WriteLine("Enter the amount of fuel consumed in liters ");
            string bränsleLiterLastbilSomString = Console.ReadLine()!;
            int bränsleLiterlastbil = Convert.ToInt32(bränsleLiterLastbilSomString);

            Console.WriteLine("Enter distans in KM");
            string distansSomStringlastbil = Console.ReadLine()!;
            int LastbilKM = Convert.ToInt32(distansSomStringlastbil);

            Lastbil scania = new Lastbil();
            scania.fuelconsumeing = bränsleLiterlastbil;
            scania.distancetraveling = LastbilKM;

            scania.bränsle = "diesel";


            double eficientcyscania = scania.Calculatbränsleeffektivitet();
            Console.WriteLine($"bränsleFörbeukningen är :{eficientcyscania}");

        }
    }
}
