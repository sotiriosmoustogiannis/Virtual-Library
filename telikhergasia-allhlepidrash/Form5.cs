using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace telikhergasia_allhlepidrash
{
    public partial class Form5 : Form
    {
        SqlConnection connection;
        string connectionS;
        DataTable bookstable = new DataTable();
        public List<string> BooksToCart = new List<string>();
        Image[] images = new Image[20];
        int x = 0;
        int counter = 0;
        decimal totalBill = 0;
        bool rb1, rb2;
        int kr = 12;
       
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
        public Form5(bool rb1,bool rb2)
        {
            InitializeComponent();
            connectionS = ConfigurationManager.ConnectionStrings["telikhergasia_allhlepidrash.Properties.Settings.Database1ConnectionString"].ConnectionString;
            this.rb1 = rb1;
            this.rb2 = rb2;
        }
        public void Books()
        {
            using (connection = new SqlConnection(connectionS))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM BOOKS", connection))
            {
                connection.Open();
               
                adapter.Fill(bookstable);
                Console.WriteLine(bookstable.Rows[0][1].ToString());

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            if (counter > 0)
            {
                counter = counter - 1;
            }
            Image image4 = images[counter];
            this.pictureBox1.Image = image4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter == 8)
                button2.Enabled = false;
            counter++;

            Image image4 = images[counter];
            this.pictureBox1.Image = image4;
            // next = true;

            numericUpDown1.Value = 0;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (rb1 == true)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
            }
            else
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                button3.Visible = false;
            }
            Books();
            images[0] = Properties.Resources.book1;
            images[1] = Properties.Resources.book2;
            images[2] = Properties.Resources.book3;
            //
            images[3] = Properties.Resources.book4;
            images[4] = Properties.Resources.book5;
            images[5] = Properties.Resources.book6;
            //
            images[6] = Properties.Resources.book7;
            images[7] = Properties.Resources.book8;
            images[8] = Properties.Resources.book9;
            images[9] = Properties.Resources.book10;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bookstable.Rows[counter][1].ToString() + Environment.NewLine + bookstable.Rows[counter][2].ToString() + Environment.NewLine + bookstable.Rows[counter][3].ToString() + Environment.NewLine +"price: " +bookstable.Rows[counter][4].ToString());

       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int z = 1; z <= numericUpDown1.Value; z++)
            {
                BooksToCart.Add(bookstable.Rows[counter][1].ToString());
                
                totalBill = totalBill + Convert.ToDecimal( bookstable.Rows[counter][4].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6(BooksToCart,totalBill);
            frm6.Show();
            
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Search")
                textBox1.Text ="";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool find = false;
            x = 0;
            foreach (DataRow row in bookstable.Rows)
            {
               // MessageBox.Show(bookstable.Rows[x][1].ToString());
                if (bookstable.Rows[x][1].ToString()==textBox1.Text)
                {
                    find = true;
                    Image image4 = images[x];
                    this.pictureBox1.Image = image4;
                    MessageBox.Show(bookstable.Rows[x][1].ToString() + Environment.NewLine + bookstable.Rows[x][2].ToString() + Environment.NewLine + bookstable.Rows[x][3].ToString());
                }
                
                x++;
            }
            if(find==false)
                MessageBox.Show("We don't have this book!");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox2.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured.");
            }
        }
        private void UpdateData()
        {
            kr++;
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            // create command object with SQL query and link to connection object
            SqlCommand Cmd = new SqlCommand("INSERT INTO BOOKS " +
        "(id, bookname, bookauthor, description, price) " +
                "VALUES(@ID, @bookname, @bookauthor, @description, @price)",
        Con);


            // create your parameters
            Cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            Cmd.Parameters.Add("@bookname", System.Data.SqlDbType.Char);
            Cmd.Parameters.Add("@bookauthor", System.Data.SqlDbType.Char);
            Cmd.Parameters.Add("@description", System.Data.SqlDbType.Char);
            Cmd.Parameters.Add("@price", System.Data.SqlDbType.Int);
            

            // set values to parameters from textboxes
            Cmd.Parameters["@ID"].Value = kr;
            Cmd.Parameters["@bookname"].Value = textBox2.Text;
            Cmd.Parameters["@bookauthor"].Value = textBox3.Text;
            Cmd.Parameters["@description"].Value = textBox4.Text;
            Cmd.Parameters["@price"].Value = Convert.ToInt32(textBox5.Text);

            // open sql connection
            Con.Open();

            // execute the query and return number of rows affected, should be one
            int RowsAffected = Cmd.ExecuteNonQuery();
            MessageBox.Show(RowsAffected.ToString());

            // close connection when done
            Con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(rb1,rb2);
            frm4.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox5.Text!= "" )
            {

                UpdateData();
            }
            else
            {
                MessageBox.Show("book name and price required!");
            }
            

        }
    }
}
