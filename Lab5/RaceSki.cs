using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class RaceSki: Ski, IEquipment
    {
        public bool FreestyleFriendly { get; set; }
        public RaceSki():
            base()
        {
            Name = "RaceSki";
            FreestyleFriendly = true;
        }
        public RaceSki(int _Price) :
            base(_Price)
        {
            Name = "RaceSki";
            FreestyleFriendly = true;
        }
        public RaceSki(int _Price, string _Color, int _RidigityIndex) :
            base(_Price, _Color, _RidigityIndex)
        {
            Name = "RaceSki";
            FreestyleFriendly = true;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Material: {Material}, Color: {Color}, Maximum Speed: {MaxSpeed}, Rigidity Index: {RigidityIndex}, Freestyle Friendly: {FreestyleFriendly}");
        }
        public void ChangeStat()
        {
            int Choice;
            do
            {
                Console.WriteLine("Choose:\n1. Price\n2. Color\n3. Number Of Pockets\n4. Friendly For Freestyle?");
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
                FreestyleFriendly = !FreestyleFriendly;
                Console.WriteLine($"Changed on {FreestyleFriendly}.");
            }
        }
    }
}
