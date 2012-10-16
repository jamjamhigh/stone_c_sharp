using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stone
{
    public abstract class ASTree
    {
        public abstract ASTree child(int i);
        public abstract int numChildren();
        public abstract String location();
    }
}
