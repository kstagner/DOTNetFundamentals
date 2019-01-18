using System;
using System.Collections.Generic;

namespace MorningChallanges
{
    public class ProgramUI
    {
        private Customer _customer;
        private VehicleRepository _vehicleRepo;

        public ProgramUI()
        {
            _customer = new Customer();
            _vehicleRepo = new VehicleRepository();
        }

        public void Run()
        {
            Register();

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine($"Hello {_customer.FullName}\n" +


                    "What would you like to do?\n" +
                    "1. View Information\n" +
                    "2. Upate Information\n" +
                    "3. Register a Vehicle\n" +
                    "4. Exit Application\n");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {

                    case 1:
                        ViewInformation();
                        break;
                    case 2:
                        Register();
                        break;
                    case 3:
                        RegisterVehicle();
                        break;
                    case 4:
                        running = false;
                        break;



                }
            }
        }

        private void RegisterVehicle()
        {
            Console.WriteLine("Enter the make of vehicle here");
            string make = Console.ReadLine();

            Console.WriteLine("Enter the model of vehicle here");
            string model = Console.ReadLine();

            Console.WriteLine("Enter the year of vehicle here");
            string yearAsString = Console.ReadLine();
            int year = int.Parse(yearAsString);

            Console.WriteLine("Enter the mileage of vehicle");
            string mileageAsString = Console.ReadLine();
            int mileage = int.Parse(mileageAsString);



            Vehicle newVehicle = new Vehicle(make, model, year, mileage);
            _vehicleRepo.AddVehicleToList(newVehicle);
        }

        private void ViewInformation()
        {
            List<Vehicle> list = _vehicleRepo.GetVehicleList();

            decimal total = 0;
            foreach (Vehicle vehicle in list)

            {
                decimal premium = _vehicleRepo.CalculateVehiclePremium(vehicle);
                total = total + premium;
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                
            }
            if(_customer.Age >= 25)
            {
                total += 75;
            }
            else
            {
                total += 125;
            }
        }

        private void Register()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            _customer.FullName = Console.ReadLine();

            Console.WriteLine("Enter your age");
            string ageAsString = Console.ReadLine();
            _customer.Age = int.Parse(ageAsString);

            Console.WriteLine("Enter your gender: \n" +
            "1)Male 2)Female 3)Other");
            string genderAsString = Console.ReadLine();
            switch (genderAsString)
            {
                case "Male":
                case "1":
                    _customer.Gender = GenderType.male;
                    break;
                case "Female":
                case "2":
                    _customer.Gender = GenderType.female;
                    break;
                case "Other":
                case "3":
                    _customer.Gender = GenderType.other;
                    break;

            }

        }
    }
}