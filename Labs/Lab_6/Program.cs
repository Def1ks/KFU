using System;

namespace CarDemo
{
    public class Car
    {
        private readonly string _vin;
        private readonly int _yearOfManufacture;
        private string _brand;
        private string _model;
        private double _speed;
        private double _mileage;
        private double _fuelLevel;
        private bool _isEngineOn;
        private readonly double _maxSpeed;
        private readonly double _tankCapacity;

        public string Vin => _vin;
        public int YearOfManufacture => _yearOfManufacture;

        public string Brand
        {
            get => _brand;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Марка не может быть пустой.");
                _brand = value;
            }
        }

        public string Model
        {
            get => _model;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Модель не может быть пустой.");
                _model = value;
            }
        }

        public double Speed
        {
            get => _speed;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Speed), "Скорость не может быть отрицательной.");
                if (value > _maxSpeed)
                    throw new ArgumentOutOfRangeException(nameof(Speed), $"Скорость не может превышать {_maxSpeed} км/ч.");
                _speed = value;
            }
        }

        public double Mileage
        {
            get => _mileage;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Mileage), "Пробег не может быть отрицательным.");
                _mileage = value;
            }
        }

        public double FuelLevel
        {
            get => _fuelLevel;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(FuelLevel), "Уровень топлива не может быть отрицательным.");
                if (value > _tankCapacity)
                    throw new ArgumentOutOfRangeException(nameof(FuelLevel), $"Уровень топлива не может превышать ёмкость бака ({_tankCapacity} л).");
                _fuelLevel = value;
            }
        }

        public bool IsEngineOn => _isEngineOn;
        public double MaxSpeed => _maxSpeed;
        public double TankCapacity => _tankCapacity;

        public Car(string vin, int yearOfManufacture, string brand, string model,
                   double maxSpeed, double tankCapacity, double initialFuel = 0)
        {
            if (string.IsNullOrWhiteSpace(vin))
                throw new ArgumentException("VIN не может быть пустым.", nameof(vin));
            if (yearOfManufacture < 1886 || yearOfManufacture > DateTime.Now.Year + 1)
                throw new ArgumentOutOfRangeException(nameof(yearOfManufacture), "Некорректный год выпуска.");
            if (string.IsNullOrWhiteSpace(brand))
                throw new ArgumentException("Марка не может быть пустой.", nameof(brand));
            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Модель не может быть пустой.", nameof(model));
            if (maxSpeed <= 0)
                throw new ArgumentOutOfRangeException(nameof(maxSpeed), "Максимальная скорость должна быть положительной.");
            if (tankCapacity <= 0)
                throw new ArgumentOutOfRangeException(nameof(tankCapacity), "Ёмкость бака должна быть положительной.");
            if (initialFuel < 0 || initialFuel > tankCapacity)
                throw new ArgumentOutOfRangeException(nameof(initialFuel), $"Начальный уровень топлива должен быть от 0 до {tankCapacity}.");

            _vin = vin.ToUpperInvariant();
            _yearOfManufacture = yearOfManufacture;
            _brand = brand;
            _model = model;
            _maxSpeed = maxSpeed;
            _tankCapacity = tankCapacity;
            _speed = 0;
            _mileage = 0;
            _fuelLevel = initialFuel;
            _isEngineOn = false;
        }

        public void StartEngine()
        {
            if (_isEngineOn)
            {
                Console.WriteLine("Двигатель уже включён.");
                return;
            }
            if (_fuelLevel <= 0)
            {
                Console.WriteLine("Невозможно завести двигатель: бак пуст! Заправьте автомобиль.");
                return;
            }
            _isEngineOn = true;
            Console.WriteLine($"Двигатель {_brand} {_model} запущен.");
        }

        public void StopEngine()
        {
            if (!_isEngineOn)
            {
                Console.WriteLine("Двигатель уже выключен.");
                return;
            }
            if (_speed > 0)
            {
                Console.WriteLine($"Невозможно заглушить двигатель на скорости {_speed} км/ч! Сначала остановитесь.");
                return;
            }
            _isEngineOn = false;
            Console.WriteLine($"Двигатель {_brand} {_model} остановлен.");
        }

        public void Accelerate(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Величина ускорения должна быть положительной.");
                return;
            }
            if (!_isEngineOn)
            {
                Console.WriteLine("Невозможно ускориться: двигатель выключен. Заведите двигатель.");
                return;
            }
            double newSpeed = _speed + amount;
            if (newSpeed > _maxSpeed)
            {
                Console.WriteLine($"Нельзя превысить максимальную скорость ({_maxSpeed} км/ч). Текущая скорость: {_speed} км/ч.");
                return;
            }
            _speed = newSpeed;
            Console.WriteLine($"Скорость увеличена до {_speed} км/ч.");
        }

        public void Decelerate(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Величина торможения должна быть положительной.");
                return;
            }
            if (!_isEngineOn && _speed == 0)
            {
                Console.WriteLine("Автомобиль уже стоит.");
                return;
            }
            _speed = Math.Max(0, _speed - amount);
            Console.WriteLine($"Скорость снижена до {_speed} км/ч.");
        }

        public void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Количество топлива должно быть положительным.");
                return;
            }
            double newLevel = _fuelLevel + liters;
            if (newLevel > _tankCapacity)
            {
                double canAdd = _tankCapacity - _fuelLevel;
                Console.WriteLine($"Бак вмещает только {_tankCapacity} л. Сейчас {_fuelLevel} л. Можно долить максимум {canAdd:F1} л.");
                return;
            }
            _fuelLevel = newLevel;
            Console.WriteLine($"Заправлено {liters:F1} л. Уровень топлива: {_fuelLevel:F1} л из {_tankCapacity} л.");
        }

        public void Drive(double distanceKm, double fuelConsumptionPerKm = 0.08)
        {
            if (distanceKm <= 0)
            {
                Console.WriteLine("Расстояние должно быть положительным.");
                return;
            }
            if (!_isEngineOn)
            {
                Console.WriteLine("Невозможно ехать: двигатель выключен. Заведите двигатель.");
                return;
            }
            if (_speed == 0)
            {
                Console.WriteLine("Невозможно ехать: скорость равна 0. Ускорьтесь.");
                return;
            }
            double fuelNeeded = distanceKm * fuelConsumptionPerKm;
            if (_fuelLevel < fuelNeeded)
            {
                Console.WriteLine($"Недостаточно топлива! Нужно {fuelNeeded:F2} л, осталось {_fuelLevel:F1} л. Заправьтесь.");
                return;
            }
            _fuelLevel -= fuelNeeded;
            _mileage += distanceKm;
            Console.WriteLine($"Проехано {distanceKm} км. Расход топлива: {fuelNeeded:F2} л. Остаток: {_fuelLevel:F1} л. Общий пробег: {_mileage:F1} км.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"  {Brand} {Model}");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"  VIN:                  {Vin}");
            Console.WriteLine($"  Год выпуска:          {YearOfManufacture}");
            Console.WriteLine($"  Макс. скорость:       {MaxSpeed} км/ч");
            Console.WriteLine($"  Ёмкость бака:         {TankCapacity} л");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"  Двигатель:            {(_isEngineOn ? "Включён" : "Выключен")}");
            Console.WriteLine($"  Скорость:             {Speed} км/ч");
            Console.WriteLine($"  Пробег:               {Mileage:F1} км");
            Console.WriteLine($"  Топливо:              {FuelLevel:F1} л / {TankCapacity} л ({FuelLevel / TankCapacity * 100:F0}%)");
            Console.WriteLine(new string('=', 50));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var car = new Car(
                vin: "WBA3A5C55CF123456",
                yearOfManufacture: 2023,
                brand: "BMW",
                model: "X5 xDrive40i",
                maxSpeed: 250,
                tankCapacity: 83,
                initialFuel: 20
            );

            car.DisplayInfo();

            Console.WriteLine("\n>>> ДЕЙСТВИЯ НАД АВТОМОБИЛЕМ\n");

            Console.WriteLine("--- Попытка ехать с выключенным двигателем ---");
            car.Drive(100);

            Console.WriteLine("\n--- Заводим двигатель ---");
            car.StartEngine();

            Console.WriteLine("\n--- Ускоряемся ---");
            car.Accelerate(60);
            car.Accelerate(80);
            car.Accelerate(150);

            Console.WriteLine("\n--- Едем 50 км ---");
            car.Drive(50);

            Console.WriteLine("\n--- Тормозим ---");
            car.Decelerate(40);

            Console.WriteLine("\n--- Заправляем 50 л ---");
            car.Refuel(50);

            Console.WriteLine("\n--- Попытка заправить ещё 40 л ---");
            car.Refuel(40);

            Console.WriteLine("\n--- Едем ещё 200 км ---");
            car.Drive(200);

            Console.WriteLine("\n--- Полная остановка ---");
            car.Decelerate(car.Speed);
            car.StopEngine();

            Console.WriteLine("\n--- Попытка заглушить на ходу ---");
            car.StartEngine();
            car.Accelerate(30);
            car.StopEngine();
            car.Decelerate(30);
            car.StopEngine();

            Console.WriteLine("\n>>> ТЕКУЩЕЕ СОСТОЯНИЕ АВТОМОБИЛЯ\n");
            car.DisplayInfo();

            Console.WriteLine(">>> READ-ONLY СВОЙСТВА (нельзя изменить)\n");
            Console.WriteLine($"VIN: {car.Vin}");
            Console.WriteLine($"Год выпуска: {car.YearOfManufacture}");
            Console.WriteLine($"Макс. скорость: {car.MaxSpeed} км/ч");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}