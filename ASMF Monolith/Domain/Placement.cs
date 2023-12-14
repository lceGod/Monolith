using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithMainForm
{
    class Placement
    {
        public String Name { get; set; }
        public List<Material> Materials { get; set; }
        public bool IsStorage { get; set; }

        public Placement(string login, bool isStorage) 
        {
            this.Name = login;
            this.IsStorage = isStorage;
        }

    }
}
