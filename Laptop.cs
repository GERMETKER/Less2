using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less2
{
    public class Laptop
    {
        private string _model_name;
        private int _tactic_chastota;
        private int _operV;
        private int _discV;
        double _mass;


        public string Model_name
        {
            get { return _model_name; }
            set { _model_name = value; }
        }

        public int Tactic_chastota
        {
            get { return _tactic_chastota; }
            set { _tactic_chastota = value; }
        }

        public int OperV
        {
            get { return _operV; }
            set { _operV = value; }
        }

        public int DiscV
        {
            get { return _discV; }
            set { _discV = value; }
        }

        public double Mass
        {
            get { return _mass; }
            set { _mass = value; }
        }


        public Laptop(string model_name, int tactic_chastota, int operV, int discV, double mass)
        {
            _model_name = model_name;
            _discV = discV;
            _mass = mass;
            _tactic_chastota = tactic_chastota;
            _operV = operV;
        }

        public string Info
        {
            get
            {
                return $"Модель: {_model_name}, Тактическая частота: {_tactic_chastota}, Объём преативной памяти: {_operV}," +
                $" Объём жёсткого диска {_discV}, Масса: {_mass}";
            }
        }
    }
}
