using Domain;

namespace Backend
{
    public class ManagerService
    {
        // Словарь который хранит информации о помещения вида Имя помещения - помещение
        private Dictionary<String, Placement> placements;
        
        // База данных
        private DataBase db;


        public ManagerService()
        {
            Update();
        }
        public ManagerService(string str)
        {
            if (str != "test") throw new Exception();

            placements = new Dictionary<String, Placement>();
        }

        // Возвращаем список материалов по имени помещения
        public List<Material> GetMaterialsList(string name) => placements[name].Materials;

        // Возвращаем список названий помещений
        public string[] GetPlacementNames() => placements.Keys.ToArray();

        // Метод обновления информации через повторное обращение к БД
        public void Update()
        {
            db = new DataBase();
            placements = new Dictionary<String, Placement>();
            var placementsList = db.GetPlacements();

            foreach (var placement in placementsList)
            {
                placements[placement.Name] = placement;
            }
        }

        // Метод добавления нового помещения
        public void AddPlacement(string name, string password, bool itIsStorage)
        {
            var placement = new Placement(name, itIsStorage);
            placements[name] = placement;
            //db.AddPlacement(placement, password);
        }

        // Проверка на существование помещения по имени
        public bool PlacementExist(string name) => placements.ContainsKey(name);
    }
}
