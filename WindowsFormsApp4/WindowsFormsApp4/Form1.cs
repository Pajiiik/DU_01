using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC1_UK11.Visible = false;
        }
        int _btn_nam1 = 0, _btn_nam2 = 0, _btn_nam3 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            _btn_nam1++;

            if (_btn_nam1 == 1)
            {
                button1.BackColor = Color.RoyalBlue;
                uC1_UK11.Visible = true;
                _btn_nam2 = 0;
                _btn_nam3 = 0;
            }
            else 
            {
                button1.BackColor = Color.MediumBlue;
                uC1_UK11.Visible = false;
                _btn_nam1 = 0;
                _btn_nam2 = 0;
                _btn_nam3 = 0;
            }
            button2.BackColor = Color.MediumBlue;
            button3.BackColor = Color.MediumBlue;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            _btn_nam2++;
            if (_btn_nam2 == 1)
            {
                button2.BackColor = Color.RoyalBlue;
                uC1_UK11.Visible = false;
                _btn_nam1 = 0;
                _btn_nam3 = 0;
            }
            else
            {
                button2.BackColor = Color.MediumBlue;
                _btn_nam1 = 0;
                _btn_nam2 = 0;
                _btn_nam3 = 0;
            }
            button1.BackColor = Color.MediumBlue;
            button3.BackColor = Color.MediumBlue;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            _btn_nam3++;
            if (_btn_nam3 == 1)
            {
                button3.BackColor = Color.RoyalBlue;
                uC1_UK11.Visible = false;
                _btn_nam2 = 0;
                _btn_nam1 = 0;
            }
            else
            {
                button3.BackColor = Color.MediumBlue;
                _btn_nam1 = 0;
                _btn_nam2 = 0;
                _btn_nam3 = 0;
            }
            button1.BackColor = Color.MediumBlue;
            button2.BackColor = Color.MediumBlue;
        }
    }
}
