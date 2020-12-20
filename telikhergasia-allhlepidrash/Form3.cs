using System;
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
    public partial class Form3 : Form
    {
        Form2 frm2 = new Form2();             //antikeimeno formas2
        bool rb, rb2;                          //times radiobutton

        public Form3(bool rb, bool rb2)               //constructor pou dexetai orismata dyo radiobutton analoga 
        {                                            //thn epilogh poy exei ginei sth forma 2 (as a customer/as a employee)
            InitializeComponent();
            this.rb = rb;
            this.rb2 = rb2;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           if (rb==true)
            {
                linkLabel6.Visible = false;
                linkLabel4.Visible = false;
                linkLabel5.Visible = false;
            }
            else if (rb2 == true)
            {
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                linkLabel4.Visible = false;
                linkLabel6.Visible = false;
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
                                
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {                      
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {                           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //otan patas sthn kafetiera energopoieitai gia na kanei tis leitoyrgies
            pictureBox7.Visible = false;
            if (rb == true)   //an einai pelaths
            {
                pictureBox6.Visible = true;
                linkLabel4.Visible = false;
                button5.Visible = true;             
            }
            else if (rb2 == true)    //an einai ypallilos
            {
                pictureBox1.Visible = true;
                linkLabel1.Visible = true;             
                linkLabel5.Visible = true;
                button1.Visible = true;
                pictureBox9.Visible = true;
                label2.Visible = true;
            }
            timer1.Enabled = false;
            if (rb2 == true)         //an einai ypallilos
            {
                MessageBox.Show("The coffee machine filled");
            }

        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
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

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            pictureBox9.Visible = false;
            label2.Visible = false;

            if (rb == true)         //an einai pelaths
            {
                pictureBox1.Visible = false;
                pictureBox4.Visible = true;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                linkLabel5.Visible = false;
                button1.Visible = false;
                button4.Visible = true;
                groupBox1.Visible = true;
            }
            else if (rb2 == true)     //an einai ypallilos
            {
                pictureBox1.Visible = false;
                pictureBox4.Visible = true;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                linkLabel5.Visible = false;
                linkLabel4.Visible = true;
                button1.Visible = false;
                button4.Visible = true;
            }
            //coffee
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            pictureBox9.Visible = false;
            label2.Visible = false;
            if (rb == true)     //an einai pelaths
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = true;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                button1.Visible = false;
                linkLabel5.Visible = false;
               
                button2.Visible = true;
                linkLabel6.Visible = true;

            }
            //table
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            pictureBox9.Visible = false;
            label2.Visible = false;
            if (rb == true)       //an einai pelaths
            {
                pictureBox1.Visible = false;
                pictureBox5.Visible = true;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                linkLabel3.Visible = false;
                linkLabel4.Visible = false;
                linkLabel5.Visible = false;
                button1.Visible = false;
                button6.Visible = true;
                
            }
            //sofa
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Close();
            frm2.Show();
            //gyrnaei sto arxiko menu
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            pictureBox9.Visible = false;
            label2.Visible = false;
            if (rb2 == true)  //an einai ypallilos
            {
                
                if (pictureBox1.Visible == true)
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    linkLabel5.Text = "switch on lights";
                    linkLabel1.Visible = false;
                    linkLabel2.Visible = false;
                    linkLabel3.Visible = false;

                }
                else
                {
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = true;
                    linkLabel5.Text = "switch off lights";
                    linkLabel1.Visible = true;
                    pictureBox9.Visible = true;
                    label2.Visible = true;
                }
            }
            //lights
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox8.Visible = true;
            //paei sto menu apto trapezi
            linkLabel6.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox1.Visible = true;
            //gyrnaei pisw apto trapezi
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = true;
            button1.Visible = true;
            linkLabel6.Visible = false;
            button2.Visible = false;
            button1.Visible = true;
            pictureBox9.Visible = true;
            label2.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox3.Visible = true;
            button3.Visible = false;
            linkLabel6.Visible = true;
            button2.Visible = true;
            //gyrnaei apto menuu
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rb2 == true)     //an einai ypallilos
            {
                pictureBox4.Visible = false;
                pictureBox7.Visible = true;
                timer1.Enabled = true;
                button4.Visible = false;             
                linkLabel4.Visible = false;
                
            }
            //make coffee
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox1.Visible = true;
            //gyrnaei pisw apto coffee etoimo
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = true;      
            linkLabel6.Visible = false;
            button5.Visible = false;
            button1.Visible = true;
            pictureBox9.Visible = true;
            label2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            pictureBox1.Visible = true;
           //back sofa
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = true;
            button1.Visible = true;
            button6.Visible = false;
            pictureBox9.Visible = true;
            label2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox7.Visible = true;
            timer1.Enabled = true;
            groupBox1.Visible = false;
            button4.Visible = false;
            
            //button make coffe
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the cafe room you have 3 options which you can use by chhosing on of them on the left of the screen.By clicking the first one you can sit on a table and have a llok on the menu,withe the second you dan go to the cofee machine to make your one coffe, and finall withe the erd option you take o sit to the sofa.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            label2.Visible = true;
            if (rb2 == true)
            {
                pictureBox4.Visible = false;
                pictureBox1.Visible = true;
                button1.Visible = true;
                button4.Visible = false;
                linkLabel1.Visible = true;
                linkLabel5.Visible = true;
                linkLabel4.Visible = false;
            }
            else if (rb==true)
            {
                pictureBox4.Visible = false;
                pictureBox1.Visible = true;
                button1.Visible = true;
                button4.Visible = false;
                linkLabel1.Visible = true;
                linkLabel2.Visible = true;
                linkLabel3.Visible = true;
                groupBox1.Visible = false;

            }

            //back coffee
        }
    }
}
