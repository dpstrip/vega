using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vega.Model
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Make Make { get; set;} //This is a navigation property so I can call objects in reverse direction

        public int MakeId { get; set; } //This is to tell the system to worry about the foreign key
    }
}
