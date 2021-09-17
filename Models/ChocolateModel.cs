using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_Machine.Models
{
    public class ChocolateModel : HotDrinkModel
    {
        public ChocolateModel()
        {
            SetRecipe();
            AddName();
        }

        public void AddName()
        {
            NameList.Add("Chocolate");
        }


        public void SetRecipe()
        {
            Recipe.Add("Add drinking chocolate powder to the water");
            Recipe.Add("Pour chocolate in the cup");
            Recipe.Add("Your drink is ready....");
        }

    }
}
