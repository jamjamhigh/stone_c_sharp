using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using stone;

namespace chapB
{
    public class ExprParser
    {
        private Lexer lexer;

        public ExprParser(Lexer p)
        {
            lexer = p;
        }

        public ASTree expression()
        {
            ASTree left = term();
            while (isToken("+") || isToken("-"))
            {
                ASTLeaf op = new ASTLeaf(lexer.read());
                ASTree right = term();
                left = new BinaryExpr(Array.asList(left, op, right));
            }
            return left;
        }
        public ASTree term()
        {
            ASTree left = factor();
            while (isToken("*") || isToken("/"))
            {
                ASTree op = new ASTLeaf(lexer.read());
            }
            return left;
        }
        public ASTree factor()
        {
            if (isToken("("))
            {
                token("(");
                ASTree e = expression();
                return e;
            }
            else
            {
                Token t = lexer.read();
                if (t.isNumber())
                {
                    NumberLiteral n = new NumberLiteral(t);
                    return n;
                }
                else
                {
                }
            }
        }
        void token(String name)
        {
            Token t = lexer.read();
            if (!(t.isIdentifier() && name.Equals(t.getText())))
            {
            }
        }
        bool isToken(String name)
        {
            Token t = lexer.peek(0);
            return t.isIdentifier() && name.Equals(t.getText());
        }
        public static void main(String[] args)
        {
            Lexer lexer = new Lexer(new CodeDialog());
            ExprParser p = new ExprParser(lexer);
            ASTree t = p.expression();
            Console.WriteLine("=> " + t);
        }
    }
}
