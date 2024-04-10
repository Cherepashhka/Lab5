using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Ski: IEquipment
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public double MaxSpeed { get; set; }
        public int RigidityIndex { get; set; }
        public Ski()
        {
            Name = "Ski";
            Price = 300;
            Material = "Hardened impact-resistant plastic";
            Color = "Purple";
            MaxSpeed = 252;
            RigidityIndex = 41;
        }
        public Ski(int _Price)
        {
            Name = "Ski";
            Price = _Price;
            Material = "Hardened impact-resistant plastic";
            Color = "Purple";
            MaxSpeed = 252;
            RigidityIndex = 41;
        }
        public Ski(int _Price, string _Color, int _RidigityIndex)
        {
            Name = "Ski";
            Price = _Price;
            Material = "Hardened impact-resistant plastic";
            Color = _Color;
            MaxSpeed = 252;
            RigidityIndex = _RidigityIndex;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Material: {Material}, Color: {Color}, Maximum Speed: {MaxSpeed}, Rigidity Index: {RigidityIndex}");
        }
        public double MaxSpeedCalculate()
        {
            Console.WriteLine($"Calculating speed for {Name}");   
            double Height, Result;
            do
            {
                Console.WriteLine("Write height of slide (from 0): ");
                Height = float.Parse(Console.ReadLine());
            }
            while (Height < 0);
            Result = Math.Sqrt(2*9.8*Height);
            MaxSpeed = Result;
            return Result;
        }
        public void ChangeStat()
        {
            int Choice;
            do
            {
                Console.WriteLine("Choose:\n1. Price\n2. Color\n3. Rigidity Index");
                Choice = int.Parse(Console.ReadLine());
            }
            while (Choice < 1 || Choice > 3);
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
            else
            {
                do
                {
                    RigidityIndex = int.Parse(Console.ReadLine());
                }
                while (RigidityIndex < 0);
            }
        }
    }
}
