using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less2
{
    public class Cat
    {
        string _name;
        double _weight;
        bool _sex;

        public string Name
        {
            set 
            {
                if (value != null) _name = value;
                else _name = "Кот";
            }
            get { return _name; }
        }

        public string Color { get; set; }

        public Cat() { }

        public Cat(string name) : this(name, 0.0, true) { }
        public Cat(string name, double weight) : this(name, weight, false) { }
        public Cat(string name, double weight, bool sex)
        {
            _name = name;
            _weight = weight;
            _sex = sex;
        }

        public void Meow()
        {
            Console.WriteLine("Мяу");
        }

        public string GetInfo()
        {
            var sex = _sex ? "мальчик" : "девочка";
            return $"кличка: {_name}, вес: {_weight}, " +
                $"пол: {sex}";
        }
    }
}
