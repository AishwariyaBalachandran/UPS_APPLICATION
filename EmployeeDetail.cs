using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPS_APPLICATION
{
    public class EmployeeDetail
    {
        public Int32 id { get; set; }
        public string name { get; set; }

        public string email { get; set; }
        public string gender { get; set; }
         
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
