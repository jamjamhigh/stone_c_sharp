using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace stone
{
    class LineNumberTextReader : TextReader
    {
        private readonly TextReader reader;
        private int b;
        private int line;

        public LineNumberTextReader(TextReader reader)
        {
            if (reader == null) throw new ArgumentNullException("reader");
            this.reader = reader;
        }

        public int Line
        {
            get { return this.line; }
        }

        public override int Peek()
        {
            return this.reader.Peek();
        }

        public override int Read()
        {
            int b = this.reader.Read();
            if ((this.b == '\n') || (this.b == '\r' && b != '\n')) this.line++;
            return this.b = b;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) this.reader.Dispose();
        }
    }
}
