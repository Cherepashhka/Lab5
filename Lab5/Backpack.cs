using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Backpack: IEquipment
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public int PocketsNumber { get; set; }
        public Backpack() 
        {
            Name = "Backpack";
            Price = 300;
            Material = "Cordura";
            Color = "Purple";
            PocketsNumber = 6;
        }
        public Backpack(int _Price)
        {
            Name = "Backpack";
            Price = _Price;
            Material = "Cordura";
            Color = "White";
            PocketsNumber = 6;
        }
        public Backpack(int _Price, string _Color, int _PocketsNumber)
        {
            Name = "Backpack";
            Price = _Price;
            Material = "Cordura";
            Color = _Color;
            PocketsNumber = _PocketsNumber;
        }
        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Material: {Material}, Color: {Color}, Number Of Pockets: {PocketsNumber}");
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
                    PocketsNumber = int.Parse(Console.ReadLine());
                }
                while (PocketsNumber < 0);
            }
        }
    }
}
