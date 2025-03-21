using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Less2
{
    public struct Human
    {
        public string name;
        public string surname;
        public string patronymic;

        public Human(string name, string surname, string patronymic)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }


        public string FIO()
        {
            return $"ФИО: {surname} {name} {patronymic}";
        }
    }
}
