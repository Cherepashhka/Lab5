using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public interface IEquipment
    {
        public string Name { get; set; }    
        public int Price { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public void ShowStats();
        public void ChangeStat();
    }
}
