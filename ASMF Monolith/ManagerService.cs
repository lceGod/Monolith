using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMF_Monolith
{
    class ManagerService
    {
        private Dictionary<String, Placement> Placements;

        private DataBase db;


        public ManagerService()
        {
            Update();
        }
        public List<Material> GetMaterialsList(string name)
        {
            return Placements[name].Materials;
        }
        public string[] GetPlacementNames() => Placements.Keys.ToArray();

        public void Update()
        {
            db = new DataBase();
            Placements = new Dictionary<String, Placement>();
            var placementsList = db.GetPlacements();

            foreach (var placement in placementsList)
            {
                Placements[placement.Name] = placement;
            }
        }

        public void AddPlacement(string name, string password, bool itIsStorage)
        {
            var placements = new Placement(name, itIsStorage);
            db.AddPlacement(placements, password);
            
        }

        public bool PlacementExist(string name) 
        {
            return Placements.ContainsKey(name);
        }

    }
}
