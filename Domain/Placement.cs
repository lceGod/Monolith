namespace Domain
{
    public class Placement
    {
        public String Name { get; set; }
        public List<Material> Materials { get; set; }
        public bool IsStorage { get; set; } //Является ли складом помещение 

        public Placement(string login, bool isStorage) 
        {
            this.Name = login;
            this.IsStorage = isStorage;
            Materials = new List<Material>();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Name, IsStorage); //Переопределение метода ToString для класса Placement
        }

        public bool Equals(Placement placement)
        {
            //if (placement == null) throw new ArgumentNullException();
            if (this.Name != placement.Name) return false;
            if (this.Materials.Count != placement.Materials.Count) return false;

            for (int i = 0; i < this.Materials.Count; i++)
            {
                if (!placement.Materials[i].Equals(this.Materials[i])) return false; 
            }
            return true;
        }
        public static bool operator ==(Placement place1, Placement place2)
        {
            return place1.Equals(place2);
        }
        public static bool operator !=(Placement place1, Placement place2)
        {
            return !place1.Equals(place2);
        }
    }
}
