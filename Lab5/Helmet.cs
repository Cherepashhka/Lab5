using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Helmet: IEquipment
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public Helmet() 
        {
            Name = "Helmet";
            Price = 300;
            Material = "Impact-resistant plastic";
            Color = "Purple";
            Size = "L";
        }
        public Helmet(int _Price)
        {
            Name = "Helmet";
            Price = _Price;
            Material = "Impact-resistant plastic";
            Color = "Purple";
            Size = "L";
        }
        public Helmet(int _Price, string _Color, string _Size)
        {
            Name = "Helmet";
            Price = _Price;
            Material = "Impact-resistant plastic";
            Color = _Color;
            Size = _Size;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Material: {Material}, Color: {Color}, Size: {Size}");
        }
        public void ChangeStat()
        {
            int Choice;
            do
            {
                Console.WriteLine("Choose:\n1. Price\n2. Color\n3. Number Of Pockets");
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
                    Size = Console.ReadLine();
                }
                while (Size == string.Empty);
            }
        }
    }
}
