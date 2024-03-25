using System;

class RentalAgency
{
    // Array to store fleet of vehicles
    private Vehicle[] Fleet;
    private int count;
    // Property to track total revenue
    public double TotalRevenue { get; private set; }

    public RentalAgency(int capacity)
    {
        Fleet = new Vehicle[capacity];
        count = 0;
        TotalRevenue = 0;
    }

    // Method to add vehicle to fleet
    public void AddVehicle(Vehicle vehicle)
    {
        if (count < Fleet.Length)
        {
            Fleet[count++] = vehicle;
        }
        else
        {
            Console.WriteLine("Fleet is full, cannot add more vehicles.");
        }
    }

    // Method to remove vehicle from fleet
    public void RemoveVehicle(Vehicle vehicle)
    {
        int index = Array.IndexOf(Fleet, vehicle);
        if (index != -1)
        {
            Fleet[index] = null;
            count--;
        }
    }

    // Method to rent a vehicle
    public void RentVehicle(Vehicle vehicle, int days)
    {
        double rentalCost = vehicle.RentalPrice * days;
        TotalRevenue += rentalCost;
        Console.WriteLine($"Vehicle rented: {vehicle.Model} for {days} days. Total cost: ${rentalCost}");
        RemoveVehicle(vehicle);
    }

    public void DisplayFleetDetails()
    {
        Console.WriteLine("Fleet Details:");
        foreach (Vehicle vehicle in Fleet)
        {
            if (vehicle != null)
            {
                vehicle.DisplayDetails();
                Console.WriteLine();
            }
        }
    }
}