using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMF_Monolith
{
    class Placement
    {
        public String Name { get; set; }
        public List<Material> Materials { get; set; }
        public bool IsStorage { get; set; } //Является ли складом помещение 

        public Placement(string login, bool isStorage) 
        {
            this.Name = login;
            this.IsStorage = isStorage;
        }

    }
}
