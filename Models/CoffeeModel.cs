using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_Machine.Models
{
    public class CoffeeModel : HotDrinkModel // Creating the class and using properties from HotDrinkModel
    {

        public string Name{ get; set; }
        public string Size { get; set; }

        public CoffeeModel() 
        {
            SetRecipe();
            Name = "John Doe";
        }


        public CoffeeModel(string customer, string size)
        {
            SetRecipe();
            Name = customer;
            Size = size;
        }

        public void AddName()
        {
            NameList.Add("Coffee");
        }

        public void SetRecipe()
         {
            Recipe.Add("Brew the coffee grounds");
            Recipe.Add("Pour coffee in the cup");
            Recipe.Add("Add sugar and milk");
            Recipe.Add("Your drink is ready.....");
        }
    }
}
