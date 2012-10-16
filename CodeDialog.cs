

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace stone{

public class CodeDialog : Reader
{
    private String buffer = null;
    private int pos = 0;

    public int read(char[] cbuf, int off, int len) {
        if(buffer == null){
            String inpo = showDialog();
            if(inpo == null)
                return -1;
            else{
                Console.Write(inpo);
                buffer = inpo + "\n";
                pos = 0;
            }
        }

        int size = 0;
        int length = buffer.Length;
        while(pos < length && size < len)
            cbuf[off + size++] = buffer.charAt(pos++);

        if(pos == length)
            buffer = null;

        return size;
    }

    protected void print(String s)
    {
        Console.Write(s);
    }
    public void close()
    {

    }
    protected String showDialog(){
        Form form = new Form();
        //省略

        int result = JOptionPane.showOptionDialog(null, Panel, "Input", JOptionPane.OK_CANCEL_OPTION,)
}

}