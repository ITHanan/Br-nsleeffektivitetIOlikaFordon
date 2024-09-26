

namespace BränsleeffektivitetIOlikaFordon
{
    public  class Vehicle
    {
        public int fuelconsumeing;
        public int distancetraveling;

        public virtual double Calculatbränsleeffektivitet()
        { 
            return fuelconsumeing / distancetraveling;
        }
    }


    public class Lastbil : Vehicle
    {
        public string bränsle;
        public override double Calculatbränsleeffektivitet()

        {
            int specialsiffra;

            if (bränsle == "diesel")
            {
                specialsiffra = 2;
            }

            else
            {
                specialsiffra = 5;
            };
            return fuelconsumeing / distancetraveling / specialsiffra;

          

        }

    }

    public class Car : Vehicle
    {
        public string  modell;
       

    }
    
}
