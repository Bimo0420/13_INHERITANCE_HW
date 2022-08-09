using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1
{
    internal class Building //родительский класс
    {
        string Adress;
        double Length;
        double Width;
        double Height;

        double LENGTH
        {
            get
            {
                return Length;
            }
            set
            {
                if (value < 0)
                    Length = 0;
                else
                    Length = value;
            }
        }
        double WIDTH
        {
            get
            {
                return Width;
            }
            set
            {
                if (value < 0)
                    Width = 0;
                else
                    Width = value;
            }
        }
        double HEIGTH
        {
            get
            {
                return Height;
            }
            set
            {
                if (value < 0)
                    Height = 0;
                else
                    Height = value;
            }
        }
        public Building (string adress, double length, double width, double height)
        {
            this.Adress = adress; //инициализация полей
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            return $"{adress} {length} {width} {height}";
            
        }

    }
}
