using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAPIConsumption
{
    class EmployeeModel
    {
        public class Rootobject
        {
            public People[] Property1 { get; set; }
        }

        public class People
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string nationality { get; set; }
        }

    }
}
