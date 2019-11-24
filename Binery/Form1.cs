using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binery
{
    
    public partial class Form1 : System.Windows.Forms.Form
    {
        
        







        public Form1()
        {
            InitializeComponent();


        }


        private void Button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (input == "")
            {
               MessageBox.Show("Error!");



            }

            else
            {
                
                int inpu = Convert.ToInt32(input);
                string binary = Convert.ToString(inpu, 2);
                textBox1.Text = (binary);

            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}