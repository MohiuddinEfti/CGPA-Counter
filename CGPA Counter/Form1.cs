using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CGPA_Counter
{
    public partial class CGP : Form
    {
        public CGP()
        {
            InitializeComponent();
        }
        public float a;
        public float b;
        public float c;
        public float d;
        public float ef;
        public float f;
        public float g;
        public float h;
        public float i;
        public float j;
        public float k;
        public float l;
        public float m;
        public float n;
        public float o;
        public float p;
        public float q;
        public float x;
        float first;
        float second;
        float third;
        float fourth;
        float fifth;
        float sixth;
        float sevent;
        float eight;
        float nine;
        float first1;
        float second2;
        float third3;
        float fourth4;
        float fifth5;
        float sixth6;
        float sevent7;
        float eight8;
        float nine9;

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else if (textBox1.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            a = float.Parse(textBox1.Text);
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            else if (textBox2.Text == "0")
            {
                textBox2.Text = "0";
            }
            else if (textBox2.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            b = float.Parse(textBox2.Text);
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
            else if (textBox4.Text == "0")
            {
                textBox4.Text = "0";
            }
            else if (textBox4.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            c = float.Parse(textBox4.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            else if (textBox3.Text == "0")
            {
                textBox3.Text = "0";
            }
            else if (textBox3.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            d = float.Parse(textBox4.Text);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "0";
            }
            else if (textBox6.Text == "0")
            {
                textBox6.Text = "0";
            }
            else if (textBox6.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            ef = float.Parse(textBox6.Text);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
            if (textBox5.Text == "")
            {
                textBox5.Text = "0";
            }
            else if (textBox5.Text == "0")
            {
                textBox5.Text = "0";
            }
            else if (textBox5.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            f = float.Parse(textBox5.Text);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "0";
            }
            else if (textBox8.Text == "0")
            {
                textBox8.Text = "0";
            }
            else if (textBox8.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            g = float.Parse(textBox8.Text);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
            }
            if (textBox7.Text == "")
            {
                textBox7.Text = "0";
            }
            else if (textBox7.Text == "0")
            {
                textBox7.Text = "0";
            }
            else if (textBox7.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            h = float.Parse(textBox7.Text);

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "0";
            }
            else if (textBox10.Text == "0")
            {
                textBox10.Text = "0";
            }
            else if (textBox10.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            i = float.Parse(textBox10.Text);

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox9.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox9.Text = textBox9.Text.Remove(textBox9.Text.Length - 1);
            }
            if (textBox9.Text == "")
            {
                textBox9.Text = "0";
            }
            else if (textBox9.Text == "0")
            {
                textBox9.Text = "0";
            }
            else if (textBox9.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            j = float.Parse(textBox9.Text);

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                textBox12.Text = "0";
            }
            else if (textBox12.Text == "0")
            {
                textBox12.Text = "0";
            }
            else if (textBox12.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            k = float.Parse(textBox12.Text);
          
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox11.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox11.Text = textBox11.Text.Remove(textBox11.Text.Length - 1);
            }
            if (textBox11.Text == "")
            {
                textBox11.Text = "0";
            }
            else if (textBox11.Text == "0")
            {
                textBox11.Text = "0";
            }
            else if (textBox11.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            l = float.Parse(textBox11.Text);

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text == "")
            {
                textBox18.Text = "0";
            }
            else if (textBox18.Text == "0")
            {
                textBox18.Text = "0";
            }
            else if (textBox18.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            m = float.Parse(textBox18.Text);

           
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox17.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox17.Text = textBox17.Text.Remove(textBox17.Text.Length - 1);
            }
            if (textBox17.Text == "")
            {
                textBox17.Text = "0";
            }
            else if (textBox17.Text == "0")
            {
                textBox17.Text = "0";
            }
            else if (textBox17.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            n = float.Parse(textBox17.Text);

           
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                textBox16.Text = "0";
            }
            else if (textBox16.Text == "0")
            {
                textBox16.Text = "0";
            }
            else if (textBox16.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            o = float.Parse(textBox16.Text);

           
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox15.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox15.Text = textBox15.Text.Remove(textBox15.Text.Length - 1);
            }
            if (textBox15.Text == "")
            {
                textBox15.Text = "0";
            }
            else if (textBox15.Text == "0")
            {
                textBox15.Text = "0";
            }
            else if (textBox15.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            p = float.Parse(textBox15.Text);

           
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text == "")
            {
                textBox14.Text = "0";
            }
            else if (textBox14.Text == "0")
            {
                textBox14.Text = "0";
            }
            else if (textBox14.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            q = float.Parse(textBox14.Text);

            
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox13.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox13.Text = textBox13.Text.Remove(textBox13.Text.Length - 1);
            }
            if (textBox13.Text == "")
            {
                textBox13.Text = "0";
            }
            else if (textBox13.Text == "0")
            {
                textBox13.Text = "0";
            }
            else if (textBox13.Text == ".")
            {
                MessageBox.Show("Your Value Is In-Valid");
            }
            x = float.Parse(textBox13.Text);

        }

        private void CGP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            float resultss = a * b + c * d + ef * f + g * h + i * j + k * l + m * n + o * p + q * x;
            float r = b+d+f+h+j+l+n+p+x;
            float result = resultss /r;
            Results.Text = result.ToString();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = textBox15.Text = textBox16.Text = textBox17.Text = textBox18.Text = string.Empty;
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if(textBox27.Text=="")
            {
                textBox27.Text = "0";
            }
            else if (textBox27.Text == ".")
            {
                MessageBox.Show("Invalid Value" );
            }
            first = float.Parse(textBox27.Text);
            if(textBox27.Text!="")
            {
                first1 = 1;
            }         
            else
            {
                first1 = 0;
            }


        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox26.Text == "")
            {
                textBox26.Text = "0";
            }
            else if (textBox26.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            second = float.Parse(textBox26.Text);
            if (textBox26.Text != "")
            {
                second2 = 1;
            }
            else if (textBox26.Text == "0")
            {
                second2 = 0;
            }
            else
            {
                second2 = 0;
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (textBox25.Text == "")
            {
                textBox25.Text = "0";
            }
            else if (textBox25.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            third = float.Parse(textBox25.Text);
            if (textBox25.Text != "")
            {
                third3 = 1;
            }
            else if (textBox25.Text == "0")
            {
                third3 = 0;
            }
            else
            {
                third3 = 0;
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (textBox24.Text == "")
            {
                textBox24.Text = "0";
            }
            else if (textBox24.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            fourth = float.Parse(textBox24.Text);
            if (textBox24.Text != "")
            {
                fourth4 = 1;
            }
            else if (textBox24.Text == "0")
            {
                fourth4 = 0;
            }
            else
            {
                fourth4 = 0;
            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (textBox23.Text == "")
            {
                textBox23.Text = "0";
            }
            else if (textBox23.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            fifth = float.Parse(textBox23.Text);
            if (textBox23.Text != "")
            {
                fifth5 = 1;
            }
            else if (textBox23.Text == "0")
            {
                fifth5 = 0;
            }
            else
            {
                fifth5 = 0;
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text == "")
            {
                textBox22.Text = "0";
            }
            else if (textBox22.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            sixth = float.Parse(textBox22.Text);
            if (textBox22.Text != "")
            {
                sixth6 = 1;
            }
            else if (textBox22.Text == "0")
            {
                sixth6 = 0;
            }
            else
            {
                sixth6 = 0;
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.Text == "")
            {
                textBox21.Text = "0";
            }
            else if (textBox21.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            sevent = float.Parse(textBox21.Text);
            if (textBox21.Text != "")
            {
                sevent7 = 1;
            }
            else if (textBox21.Text == "0")
            {
                sevent7 = 0;
            }
            else
            {
                sevent7 = 0;
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text == "")
            {
                textBox20.Text = "0";
            }
            else if (textBox20.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            eight = float.Parse(textBox20.Text);
            if (textBox20.Text != "")
            {
                eight8 = 1;
            }
            else if (textBox20.Text == "0")
            {
                eight8 = 0;
            }
            else
            {
                eight8 = 0;
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text == "")
            {
                textBox19.Text = "0";
            }
            else if (textBox19.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            nine = float.Parse(textBox19.Text);
            if (textBox19.Text != "")
            {
                nine9 = 1;
            }
            else if (textBox19.Text == "0")
            {
                nine9 = 0;
            }
            else
            {
                nine9 = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float cgp = first + second + third + fourth + fifth + sixth + sevent + eight + nine;
            float sem = first1 + second2 + third3 + fourth4 + fifth5 + sixth6 + sevent7 + eight8 + nine9;
            float resultSSS = cgp / sem;
            
            RESU.Text=resultSSS.ToString();
            textBox19.Text = textBox20.Text = textBox21.Text = textBox22.Text = textBox23.Text = textBox24.Text = textBox25.Text = textBox26.Text = textBox27.Text = string.Empty;

        }
    }
}
