﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telikhergasia_allhlepidrash
{
    public partial class Form7 : Form
    {
        bool rb, rb2;
        public Form7(bool rb, bool rb2)
        {
            InitializeComponent();
            this.rb = rb;
            this.rb2 = rb2;
          
        }
        public Form7()
        {
            InitializeComponent();
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (rb == true)
            {
                pictureBox1.Visible = true; //arxiko
                pictureBox2.Visible = false;//skwtino
                pictureBox3.Visible = false;// pinter
                pictureBox4.Visible = false;//scanner
                pictureBox5.Visible = false;//scanner1
                pictureBox6.Visible = false;//printer1
                pictureBox7.Visible = false;//arxikivrwmiko
                linkLabel3.Visible = false;
                linkLabel5.Visible = false;
                button4.Visible = true;
                button5.Visible = false;
                button6.Visible = false;
                pictureBox8.Visible = true;
                label7.Visible = true;
                pictureBox9.Visible = false;
                label4.Visible = false;

            }else if (rb2 == true)
            {
                pictureBox1.Visible = false; //arxiko
                pictureBox2.Visible = false;//skwtino
                pictureBox3.Visible = false;// pinter
                pictureBox4.Visible = false;//scanner
                pictureBox5.Visible = false;//scanner1
                pictureBox6.Visible = false;//printer1
                pictureBox7.Visible = true;//arxikivrwmiko
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                linkLabel4.Visible = false;
                button4.Visible = true;
                button5.Visible = false;
                button6.Visible = false;
                pictureBox8.Visible = true;
                label7.Visible = true;
                pictureBox9.Visible = false;
                label4.Visible = false;
            }
          
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //print
            timer1.Enabled = true;
            groupBox1.Visible = false;
            button5.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox3.Visible = false;
            timer1.Enabled = false;
            MessageBox.Show("Your copies are ready.");
            linkLabel3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //scanner
            

            pictureBox5.Visible = false;
            pictureBox4.Visible = true;         
            timer2.Enabled = false;
            MessageBox.Show("Your Scan is ready.");
            groupBox2.Visible = true;
            button6.Enabled = true;

        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {

           
        }

        private void groupBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
          
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                linkLabel4.Visible = false;
                linkLabel5.Visible = false;
                button6.Visible = false;
                button5.Visible = false;
                button4.Visible = true;
                pictureBox8.Visible = false;
                label7.Visible = false;
                pictureBox9.Visible = false;
                label4.Visible = false;
            }
            else
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                
                linkLabel2.Visible = true;
                linkLabel3.Visible = false;
                linkLabel4.Visible = true;
                linkLabel5.Visible = false;
                button6.Visible = false;
                button5.Visible = false;
                button4.Visible = true;
                pictureBox8.Visible = true;
                label7.Visible = true;
                pictureBox9.Visible = false;
                label4.Visible = false;
            }
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
            groupBox1.Visible = true;
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            button4.Visible = false;
            button5.Visible = true;
            button6.Visible = false;
            pictureBox8.Visible = false;
            label7.Visible = false;
            pictureBox9.Visible = true;
            label4.Visible = true;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox6.Visible = false;
            groupBox1.Visible = true;
            linkLabel3.Visible = false;
            button5.Enabled = true;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox4.Visible = true;
            groupBox2.Visible = true;
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            button4.Visible = false;
            button5.Visible = false;

            button6.Visible = true;
            pictureBox8.Visible = false;
            label7.Visible = false;
            pictureBox9.Visible = true;
            label4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true && textBox1.Text != "")
            {
                groupBox2.Visible = false;
                timer2.Enabled = true;
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
                button6.Enabled = false;
            }else if (radioButton1.Checked == true)
            {
                groupBox2.Visible = false;
                timer2.Enabled = true;
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
                button6.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter your e-mail");
            }
            

            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox1.Visible = true;
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = false;
            linkLabel4.Visible = true;
            linkLabel5.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox3.Visible = false;
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = false;
            linkLabel4.Visible = true;
            linkLabel5.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            button4.Visible = true;
            groupBox1.Visible = false;
            pictureBox8.Visible = true;
            label7.Visible = true;
            pictureBox9.Visible = false;
            label4.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox4.Visible = false;
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = false;
            linkLabel4.Visible = true;
            linkLabel5.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            button4.Visible = true;
            groupBox2.Visible = false;
            pictureBox8.Visible = true;
            label7.Visible = true;
            pictureBox9.Visible = false;
            label4.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                MessageBox.Show("In this room you can choose either printer or scanner bu clicking in the right option above!");
            }else if (pictureBox7.Visible == true)
            {
                MessageBox.Show("You have to clean the room by clicking in the right option above.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true)
            {
                MessageBox.Show("You have chhose the printing machine,here you make copies by chhosing your prefernces from the menu,then you have to wait untill they are rady nai pick them up");
            }else if (pictureBox4.Visible==true)
            {
                MessageBox.Show("You have chose the scanningmachine here you make digital copies and save either in usb or send them to your email account.These options are available in the menu above!");
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
