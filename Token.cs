﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stone;

namespace stone
{
    public class Token
    {
        public static readonly Token EOF = new Token(-1) { };
        public static readonly String EOL = "\\n";
        private int lineNumber;
        
        protected Token(int line)
        {
            this.lineNumber = line;
        }

        public int getLineNumber() { return lineNumber; }
        public bool isIdentifier() { return false; }
        public bool isNumber() { return false; }
        public bool isString() { return false; }
        public int getNumber() { throw new StoneException("not number token"); }
        public String getText() { return ""; }
    }
}
