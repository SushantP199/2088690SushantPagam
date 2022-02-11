using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Async_Await_usage___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int count_Char_And_Return()
        {
            int count = 0;
            using(StreamReader reader=new StreamReader("C:\\Users\\Owner\\Desktop\\data.txt"))
            {
                string content = reader.ReadToEnd();
                count=content.Length;
            }
            Thread.Sleep(5000);

            return count;
        }

        private async void Count_Character(object sender, EventArgs e)
        {
            lblDisplay.Text = "Please wait I am counting the character";

            Task<int> task = new Task<int>(count_Char_And_Return);
            task.Start();
            int length = await task;

            lblDisplay.Text ="total number of char  is "+ length.ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {}
    }
}