using System;
using System.Collections.Generic;

namespace StrangeCompetition
{
    public interface IFlyable
    {
        void Fly();
        int FlightAltitude { get; }
    }

    public interface ISwimmable
    {
        void Swim();
        double SwimmingSpeed { get; }
    }

    public interface ITalkative
    {
        void Speak(string phrase);
    }

    public abstract class CompetitionEntity
    {
        public string Id { get; }
        public string Name { get; }
        public double Speed { get; protected set; }
        public int Intelligence { get; protected set; }

        protected CompetitionEntity(string id, string name, double speed, int intelligence)
        {
            if (string.IsNullOrWhiteSpace(id)) throw new ArgumentException("ID обязателен");
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Имя обязательно");

            Id = id;
            Name = name;
            Speed = speed;
            Intelligence = intelligence;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"Участник: {Name} (ID: {Id}) | Скорость: {Speed} | Интеллект: {Intelligence}");
        }
    }

    public abstract class LivingBeing : CompetitionEntity, ITalkative
    {
        public bool HasSoul { get; } = true;

        protected LivingBeing(string id, string name, double speed, int intelligence)
            : base(id, name, speed, intelligence) { }

        public virtual void Speak(string phrase)
        {
            Console.WriteLine($"{Name} говорит: \"{phrase}\"");
        }
    }

    public abstract class InanimateObject : CompetitionEntity
    {
        public bool HasBattery { get; protected set; }

        protected InanimateObject(string id, string name, double speed, int intelligence, bool hasBattery)
            : base(id, name, speed, intelligence)
        {
            HasBattery = hasBattery;
        }

        public void MakeSound(string sound)
        {
            Console.WriteLine($"{Name} издает звук: {sound}");
        }
    }

    public class Human : LivingBeing, ISwimmable
    {
        public bool HasLegs { get; } = true;

        public Human(string id, string name, int intelligence)
            : base(id, name, 25.0, intelligence) { }

        public void Swim()
        {
            Console.WriteLine($"{Name} плывет кролем.");
        }

        public double SwimmingSpeed => 5.0;
    }

    public class Cat : LivingBeing
    {
        public bool HasLegs { get; } = true;

        public Cat(string id, string name)
            : base(id, name, 48.0, 60) { }

        public override void Speak(string phrase)
        {
            Console.WriteLine($"{Name} мяукает: \"{phrase}\"");
        }
    }

    public class Drone : InanimateObject, IFlyable
    {
        public bool HasLegs { get; } = false;

        public Drone(string id, string name, double speed)
            : base(id, name, speed, 100, hasBattery: true) { }

        public void Fly()
        {
            Console.WriteLine($"{Name} взлетает на винтах.");
        }

        public int FlightAltitude => 120;
    }

    public class MagicBall : InanimateObject, IFlyable
    {
        public bool HasLegs { get; } = false;

        public MagicBall(string id, string name, int intelligence)
            : base(id, name, 80.0, intelligence, hasBattery: false) { }

        public void Fly()
        {
            Console.WriteLine($"{Name} парит в воздухе, издавая свечение.");
        }

        public int FlightAltitude => 50;
    }

    public class MechanicalSpider : InanimateObject, ISwimmable
    {
        public bool HasLegs { get; } = true;

        public MechanicalSpider(string id, string name)
            : base(id, name, 30.0, 80, hasBattery: true) { }

        public void Swim()
        {
            Console.WriteLine($"{Name} перебирает лапками в воде.");
        }

        public double SwimmingSpeed => 2.0;
    }

    public class UnknownObject : CompetitionEntity, IFlyable, ISwimmable, ITalkative
    {
        public bool HasLegs { get; } = false;
        public string EnergySource { get; } = "Неизвестно";

        public UnknownObject(string id, string name)
            : base(id, name, 999.0, 9999) { }

        public void Fly() => Console.WriteLine($"{Name} исчезает в вспышке света (полет).");
        public int FlightAltitude => 10000;

        public void Swim() => Console.WriteLine($"{Name} проходит сквозь воду как призрак.");
        public double SwimmingSpeed => 100.0;

        public void Speak(string phrase) => Console.WriteLine($"{Name} транслирует в мозг: \"{phrase}\"");
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<CompetitionEntity> participants = new List<CompetitionEntity>
            {
                new Human("H-001", "Иван Иванов", 120),
                new Cat("C-001", "Барсик"),
                new Drone("D-001", "Predator-X", 150.0),
                new MagicBall("M-001", "Орбита Хаоса", 50),
                new MechanicalSpider("MS-001", "ArachnoBot v2"),
                new UnknownObject("U-001", "Сфера #7")
            };

            Console.WriteLine("=== РЕГИСТРАЦИЯ УЧАСТНИКОВ ===\n");

            foreach (var entity in participants)
            {
                entity.Introduce();

                if (entity is ITalkative talker)
                    talker.Speak("Я готов к соревнованиям!");

                if (entity is IFlyable flyer)
                {
                    flyer.Fly();
                    Console.WriteLine($"  -> Высота полета: {flyer.FlightAltitude} м");
                }

                if (entity is ISwimmable swimmer)
                    swimmer.Swim();

                if (entity is LivingBeing living)
                    Console.WriteLine($"  -> Статус: Живое существо (Душа: {living.HasSoul})");

                if (entity is InanimateObject obj)
                    Console.WriteLine($"  -> Статус: Объект (Батарея: {obj.HasBattery})");

                Console.WriteLine(new string('-', 40));
            }

            Console.ReadKey();
        }
    }
}