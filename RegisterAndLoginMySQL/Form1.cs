using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Configuration;
namespace RegisterAndLoginUsingMySQL
{
    public partial class Form1 : Form
    {
        public MySqlConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["Default Connection"].ToString());
        public Form1()
        {
            InitializeComponent();
        }
        public static string username;
        public static string password;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Form2.registerusername == "")
            {

            }
            else
            {
                txtusername.Text = Form2.registerusername;
            }
        }

        private void btregister_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            CheckUsername();
        }
        void CheckUsername()
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("You need to fill in an username!");
            }
            else
            {
                CheckPassword();
            }
        }
        void CheckPassword()
        {
            if (txtpassword.Text == "")
            {
                MessageBox.Show("You need to fill in an password!");
            }
            else
            {
                CheckAccount();
            }
        }
        void CheckAccount()
        {
            try
            {
                db.Open();
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataReader dr1;
                cmd.Connection = db;
                cmd.CommandText = "SELECT * FROM users WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    Succes();
                }
                else
                {
                    MessageBox.Show("This account dose not exist!");
                }
                db.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Succes()
        {
            username = txtusername.Text;
            password = txtpassword.Text;
            Form3 x = new Form3();
            x.Show();
            this.Hide();
        }
    }
}
