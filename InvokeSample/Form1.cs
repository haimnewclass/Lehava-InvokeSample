using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvokeSample
{
    public partial class Form1 : Form
    {
        
        RandomJob randomJob = new RandomJob();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            randomJob.sendToLabel = label1;
            label1.Text = randomJob.num;
                
        }
    }
}
