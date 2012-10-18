using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using stone;

namespace Stone
{
    class StoneException : SystemException
    {
        public StoneException(String m) : base(m)
        {
        }
        /*
        public StoneException(String m, ASTree t) : base(m + " " + t.location())
        {
        }
         */
    }
}