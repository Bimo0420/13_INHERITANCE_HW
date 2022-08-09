using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class MultiBuilding:Building //дочерний класс
    {
        int level;
        int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value < 0)
                    level = 0;
                else
                    level = value;
            }
        }
        public MultiBuilding(string adress, double length, double Width, double Height, int level)   //когда мы используем в род классе конструктор мы должны в дочернем классе оапределить конструктор и вызвать род конструктор через слово base
            : base(adress, length, Width, Height)
        {
            this.level = level; 
        }
        public string Print()
        {
            string result = base.Print();
            result += $" {level} этажей";
            return result;
        }
    }
}
