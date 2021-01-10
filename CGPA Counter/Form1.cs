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
            if (comboBox1.Text=="")
            {
                textBox111.Visible=textBox222.Visible=textBox333.Visible=textBox444.Visible=textBox555.Visible=textBox666.Visible=textBox777.Visible=textBox888.Visible=textBox999.Visible=textBox1010.Visible=false;
                label1010.Visible=label111.Visible=label222.Visible=label333.Visible=label444.Visible=label55.Visible=label666.Visible=label777.Visible=label888.Visible=label999.Visible=false;
            }
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
            //textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = textBox15.Text = textBox16.Text = textBox17.Text = textBox18.Text = string.Empty;
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if(textBox111.Text=="")
            {
                textBox111.Text = "0";
            }
            else if (textBox111.Text == ".")
            {
                MessageBox.Show("Invalid Value" );
            }
            first = float.Parse(textBox111.Text);
            if(textBox111.Text!="")
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
            if (textBox222.Text == "")
            {
                textBox222.Text = "0";
            }
            else if (textBox222.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            second = float.Parse(textBox222.Text);
            if (textBox222.Text != "")
            {
                second2 = 1;
            }
            else if (textBox222.Text == "0")
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
            if (textBox333.Text == "")
            {
                textBox333.Text = "0";
            }
            else if (textBox333.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            third = float.Parse(textBox333.Text);
            if (textBox333.Text != "")
            {
                third3 = 1;
            }
            else if (textBox333.Text == "0")
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
            if (textBox444.Text == "")
            {
                textBox444.Text = "0";
            }
            else if (textBox444.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            fourth = float.Parse(textBox444.Text);
            if (textBox444.Text != "")
            {
                fourth4 = 1;
            }
            else if (textBox444.Text == "0")
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
            if (textBox555.Text == "")
            {
                textBox555.Text = "0";
            }
            else if (textBox555.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            fifth = float.Parse(textBox555.Text);
            if (textBox555.Text != "")
            {
                fifth5 = 1;
            }
            else if (textBox555.Text == "0")
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
            if (textBox666.Text == "")
            {
                textBox666.Text = "0";
            }
            else if (textBox666.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            sixth = float.Parse(textBox666.Text);
            if (textBox666.Text != "")
            {
                sixth6 = 1;
            }
            else if (textBox666.Text == "0")
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
            if (textBox777.Text == "")
            {
                textBox777.Text = "0";
            }
            else if (textBox777.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            sevent = float.Parse(textBox777.Text);
            if (textBox777.Text != "")
            {
                sevent7 = 1;
            }
            else if (textBox777.Text == "0")
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
            if (textBox888.Text == "")
            {
                textBox888.Text = "0";
            }
            else if (textBox888.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            eight = float.Parse(textBox888.Text);
            if (textBox888.Text != "")
            {
                eight8 = 1;
            }
            else if (textBox888.Text == "0")
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
            if (textBox999.Text == "")
            {
                textBox999.Text = "0";
            }
            else if (textBox999.Text == ".")
            {
                MessageBox.Show("Invalid Value");
            }
            nine = float.Parse(textBox999.Text);
            if (textBox999.Text != "")
            {
                nine9 = 1;
            }
            else if (textBox999.Text == "0")
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
            //textBox19.Text = textBox20.Text = textBox21.Text = textBox22.Text = textBox23.Text = textBox24.Text = textBox25.Text = textBox26.Text = textBox27.Text = string.Empty;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="2")
            {   
                textBox111.Visible=textBox222.Visible=true;
                label111.Visible=label222.Visible=true;
                textBox333.Visible=textBox444.Visible=textBox555.Visible=textBox666.Visible=textBox777.Visible=textBox888.Visible=textBox999.Visible=textBox1010.Visible=false;
                label333.Visible=label444.Visible=label55.Visible=label666.Visible=label777.Visible=label888.Visible=label999.Visible=label1010.Visible=false;
            }
            else if(comboBox1.Text=="3")
            {
                textBox111.Visible=textBox222.Visible=textBox333.Visible=true;
                label111.Visible=label222.Visible=label333.Visible=true;
                textBox444.Visible=textBox555.Visible=textBox666.Visible=textBox777.Visible=textBox888.Visible=textBox999.Visible=textBox1010.Visible=false;
                label444.Visible=label55.Visible=label666.Visible=label777.Visible=label888.Visible=label999.Visible=label1010.Visible=false;
            }
            else if(comboBox1.Text=="4")
            {
                textBox111.Visible=textBox222.Visible=textBox333.Visible=textBox444.Visible=true;
                label111.Visible=label222.Visible=label333.Visible=label444.Visible=true;
                textBox555.Visible=textBox666.Visible=textBox777.Visible=textBox888.Visible=textBox999.Visible=textBox1010.Visible=false;
                label55.Visible=label666.Visible=label777.Visible=label888.Visible=label999.Visible=label1010.Visible=false;
            }
            else if(comboBox1.Text=="5")
            {
                textBox111.Visible=textBox222.Visible=textBox333.Visible=textBox444.Visible=textBox555.Visible=true;
                label111.Visible=label222.Visible=label333.Visible=label444.Visible=label55.Visible=true;
                textBox666.Visible=textBox777.Visible=textBox888.Visible=textBox999.Visible=textBox1010.Visible=false;
                label666.Visible=label777.Visible=label888.Visible=label999.Visible=label1010.Visible=false;
            }
            else if(comboBox1.Text=="6")
            {
                textBox111.Visible=textBox222.Visible=textBox333.Visible=textBox444.Visible=textBox555.Visible=textBox666.Visible=true;
                label111.Visible=label222.Visible=label333.Visible=label444.Visible=label55.Visible=label666.Visible=true;
                textBox777.Visible=textBox888.Visible=textBox999.Visible=textBox1010.Visible=false; label777.Visible=label888.Visible=label999.Visible=label1010.Visible=false;
            }
            else if(comboBox1.Text=="7")
            {
                textBox111.Visible=textBox222.Visible=textBox333.Visible=textBox444.Visible=textBox555.Visible=textBox666.Visible=textBox777.Visible=true;
                label111.Visible=label222.Visible=label333.Visible=label444.Visible=label55.Visible=label666.Visible=label777.Visible=true;
                textBox888.Visible=textBox999.Visible=textBox1010.Visible=false; label888.Visible=label999.Visible=label1010.Visible=false;
            }
            else if(comboBox1.Text=="8")
            {
                textBox111.Visible=textBox222.Visible=textBox333.Visible=textBox444.Visible=textBox555.Visible=textBox666.Visible=textBox777.Visible= textBox888.Visible=true;
                label111.Visible=label222.Visible=label333.Visible=label444.Visible=label55.Visible=label666.Visible=label777.Visible=label888.Visible=true;
                textBox999.Visible=textBox1010.Visible=false; label999.Visible=label1010.Visible=false;
            }
            else if(comboBox1.Text=="9")
            {
                textBox111.Visible=textBox222.Visible=textBox333.Visible=textBox444.Visible=textBox555.Visible=textBox666.Visible=textBox777.Visible= textBox888.Visible=textBox999.Visible=true;
                label111.Visible=label222.Visible=label333.Visible=label444.Visible=label55.Visible=label666.Visible=label777.Visible=label888.Visible= label999.Visible=true;
                textBox1010.Visible=false; label1010.Visible=false;
            }
            else if(comboBox1.Text=="10")
            {
                textBox111.Visible=textBox222.Visible=textBox333.Visible=textBox444.Visible=textBox555.Visible=textBox666.Visible=textBox777.Visible=textBox888.Visible=textBox999.Visible=textBox1010.Visible=true;
                label1010.Visible=label111.Visible=label222.Visible=label333.Visible=label444.Visible=label55.Visible=label666.Visible=label777.Visible=label888.Visible=label999.Visible=true;
            }
            else
            {
                MessageBox.Show("There Is No Such Option");
                comboBox1.Text=string.Empty;
            }
            
          
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
    
}

