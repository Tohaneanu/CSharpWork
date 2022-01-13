using System;

namespace Tema4 // Note: actual namespace depends on the project name.
{
    public static class Program
    {
        abstract class Animal{}
        abstract class Bird:Animal{}
        abstract class Insect: Animal{}
        interface IFlyingCreature{}
       interface ICarnivore{}
        
        class Ostrich: Bird{}
        class Eagle: Bird, IFlyingCreature,ICarnivore{}
        class Bee: Insect,IFlyingCreature{}
        class Flea: Insect,ICarnivore {}
        
        [Flags]
        public enum AllMonths { Jan=1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }
      
        public static void Main(string[] args)
        {
            Console.WriteLine("Tema 4");
            int i = 0;
            foreach (string st in Enum.GetNames(typeof(AllMonths)))
            {
                i++;
                Console.WriteLine($"Luna numarul: {i}, cu numele: {st}" );  
            }

            AllMonths spring = AllMonths.Mar | AllMonths.Apr | AllMonths.May;
            AllMonths summer = AllMonths.Jun | AllMonths.Jul | AllMonths.Aug;
            AllMonths autum = AllMonths.Sep | AllMonths.Oct | AllMonths.Nov;
            AllMonths winter = AllMonths.Dec | AllMonths.Jan | AllMonths.Feb;
            Console.WriteLine($"All summer months: {summer}");

            Console.WriteLine("Anotimpul in care suntem: ");
            DateTime dt = DateTime.Now;
            int month = dt.Month;
            switch (month)
            {
                case var n when n < 6 && n > 2:
                    Console.WriteLine($"Primavara: {spring}");
                    break;
                case var n when n < 9 && n > 5:
                    Console.WriteLine($"Vara: {summer}");
                    break;
                case var n when n < 12 && n > 8:
                    Console.WriteLine($"Toamna: {autum}");
                    break;
                default:
                    Console.WriteLine($"Iarna: {winter}");
                    break;
            }

        }
    }
}