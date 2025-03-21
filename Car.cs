using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less2
{
    public struct Car
    {
        private string _number;
        private string _mark;
        private int _year_of_creating;
        private string _color;

        public Car(string number, string mark, int year_of_creating, string color)
        {
            _number = number;
            _mark = mark;
            _year_of_creating = year_of_creating;
            _color = color; 
        }


        public string Info
        {
            get { return $"Номер двигателя: {_number}, марка: {_mark}, год сборки: {_year_of_creating}, цвет: {_color}"; }
        }

        public string Compare(string temp_number)
        {
            string message = (temp_number == _number) ? "Номер совпадает" : "Номер не совпадает";
            return message;
        }

    }
}
