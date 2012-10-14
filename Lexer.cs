using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO.StreamReader;


// これはリスト15.1にある字句解析器を手で書く、の方で書かれたコードです。
namespace stone
{
    class Lexer
    {
        private System.IO.StreamReader reader;
        private static readonly int EMPTY = -1;
        private int LastChar = EMPTY;
        private CodeDialog codeDialog;
        public Lexer(System.IO.StreamReader r) { reader = r; }

        public Lexer(CodeDialog codeDialog)
        {
            // TODO: Complete member initialization
            this.codeDialog = codeDialog;
        }
        private int getChar()
        {
            if (LastChar == EMPTY)
            {
                return reader.Read();
            }
            else
            {
                int c = LastChar;
                LastChar = EMPTY;
                return c;
            }
        }

        private void ungetChar(int c) { LastChar = c; }
        public String read(){
            StringBuilder sb = new StringBuilder();
            int c;
            do{
                c = getChar();
            } while (isSpace(c));

            if(c < 0){
                return null;
            }
            else if(isDigit(c)){
                do{
                    sb.Append((char)c);
                    c = getChar();
                } while(isDigit(c));
            }
            else if(isLetter(c)){
                do{
                    sb.Append((char)c);
                    c = getChar();
                } while (isLetter(c) || isDigit(c));
            }
            else if(c == '='){
                c = getChar();
                if(c == '='){
                    return "==";
                }
                else{
                    ungetChar(c);
                    return "=";
                }
            }
            else{
                
            }

            if(c >= 0){
                ungetChar(c);
            }

            return sb.ToString();
        }

        private static bool isLetter(int c)
        {
            return 'A' <= c && c <= 'Z' || 'a' <= c && c <= 'z';
        }
        private static bool isDigit(int c) { return '0' <= c && c <= '9'; }
        private static bool isSpace(int c) { return 0 <= c && c <= ' '; }
        private static void main(String[] args)
        {
            throw new Exception();

            Lexer l = new Lexer(new CodeDialog());
            for (String s; (s = l.read()) != null; )
            {
                Console.Write("-> " + s);
            }
        }
    }



    /*
    class Lexer
    {
        public static String regexPat =
            "\\s*((//.*)|([0-9]+)|(\"(\\\\\"|\\\\\\\\|\\\\n|[^\"]*\")"
            + "|[A-Z_a-z][A-Z_a-z0-9]*|==|<=|>=|&&|\\|\\||\\p{Punct})?";
        private Regex regex = new Regex(regexPat);
        private ArrayList<Token> queue = new ArrayList<Token>();
        private bool hasMore;
        private LineNumberTextReader reader;

        public Lexer(Stone.Reader r){
            hasMore = true;
            
    }
    */
}
