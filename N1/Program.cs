using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1    //Задан класс Building, который описывает здание. Класс содержит следующие элементы:

//адрес здания;
//длина здания;
//ширина здания;
//высота здания.
//В классе Building нужно реализовать следующие методы:

//конструктор с 4 параметрами;
//свойства get/set для доступа к полям класса;
//метод Print(), который выводит информацию о здании.
//Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.В классе MultiBuilding реализовать следующие элементы:

//конструктор с 5 параметрами – реализует вызов конструктора базового класса;
//свойство get/set доступа к внутреннему полю класса;
//метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
//Класс MultiBuilding сделать таким, что не может быть унаследован.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building build = new Building("Brighton", -5, 20, 0);
            MultiBuilding mbuild = new MultiBuilding("Brighton", 10, 20, 30, 6);
            Console.WriteLine(build.Print());
            Console.WriteLine(mbuild.Print());
            Console.ReadKey();
        }
    }
}
