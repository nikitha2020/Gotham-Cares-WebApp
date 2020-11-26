using System;
using System.Collections.Generic;
using System.Text;

namespace GothamCares.Entities
{
    class Outlet
    {
        public int id { get; set; }
        public  String name { get; set; }
        public String Streetname { get; set; }

        public String landmark { get; set; }

        public int Reqd_Volunteers { get; set; }

        public List<Food> Foods { get; set; }
    }
}
