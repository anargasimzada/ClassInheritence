using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritence.Models
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public Boolean isGraduated;

        public Student(string name, string surname, string group, int point)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;

        }
        public Student()
        {
            bool result=false;
            if (Point < 65)
            {
                result = false;
            }
            else 
            {
                result = true;
            }

           

        }
        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Group} {Point}");
           
           
        }
        public void CheckGraduation()
        {
            bool result = false;
            if (Point < 65)
            {
                result = true;
                Console.WriteLine("telebe mezun olmayib");
               
            }
            else
            {
                result = false;
                Console.WriteLine("telebe mezun olub");
            }


          

        }
        public void GetDiplomDegree()
        {
            if (Point < 65)
            {
                Console.WriteLine("yoxdur");
            }
            else if (Point <= 80 && Point >= 65)
            {
                Console.WriteLine("adi");
            }
            else if (Point <= 90 && Point > 80)
            {
                Console.WriteLine("sheref");
            }
            else if (Point > 90)
            {
                Console.WriteLine("yuksek sheref");
            }
        }
    }
}
