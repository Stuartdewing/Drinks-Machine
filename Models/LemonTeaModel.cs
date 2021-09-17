using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_Machine.Models
{

    public class LemonTeaModel : HotDrinkModel
    //This is lemontea model is based of hot drink model. 
    {
        public LemonTeaModel() 
        {
            SetRecipe();
        }

        public string AddName()
        {
            return "Lemon Tea";   
        }

        public void SetRecipe()
        {
            Recipe.Add("Steep the water in the tea");
            Recipe.Add("Pour tea in the cup");
            Recipe.Add("Add Lemon");
            Recipe.Add("Your drink is ready....");
        }

    }
}
