using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMF_Monolith
{
    static class ManagerService
    {
        static private Dictionary<String, Placement> Placements;

        static private DataBase db;


        static ManagerService()
        {
            Update();
        }
        public static List<Material> GetMaterialsList(string name)
        {
            return Placements[name].Materials;
        }
        public static string[] GetPlacementNames() => Placements.Keys.ToArray();

        public static void Update()
        {
            db = new DataBase();
            Placements = new Dictionary<String, Placement>();
            var placementsList = db.GetPlacements();

            foreach (var placement in placementsList)
            {
                Placements[placement.Name] = placement;
            }
        }

        public static void AddPlacement(string name, string password, bool itIsStorage)
        {
            var placements = new Placement(name, itIsStorage);
            db.AddPlacement(placements, password);
            
        }

        public static bool PlacementExist(string name) 
        {
            return Placements.ContainsKey(name);
        }

    }
}
