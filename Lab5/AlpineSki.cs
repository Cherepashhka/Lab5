using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class AlpineSki: Ski, IEquipment
    {
        public bool ForFreeRide {  get; set; }
        public AlpineSki() :
            base()
        {
            Name = "AlpineSki";
            ForFreeRide = true;
        }
        public AlpineSki(int _Price) :
            base(_Price)
        {
            Name = "AlpineSki";
            ForFreeRide = true;
        }
        public AlpineSki(int _Price, string _Color, int _RidigityIndex) :
            base(_Price, _Color, _RidigityIndex)
        {
            Name = "AlpineSki";
            ForFreeRide = true;
        }
        public new void ShowStats()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Material: {Material}, Color: {Color}, Maximum Speed: {MaxSpeed}, Rigidity Index: {RigidityIndex}, For Free Ride: {ForFreeRide}");
        }
        public void ChangeStat()
        {
            int Choice;
            do
            {
                Console.WriteLine("Choose:\n1. Price\n2. Color\n3. Number Of Pockets\n4. For Free Ride?");
                Choice = int.Parse(Console.ReadLine());
            }
            while (Choice < 1 || Choice > 4);
            if (Choice != 4)
                Console.WriteLine("Enter new value for it: ");
            if (Choice == 1)
            {
                do
                {
                    Price = int.Parse(Console.ReadLine());
                }
                while (Price < 0);
            }
            else if (Choice == 2)
            {
                do
                {
                    Color = Console.ReadLine();
                }
                while (Color == string.Empty);
            }
            else if (Choice == 3)
            {
                do
                {
                    RigidityIndex = int.Parse(Console.ReadLine());
                }
                while (RigidityIndex < 0);
            }
            else
            {
                ForFreeRide = !ForFreeRide; 
                Console.WriteLine($"Changed on {ForFreeRide}.");
            }
        }
    }
}
