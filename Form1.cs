using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace KomplexeCSharp
{
    public partial class Form1 : Form
    {
        double number1, number2, number3, number4,result1,result2,result3;
        string feld1, feld2, feld3, feld4,feld5,feld6,feld7,formula1,empty="";


        
        public Form1()
        {
            InitializeComponent();
        }
         


        private void button1_Click(object sender, EventArgs e)
        {
            
            feld1 = textBox1.Text;
            feld2 = textBox2.Text;
            feld3 = textBox3.Text;
            feld4 = textBox4.Text;
            
            
            
            number1 = Convert.ToDouble(feld1);
            number2 = Convert.ToDouble(feld2);
            number3 = Convert.ToDouble(feld3);
            number4 = Convert.ToDouble(feld4);

            result1 = (number1 + number3);	// Berechnung 1. Klammer
            result2 = (number2 + number4);	// Berechnung 2. Klammer

            feld5 = Convert.ToString(result1);
            feld6 = Convert.ToString(result2);

            textBox5.Text = "(a+bi)+(c+di)=(a+c)+(b+d)i";
            formula1 = "(" + feld1 + "+" + feld2 + "i)+(" + feld3 + "+" + feld4 + "i)=(" + feld1 + "+" + feld3 + ")+(" + feld2 + "+" + feld4 + ")i";
            textBox6.Text = formula1;
             textBox7.Text = feld5;
            textBox8.Text = "" + feld6 + "i";
            textBox9.Text = "+";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            feld1 = textBox1.Text;
            feld2 = textBox2.Text;
            feld3 = textBox3.Text;
            feld4 = textBox4.Text;
            number1 = Convert.ToDouble(feld1);
            number2 = Convert.ToDouble(feld2);
            number3 = Convert.ToDouble(feld3);
            number4 = Convert.ToDouble(feld4);

            result1 = (number3 - number1);	// Berechnung 1. Klammer
            result2 = (number3 - number2);	// Berechnung 2. Klammer

            feld5 = Convert.ToString(result1);
            feld6 = Convert.ToString(result2);

            textBox5.Text = "(c+di)-(a+bi)=(c-a)+(c-b)i";
            formula1 = "(" + feld3 + "+" + feld4 + "i)+(" + feld1 + "+" + feld2 + "i)=(" + feld3 + "+" + feld1 + ")+(" + feld3 + "+" + feld2 + ")i";
            textBox6.Text = formula1;
            textBox7.Text = feld5;
            textBox8.Text = "" + feld6 + "i";
            textBox9.Text = "+";
        }

        private void button3_Click(object sender, EventArgs e)
        {


            feld1 = textBox1.Text;
            feld2 = textBox2.Text;
            feld3 = textBox3.Text;
            feld4 = textBox4.Text;
            number1 = Convert.ToDouble(feld1);
            number2 = Convert.ToDouble(feld2);
            number3 = Convert.ToDouble(feld3);
            number4 = Convert.ToDouble(feld4);

            result1 = ((number1 * number3) -(number2 * number4));	// Berechnung 1. Klammer
            result2 = ((number1 * number4) + (number2 * number3));	// Berechnung 2. Klammer

            feld5 = Convert.ToString(result1);
            feld6 = Convert.ToString(result2);

            textBox5.Text = "(a+bi)*(c+di)=(ac-bd)+(ad+bc)*i";
            formula1 = "(" + feld1 + "+" + feld2 + "i)*(" + feld3 + "+" + feld4 + "i)=(" + feld3 + "+" + feld1 + ")+(" + feld3 + "+" + feld2 + ")i";
            textBox6.Text = formula1;
            textBox7.Text = feld5;
            textBox8.Text = "" + feld6 + "i";
            textBox9.Text = "+";
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            feld1 = textBox1.Text;
            feld2 = textBox2.Text;
            feld3 = textBox3.Text;
            feld4 = textBox4.Text;
            number1 = Convert.ToDouble(feld1);
            number2 = Convert.ToDouble(feld2);
            number3 = Convert.ToDouble(feld3);
            number4 = Convert.ToDouble(feld4);

            if(feld3=="0" || feld4=="0"){
                MessageBox.Show("Division durch 0 ist nicht möglich!", "Division durch 0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);}
            else{
            result1 = ((number1 * number3) + (number2 * number4));	// Berechnung 1. Klammer
            result2 = ((number2 * number3) - (number1 * number4));	// Berechnung 2. Klammer
            result3 = ((number3 * number3) + (number4 * number4));   // Berechnung des Teilers


            feld5 = Convert.ToString(result1);
            feld6 = Convert.ToString(result2);
            feld7 = Convert.ToString(result3);

            textBox5.Text = "(a+bi)/(c+di)=((a+bi)*(c-di))/((c+di)*(c-di))";
            formula1 = "(" + feld1 + "+" + feld2 + "i)/(" + feld3 + "+" + feld4 + "i)=((" + feld1 + "+" + feld2 + "i)*(" + feld3 + "-" + feld4 + "i))/((" + feld3 + "+" + feld4 + "i)*(" + feld3 + "-" + feld4 + "i))";
            textBox6.Text = formula1;
            textBox7.Text = "" + feld5 + "/" + feld7 + "";
            textBox8.Text = "" + feld6 + "/" + feld7 + "i";
            textBox9.Text = "+";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = empty;
            textBox2.Text = empty;
            textBox3.Text = empty;
            textBox4.Text = empty;
            textBox5.Text = empty;
            textBox6.Text = empty;
            textBox7.Text = empty;
            textBox8.Text = empty;
            textBox9.Text = empty;
        }

    }
}
