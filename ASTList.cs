using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stone
{
    public class ASTList : ASTree
    {
        protected List<ASTree> children;
        public ASTList(List<ASTree> list) { children = list; }
        public ASTree child(int i) { return children.get(i); }
        public int numChildren() { return children.size(); }
        
        public String toString(){
            StringBuilder builder = new StringBuilder();
            builder.Append('(');
            String sep = "";
            for(ASTree t : children){
                builder.Append(sep);
                sep = " ";
                builder.Append(t.ToString());
            }

            return builder.Append(')').ToString();
        }
        public String location(){
            for(ASTree t: children){
                String s = t.location();
                if(s != null){
                    return s;
                }
            }
            return null;
        }
    }
}
    }
}
