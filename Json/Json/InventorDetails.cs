using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Json
{
    class InventorDetails
    {
        public InventorDetails()
        {
            List<Inventor> list = new List<Inventor>();
            Inventor inventor1 = new Inventor("Rice", 35, 4000.00);
            Inventor inventor2 = new Inventor("pulses", 25, 5500.00);
            Inventor inventor3 = new Inventor("Wheat", 15, 7000.00);
            list.Add(inventor1);
            list.Add(inventor2);
            list.Add(inventor3);
            string Json = JsonConvert.SerializeObject(list);
            Console.WriteLine("Inventor details ");
            Console.WriteLine(Json);
        }

    }
}
