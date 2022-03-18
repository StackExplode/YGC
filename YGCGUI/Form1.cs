using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using YGCLib;

namespace YGCGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Tester test = new Tester();
            textBox1.Text += test.Data.Data1.ToString() + "\r\n";
            test.Data.Data1 = 1999;
            textBox1.Text += test.Data.Data1.ToString() + "\r\n";
            
            foreach(var b in test.buffer.Reverse().ToArray())
            {
                textBox1.AppendText("-----------" + "\r\n");
                textBox1.AppendText(b.ToString() + "\r\n");
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //Process proc = Process.GetCurrentProcess();
            byte[] array = new byte[] {0, 1, 2, 3, 4, 5, 6, 7 };
            var arr = array.AsSpan()[1..4];
            arr[1] = 100;

        }
    }
}
