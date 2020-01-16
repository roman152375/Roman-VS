using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6ProgramOddEven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            int val;
            string output = "Number is Even";
            flag = int.TryParse(txtNumber.Text, out val);
            if (flag == false)
            {
                MessageBox.Show("Not a number. Re-enter.");
                txtNumber.Clear();
                txtNumber.Focus();
                return;
            }
            output = (val % 2 == 0) ? "Number is Even" : "Number is Odd";
            lblOutput.Text = output;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
