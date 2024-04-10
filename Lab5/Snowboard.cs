using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Snowboard: IEquipment
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public double MaxSpeed { get; set; } = 203;
        public float BoardMetresLength { get; set; }
        public Snowboard()
        {
            Name = "Snowboard";
            Price = 300;
            Material = "";
            Color = "Purple";
            MaxSpeed = 203;
            BoardMetresLength = 1.65f;
        }
        public Snowboard(int _Price)
        {
            Name = "Snowboard";
            Price = _Price;
            Material = "Hardened impact-resistant plastic";
            Color = "Purple";
            MaxSpeed = 203;
            BoardMetresLength = 1.65f;
        }
        public Snowboard(int _Price, string _Color, int _BoardMetresLength)
        {
            Name = "Snowboard";
            Price = _Price;
            Material = "Hardened impact-resistant plastic";
            Color = _Color;
            MaxSpeed = 203;
            BoardMetresLength = _BoardMetresLength;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Material: {Material}, Color: {Color}, Maximum Speed: {MaxSpeed}, Board Length (in metres): {BoardMetresLength}");
        }
        public double MaxSpeedCalculate()
        {
            double Height, Result;
            do
            {
                Console.WriteLine("Write height of slide (from 0): ");
                Height = float.Parse(Console.ReadLine());
            }
            while (Height < 0);
            Result = Math.Sqrt(2 * 9.8 * Height);
            MaxSpeed = Result;
            return Result;
        }
        public void ChangeStat()
        {
            int Choice;
            do
            {
                Console.WriteLine("Choose:\n1. Price\n2. Color\n3. Board Length (in metres)");
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
                    BoardMetresLength = int.Parse(Console.ReadLine());
                }
                while (BoardMetresLength < 0);
            }
        }
    }
}
