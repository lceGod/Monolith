namespace Domain
{
    public class Material
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
            get { return limit; }
            set
            {
                if (value < 0) throw new Exception("ОТРИЦАТЕЛЬНОЕ ЗНАЧЕНИЕ"); //Проверка на целостность данных
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

        public bool Equals(Material material)
        {
            if (this.Name != material.Name) return false;
            else if (this.Count != material.Count) return false;
            else if (this.Unit != material.Unit) return false;
            else if (this.limit != material.Limit) return false;
            else return true;
        }

        public static bool operator ==(Material mat1, Material mat2)
        {
            return mat1.Equals(mat2);
        }
        public static bool operator !=(Material mat1, Material mat2)
        {
            return !mat1.Equals(mat2);
        }

    }
}
