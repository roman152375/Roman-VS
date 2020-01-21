using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter7ProgramTableofSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool flag;
            int i;
            int j;
            int square;
            int nextOddInteger;
            int start;
            int end;
            string buff;
            flag = int.TryParse(txtStrtTbl.Text, out start);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input error");
                txtStrtTbl.Focus();
                return;
            }

            flag = int.TryParse(txtEndTbl.Text, out end);
            if (flag == false)
            {
                MessageBox.Show("Numeric data only", "Input Error");
                txtStrtTbl.Focus();
                return;
            }

            for (i = start; i <= end; i++)
            {
                //  buff = string.Format("{0, 5}{1, 20}", i, i * i);
                // lstOutput.Items.Add(buff);
                // }

                nextOddInteger = 1;
                square = 0;


                for (j = 0; j < i; j++)
                {
                    square += nextOddInteger;
                    nextOddInteger += 2;
                }
                buff = string.Format("{0, 5}{1, 20}", i, square);
                lstOutput.Items.Add(buff);

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStrtTbl.Clear();
            txtEndTbl.Clear();
            lstOutput.Items.Clear();
        }
    }
}
