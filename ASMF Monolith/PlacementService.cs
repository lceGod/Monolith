using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMF_Monolith
{
    class PlacementService
    {
        public readonly Placement placement;
        private DataBase db;

        public PlacementService(string name)
        {
            db = new DataBase();
            placement = db.GetPlacement(name);
        }

        public void AddMaterial(string name, string unit)
        {
            var material = new Material(name, 0, unit, 0);

            db.AddMaterial(material, placement.Name);
            placement.Materials.Add(material);
        }

        public void DeleteMaterial(int materialIndex)
        {
            placement.Materials.RemoveAt(materialIndex);
            db.UpdateMaterailList(placement.Name, placement.Materials);
        }

        public bool TryChangeMaterialCount(double count, int materialIndex) 
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
