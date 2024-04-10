using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Ski: IEquipment
    {
        public int Price { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public int MaxSpeed { get; set; } = 252;
        public int RigidityIndex { get; set; }
    }
}
