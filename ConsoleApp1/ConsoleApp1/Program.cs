using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class student
    {

        public string name { get; set; }
        public int course { get; set; }
        public int floor { get; set; }

        public student()
        {
            name = "";
            course = 0;
            floor = 0;
        }

        public void vvod()
        {
            Console.WriteLine("Добавление нового студента => ");
            Console.Write("Имя: ");
            name = Console.ReadLine();
            Console.Write("Курс: ");
            course = Convert.ToInt16(Console.ReadLine());
            Console.Write("Пол: ");
            floor = Convert.ToInt16(Console.ReadLine());
        }

        public void vivod()
        {
            Console.WriteLine("Имя: {0}, Курч: {1}, Пол {2}", name, course, floor);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            student.vvod();
            student.vivod();
            Console.ReadKey();
        }
    }
}
