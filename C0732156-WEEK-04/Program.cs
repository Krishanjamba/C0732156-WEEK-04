using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732156_WEEK_04
{
    class Program


    {
        static void Main(string[] args)
        {
            Countryside blue = new Countryside();
            blue.Lunch();
        }
    }

    class village
    {
        /* Node is an ADT */
        // What kind of DATA do we need in a NODE? 
        public village nextVillage;
        public village previousvillage;
        public String VillageName;
        public bool isAstrildeHere = false;
    }
    class Countryside
    {
        village Maple = new village();
        village Toronto = new village();
        village Ajax = new village();

        village First;
        village Last;
        village temp;
       
      
        public void Lunch()
        {
           
            First = Maple;
            Last = Ajax;
            Maple.VillageName = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousvillage = null;
            Toronto.VillageName = "Toronto";
            Toronto.nextVillage = Ajax;
            Toronto.previousvillage = Maple;
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.previousvillage = Toronto;
            Console.WriteLine(this.displayMap());

        }
        public string displayMap()
        {
            string listOfCities = "";
            // What problem do I need to solve?
            // we need to print all the cities in our area

        listOfCities = listOfCities + First.VillageName;
                temp = First.nextVillage;
                listOfCities = listOfCities + temp.VillageName;
 
            return listOfCities;
        }
    }
}
