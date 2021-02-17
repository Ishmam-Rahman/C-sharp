using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp
{
    class StaticAttribute
    {
        public static int objectcount = 0; //Common to all of the same class object
        
        public StaticAttribute()
        {
            objectcount++;
        }
    }
}
