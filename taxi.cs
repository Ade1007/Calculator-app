using System;



    class Program
    {
        static void Main(string[] args)
        {
			Taxi taxi = new Taxi();
			
			
		    taxi.DriverName = "Jono";
			taxi.OnDuty = True;
			taxi.NumPassenger = 10;
			
			taxi.TaxiInfo();
			taxi.PickUpPassenger();
			taxi.DropOffPassenger();
			
			console.Readkey();
			  

		}
	}