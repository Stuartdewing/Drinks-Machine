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
            //NeedName();
            NameList = new List<string> { "Chocolate", "Lemon Tea", "Coffee" };
            //NameList.Add("Chocolate");
            //NameList.Add("Lemon Tea");
            //NameList.Add("Coffee");

        } 

           

        static void NeedName()
        {
            //dynamic Choc = new LemonTeaModel().AddName();
            


            //Console.WriteLine(Choc);

        }


            
        

        

    
     

    }
}
