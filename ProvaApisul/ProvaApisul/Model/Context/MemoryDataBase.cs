using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaApisul.Model.Context
{
    public class MemoryDataBase
    {
        private MemoryDataBase() {
            ListaVotos = new List<VotoElevador>();
        }

        private static MemoryDataBase _instance;

        public List<VotoElevador> ListaVotos { get; set; }

        public static MemoryDataBase GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MemoryDataBase();
            }
            return _instance;
        }
    }
}
