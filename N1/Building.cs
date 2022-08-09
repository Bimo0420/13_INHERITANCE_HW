using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class Building //родительский класс
    {
        string adress;
        double length;
        double width;
        double height;

        double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                    length = 0;
                else
                    length = value;
            }
        }
        double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                    width = 0;
                else
                    width = value;
            }
        }
        double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    height = 0;
                else
                    height = value;
            }
        }
        public Building (string adress, double length, double width, double height)
        {
            this.adress = adress; //инициализация полей
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            return $"{adress} {Length} {Width} {Height}";
            
        }

    }
}
