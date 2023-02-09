using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsCalc
{
    public partial class Form1 : Form
    {

        calcService calcService = new calcService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
           addBox.Value = calcService.Add(inputBox1.Value, inputBox2.Value);
           subBox.Value = calcService.Subtract(inputBox1.Value, inputBox2.Value);
           multBox.Value = calcService.Multiply(inputBox1.Value, inputBox2.Value);
           divBox.Value = calcService.Divide(inputBox1.Value, inputBox2.Value);
        }
    }
}
