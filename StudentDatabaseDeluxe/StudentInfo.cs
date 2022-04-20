using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseDeluxe
{
    internal class StudentInfo
    {
        public string Name { get; set; }
        public string Hometown { get; set; }
        public string Food { get; set; }
        public string Color { get; set; }
        public string Animal { get; set; }
       
        private string characteristic;

        public StudentInfo(string _name, string _hometown, string _food, string _color, string _animal)
        {
            Name = _name;
            Hometown = _hometown;
            Food = _food;
            Color = _color;
            Animal = _animal;
        }

        public void info()
        {
            if(characteristic == "animal")
            {
                Console.WriteLine($"{Name} owns a {Animal}");
            }
            else
            {
                //tacos
                Console.WriteLine("Animals are cute");
            }
        }
    }
}
