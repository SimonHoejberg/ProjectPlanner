using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPlanner.Database
{

    public class Data
    {
        private static List<Object> data = new List<Object>();

        public List<Object> Database { get { return data; } set { data = value; }}


    }
}
