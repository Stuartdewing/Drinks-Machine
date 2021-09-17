using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_Machine.Models
{
    public class DrinkListModel
    {
        public List<string> NameList { get; set; }
        public DrinkListModel()
        {
            //TODO - Find way to make list dynamic from drink models.  
            NameList = new List<string> { "Chocolate", "Lemon Tea", "Coffee" };
        }





            
        

        

    
     

    }
}
