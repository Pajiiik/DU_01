using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class UC1_UK1 : UserControl
    {
        public UC1_UK1()
        {
            InitializeComponent();
        }
        void JeAlfanum(string _text,ref bool NumOrLet,ref int small_lett,ref int upper_lett,ref int NoALFNUM)
        {
            if (_text.All(Char.IsLetterOrDigit))
            {
                NumOrLet = true;
            }
            for (int counter = 0; counter < _text.Length; counter++)
            {
                if (_text[counter].ToString().All(Char.IsUpper))
                    upper_lett++;
                else if (_text[counter].ToString().All(Char.IsLower))
                    small_lett++;

                if (_text[counter].ToString().All(Char.IsLetterOrDigit) == false && NumOrLet == false)
                {
                   NoALFNUM++;
                }
            }


        }

        string _text;
        bool NumOrLet = false;
        int small_lett = 0, upper_lett = 0, NoALFNUM = 0;
        private void OK_Click(object sender, EventArgs e)
        {
            _text = textBox1.Text;
            JeAlfanum(_text,ref NumOrLet, ref small_lett, ref upper_lett, ref NoALFNUM);
            label1.Text = "Alfanumerické: " + NumOrLet.ToString();
            label2.Text = "Malá písmena:  " + small_lett.ToString();
            label3.Text = "Velka písmena: " + upper_lett.ToString();
            label4.Text = "Ne-Alfanumerické znaky: " + NoALFNUM.ToString();
        }
    }
}
