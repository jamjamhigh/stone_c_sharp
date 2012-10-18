/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stone
{
    public class ASTLeaf : ASTree
    {
        private static ArraySegment<ASTree> empty = new ArraySegment<ASTree>();
        protected Token token;
        private string p;
        public ASTLeaf(Token t) { token = t; }

        public ASTLeaf(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }
        public ASTree child(int i) { throw new IndexOutOfRangeException(); }
        public int numChildren() { return 0; }

        public String toString() { return token().getText(); }
        public String location() { return "at line" + token.getLineNumber(); }
        public Token token() { return token(); }
    }
}
*/