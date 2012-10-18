/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stone
{
    public class BinaryExpr : ASTList
    {
        public BinaryExpr(List<ASTree> c) : base(c) { }
        public ASTree left() { return child(0); }
        public String operation() {
            return ((ASTLeaf)child(1)).token().getText();
        }
        public ASTree right(){ return child(2); }
    }
}
*/