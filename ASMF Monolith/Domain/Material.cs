using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMF_Monolith
{
    class Material
    {
        public string Name { get; set; }

        private double count;
        public double Count 
        { 
            get { return count; } 
            set
            {
                if (value < 0) throw new Exception("ОТРИЦАТЕЛЬНОЕ ЗНАЧЕНИЕ"); //Проверка на целостность данных
                count = value; 
            }
        }
        private double limit;
        public double Limit
        {
            get { return limit;}
            set
            {
                if (value < 0) throw new Exception("ОТРИЦАТЕЛЬНОЕ ЗНАЧЕНИЕ"); //Проверка на целостность данных
                count = value;
                limit = value;
            }
        }
        public string Unit { get; set; }

        public Material(string name, double count, string unit, double limit) 
        {
            this.Name = name;
            this.Count = count;
            this.Unit = unit;
            this.Limit = limit;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Name, Math.Round(Count, 2), Unit); //Переопределение метода ToString для класса Material
        }

    }
}
