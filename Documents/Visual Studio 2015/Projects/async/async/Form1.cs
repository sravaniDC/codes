using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int countcharacters()
        { int count = 0;
            using (StreamReader reader = new StreamReader("C:\\text\\data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(50000);
            }
            return count;
        }

        private void btnprocess_Click(object sender, EventArgs e)
        {
            LBLcount.Text = "processing file please wait...";
            int count = countcharacters();
            LBLcount.Text = count.ToString() + "characters in file";
        }

       
    }
}
