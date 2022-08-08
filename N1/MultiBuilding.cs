using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class MultiBuilding:Building //дочерний класс
    {
        int Level;
        int LEVEL
        {
            get
            {
                return Level;
            }
            set
            {
                if (value < 0)
                    Level = 0;
                else
                    Level = value;
            }
        }
        public MultiBuilding(string adress, double length, double Width, double Height, int level)   //когда мы используем в род классе конструктор мы должны в дочернем классе оапределить конструктор и вызвать род конструктор через слово base
            : base(adress, length, Width, Height)
        {
            this.Level = level; 
        }
        public string Print()
        {
            string result = base.Print();
            result += $" {Level} этажей";
            return result;
        }
    }
}
