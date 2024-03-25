using System;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Model Y", "Tesla", 2022, 100.0, 5, "Electric", "Automatic", false);
        Truck truck = new Truck("Sierra HD", "GMC", 2024, 150.0, 2.5, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Fat Boy 114", "Harley Davidson", 2023, 70.0, 1000, "Petrol", true);

        RentalAgency rentalAgency = new RentalAgency(10);

        rentalAgency.AddVehicle(car);
        rentalAgency.AddVehicle(truck);
        rentalAgency.AddVehicle(motorcycle);

        rentalAgency.DisplayFleetDetails();

        rentalAgency.RentVehicle(car, 7);

        rentalAgency.DisplayFleetDetails();

        Console.ReadKey();
    }
}
