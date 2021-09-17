using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_Machine.Models
{
    public class HotDrinkModel : DrinkListModel
    {
        public List<string> Recipe { get; set; } // This  is a property - Use a sorted list

        public HotDrinkModel()
        {
            Recipe = new List<string> { BoilWater() };
        }

        public string BoilWater()
        {
            return "Boil Water";
        }
    }
}
