using System;

namespace Class5_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[]
          {
                new Car("Chevrolet Camaro", new Driver("Jack",6),580),
                new Car("Lamborghini Huracan", new Driver ("Bob", 5),620),
                new Car("Nissan GT R", new Driver ("Mac", 7),565),
                new Car("BMW", new Driver ("Sam", 8),450),

          };

            Driver[] drivers = new Driver[]
            {
                new Driver("Jack",6),
                new Driver("Bob",5),
                new Driver("Mac",7),
                new Driver("Sam",8),
            };
            while (true)
            {

                Car firstCar = getACar(cars);
                Driver firstDriver = getADriver(drivers);


                Car secondCar = getACar(cars);
                Driver secondDriver = getADriver(drivers);

                Console.WriteLine($"First car:{firstCar.Model}, Driver:{firstDriver.Name}");
                Console.WriteLine($"Second car:{secondCar.Model}, Driver:{secondDriver.Name}");

                RaceCars(firstCar, secondCar, firstDriver, secondDriver);

                Console.WriteLine("Do you want to race again? If yes ==> enter Y");
                string input = Console.ReadLine();

                if (input.ToLower() == "y")
                {
                    continue;
                }
                break;
            }
        }
        public static Car getACar(Car[] cars)
        {
            Console.WriteLine("Choose a car:");
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}");
            }

            while (true)
            {
                string carModel = Console.ReadLine();

                foreach (Car car in cars)
                {
                    if (car.Model.ToLower() == carModel.ToLower())
                    {
                        return car;

                    }
                }
                Console.WriteLine("Wrong input, please try again:");
            }
        }
        public static Driver getADriver(Driver[] drivers)
        {
            Console.WriteLine("Choose a driver:");
            foreach (Driver driver in drivers)
            {
                Console.WriteLine($"{driver.Name}");
            }

            while (true)
            {
                string driverName = Console.ReadLine();
                foreach (Driver driver in drivers)
                {
                    if (driver.Name.ToLower() == driverName.ToLower())
                    {
                        return driver;
                    }
                }
                Console.WriteLine("Wrong input, please try again:");
            }
        }
        public static void RaceCars(Car firstCar, Car secondCar, Driver firstDriver, Driver secondDriver)
        {
            if (firstCar.CalculateSpeed() > secondCar.CalculateSpeed())
            {
                Console.WriteLine($"Car: {firstCar.Model}, Driver: {firstDriver.Name} won the race.");
            }
            else
            {
                Console.WriteLine($"Car: {secondCar.Model}, Driver: { secondDriver.Name} won the race.");
            }
        }
    }
}
