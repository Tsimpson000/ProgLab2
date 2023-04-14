using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab2
{
    
    internal class InstrumentStore
    {

        List<Heaphones> _stock;

        public InstrumentStore()
        {
            _stock = new List<Heaphones>();
        }

        internal List<Heaphones> Stock { get => _stock; set => _stock = value; }

        public void AddHeadphones(Heaphones heaphones)
        {
            _stock.Add(heaphones);
        }
    }
}
