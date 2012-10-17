

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace stone
{

    public class CodeDialog : LineNumberTextReader
    {
        private String buffer = null;
        private int pos = 0;

        public int read(String[] cbuf, int off, int len)
        {
            if (buffer == null)
            {
                String inpo = showDialog();
                if (inpo == null)
                    return -1;
                else
                {
                    Console.Write(inpo);
                    buffer = inpo + "\n";
                    pos = 0;
                }
            }

            int size = 0;
            int length = buffer.Length;
            while (pos < length && size < len)
            {
                cbuf[off + size++] = buffer.Substring(pos++);
            }

            if (pos == length)
                buffer = null;

            return size;
        }

        private string showDialog()
        {
            throw new NotImplementedException();
        }

        protected void print(String s)
        {
            Console.WriteLine(s);
        }
        public void close()
        {
        }
    }
}
