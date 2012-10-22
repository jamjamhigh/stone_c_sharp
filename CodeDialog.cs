using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace stone
{
    public class CodeDialog : Form
    {
        private String buffer = null;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
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

        protected void print(String s) { Console.WriteLine(s); }

        private string showDialog()
        {
            throw new NotImplementedException();

            return textBox1.Text;
        }


        public void close()
        {
        }

        private void Form1()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.Load += new System.EventHandler(this.button_Click);
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 19);
            this.textBox1.TabIndex = 2;
            // 
            // CodeDialog
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "CodeDialog";
            this.Load += new System.EventHandler(this.CodeDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CodeDialog_Load(object sender, EventArgs e)
        {

        }

        public void button_Click(object sender, EventArgs e){
            showDialog();
        }
    }
}
