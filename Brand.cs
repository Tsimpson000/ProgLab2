using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLab2
{
    public class Brand
    {
        public enum Brands {Pioneer, Sennheiser, Bose, Sony}

        Brands _brand;
        
        public Brand(Brands brand)
        {
            _brand = brand;
        }

        public override string ToString()
        {
            return $"{_brand}";
        }
    }
}
