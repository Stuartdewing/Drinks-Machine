using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_Machine.Models
{
    public class ColdDrinkModel
    {
        public List<string> Recipe { get; set; }

        public string ChilledWater()
        {
            return "Pour Chilled Water";
        }

    } // Class

} // Namespace
// This is for furture changes to the drink machines should drinks other than hot be offered.