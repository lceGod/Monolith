using Domain;

namespace Backend
{
    public class PlacementService
    {
        public readonly Placement placement;
        private DataBase db;

        public PlacementService(DataBase db, String name)
        {
            this.db = db;
            placement = db.GetPlacement(name);
        }

        public PlacementService(string name) // Конструктор класса
        {
            db = new DataBase();
            placement = db.GetPlacement(name);
        }

        public void AddMaterial(string name, string unit) //Метод добавления материала в помещение
        {
            var material = new Material(name, 0, unit, 0);

            db.AddMaterial(material, placement.Name);
            placement.Materials.Add(material);
        }

        public void DeleteMaterial(int materialIndex) // Метод удаления материала из помещения 
        {
            placement.Materials.RemoveAt(materialIndex);
            db.UpdateMaterailList(placement.Name, placement.Materials);
        }

        public bool TryChangeMaterialCount(double count, int materialIndex) // Метод изменения количества материала 
        {
            if (placement.Materials[materialIndex].Count + count < 0) 
            {
                return false;
            }

            placement.Materials[materialIndex].Count += count;
            db.UpdateMaterailList(placement.Name, placement.Materials);

            return true;
        }
    }
}
