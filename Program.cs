using System;
using System.Collections.Generic;
using System.Threading;
using Dealership.Models;

namespace DealerShip
{
    public class Program
    {
        public static void Main()
        { 
        Car ford = new Car("Ford Kuga", 380000, 2020);
        Car volvo = new Car("Volvo XC40 Recharge", 387000, 2022);
        Car nissan = new Car("1976 AMC Pacer", 3500000, 1969);

        Truck Ford = new Truck("Ford Maverick", 3000, 400000, 2018);
        Truck Hyundai = new Truck("Hyundai Santa Cruz", 2500, 350000, 2019);
        Truck Rivian = new Truck("Rivian R1T", 3500, 600000, 2020);

        ElectricCar Tesla = new ElectricCar("Tesla Model S", 80, 900000, 2021);
        ElectricCar Mini = new ElectricCar("Mini Cooper SE", 33, 285000, 2020);
        ElectricCar Audi = new ElectricCar("Audi etron", 33, 799000, 2019);

        List<Car> Cars = new List<Car>() {ford, volvo, nissan};
        List<Truck> Truck = new List<Truck>() {Ford, Hyundai, Rivian};
        List<ElectricCar> ElectricCar = new List<ElectricCar>() {Tesla, Mini, Audi};

        Console.Clear();
        Console.WriteLine("Hej! Mit navn er Bob, og jeg hører at du er interesseret i at købe en bil:D Vi har mange forskellige kategorier, som kan ses nedenunder:");
        Console.WriteLine("-------------------");
        Console.WriteLine("1. Generelle biler");
        Console.WriteLine("2. Trucks");
        Console.WriteLine("3. Elektriske biler");
        Console.WriteLine("-------------------");
        Console.WriteLine("Tast nummeret på den kategori, som du gerne vil høre mere om.");
        Console.WriteLine("");
        String stringBilType = Console.ReadLine();
        Console.WriteLine("");

        Console.WriteLine("Indtast maks pris:");
        string stringMaxPrice = Console.ReadLine();

        Console.WriteLine("");

        Console.WriteLine("Din maksimums pris er " + stringMaxPrice + " kr. Giv mig to sekunder, jeg kigger lige i databasen.");

        Thread.Sleep(1000); // 1000 milliseconds søgetid
        Console.Beep(1000,100);
        Console.WriteLine(".");
        Thread.Sleep(1000); // 1000 milliseconds søgetid
        Console.Beep(1000,100);
        Console.WriteLine(".");
        Thread.Sleep(1000); // 1000 milliseconds søgetid
        Console.Beep(1000,100);
        Console.WriteLine(".");
        Thread.Sleep(1000); // 1000 milliseconds søgetid
        Console.Beep(1000,100);
        Console.WriteLine(".");
        Console.WriteLine("");

        uint maxPrice = uint.Parse(stringMaxPrice);

        if (stringBilType == "1")
        {
            List<Car> CarsMatchingSearch = new List<Car>(0);

            foreach(Car automobile in Cars)
            {
                if(automobile.WorthBuying(maxPrice))
                {
                    CarsMatchingSearch.Add(automobile);
                }
            }
            foreach(Car automobile in CarsMatchingSearch)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------");
            Console.WriteLine(automobile.GetModel());
            Console.WriteLine(automobile.GetYear()+" year");
            Console.WriteLine("DKK "+ automobile.GetPrice());
            Console.WriteLine("-------------------");
            }

            if(CarsMatchingSearch.Count == 0)
            {
                Console.WriteLine("Vi har dsv. ingen biler, der matcher med din maks pris:( Kom igen en anden gang!");
                    return;
            } 
        }
        else if (stringBilType == "2")
        {
            List<Truck> CarsMatchingSearch = new List<Truck>(0);

            foreach(Truck automobile in Truck)
            {
                if(automobile.WorthBuying(maxPrice))
                {
                    CarsMatchingSearch.Add(automobile);
                }
            }
            foreach(Truck automobile in CarsMatchingSearch)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------");
            Console.WriteLine(automobile.GetModel());
            Console.WriteLine(automobile.GetLoad()+" kg");
            Console.WriteLine(automobile.GetYear()+" year");
            Console.WriteLine("DKK "+ automobile.GetPrice());
            Console.WriteLine("-------------------");
            }
            
            if(CarsMatchingSearch.Count == 0)
            {
                Console.WriteLine("Vi har dsv. ingen biler, der matcher med din maks pris:( Kom igen en anden gang!");
                return;
            } 
        }
        else if(stringBilType == "3")
        {
            List<ElectricCar> CarsMatchingSearch = new List<ElectricCar>(0);

            foreach(ElectricCar automobile in ElectricCar)
            {
                if(automobile.WorthBuying(maxPrice))
                {
                    CarsMatchingSearch.Add(automobile);
                }
            }
            foreach(ElectricCar automobile in CarsMatchingSearch)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------------");
            Console.WriteLine(automobile.GetModel());
            Console.WriteLine(automobile.GetBatterySize()+" kWh");
            Console.WriteLine(automobile.GetYear()+" year");
            Console.WriteLine("DKK "+ automobile.GetPrice());
            Console.WriteLine("-------------------");
            }

            if(CarsMatchingSearch.Count == 0)
            {
                Console.WriteLine("Vi har dsv. ingen biler, der matcher med din maks pris:( Kom igen en anden gang!");
                return;
            } 
        }

        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("");
        Console.WriteLine("Har du interesse i en af de følgende biler? (Ja/Nej)");
        string stringSvar = Console.ReadLine();
        
        Console.WriteLine("");

        if(stringSvar == "ja" || stringSvar == "Ja" )
            {
            Console.WriteLine("");
            Console.WriteLine("Hvilken bil kunne du tænke dig fra listen? Indtast modellen: \r\n");
            string modelSvar = Console.ReadLine();
            Console.WriteLine("\r\nDin "+ modelSvar + " er klar i morgen kl. 12.00... vi ses!");
            }
            else if (stringSvar == "nej" || stringSvar == "Nej")
            {
            Console.WriteLine("Okay, håber vi ses igen!");
            }

        }
           
    }
}

