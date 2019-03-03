using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinsFormAppMathsOper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res = 0;
            if (rButtPlus.Checked == true)
            {
                res = Convert.ToInt32(tBoxA.Text) + Convert.ToInt32(tBoxB.Text);
            }
            else if (rButtMinus.Checked == true)
            {
                res = Convert.ToInt32(tBoxA.Text) - Convert.ToInt32(tBoxB.Text);
            }
            else if (rButtMult.Checked == true)
            {
                res = Convert.ToInt32(tBoxA.Text) * Convert.ToInt32(tBoxB.Text);
            }
            else if (rButtDiv.Checked == true)
            {
                res = Convert.ToInt32(tBoxA.Text) / Convert.ToInt32(tBoxB.Text);
            }
            tBoxResult.Text = res.ToString();
        }
    }
}
