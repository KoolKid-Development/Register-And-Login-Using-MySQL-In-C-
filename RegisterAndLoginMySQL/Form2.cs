using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterAndLoginUsingMySQL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string registerusername;
        public MySqlConnection db = new MySqlConnection(ConfigurationManager.ConnectionStrings["Default Connection"].ToString());
        private void btregister_Click(object sender, EventArgs e)
        {
            CheckFill();
        }
        void CheckFill()
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("You need to fill in a username");

            }
            else
            {
                if (txtemail.Text == "")
                {
                    MessageBox.Show("You need to fill in a email");
                }
                else
                {
                    if (txtpassword1.Text == "")
                    {
                        MessageBox.Show("You need to fill in a passowrd");
                    }
                    else
                    {
                        if (txtpassword2.Text == "")
                        {
                            MessageBox.Show("You need to fill in a password");
                        }
                        else
                        {
                            if (txtpassword1.Text == txtpassword2.Text)
                            {
                                CheckEmail();
                            }
                            else
                            {
                                MessageBox.Show("The passwords are not the same!");
                            }
                        }
                    }
                }
            }
        }
        void CheckEmail()
        {
            try
            {
                db.Close();
                db.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "SELECT * FROM users WHERE email='" + txtemail.Text + "'";
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("This email is taken!");
                }
                else
                {
                    CheckUsername();
                }
                db.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void CheckUsername()
        {
            try
            {
                db.Close();
                db.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "SELECT * FROM users WHERE username='" + txtusername.Text + "'";
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("This username is taken!");
                }
                else
                {
                    Insert();
                }
                db.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Insert()
        {
            try
            {
                db.Close();
                db.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = db;
                cmd.CommandText = "INSERT INTO `users` (`username`, `email`, `password`) VALUES ('" + txtusername.Text + "', '" + txtemail.Text + "', '" + txtpassword2.Text + "');";
                cmd.ExecuteNonQuery();
                db.Close();
                Succes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show();
            this.Hide();
        }
        void Succes()
        {
            Form1 x = new Form1();
            x.Show();
            this.Hide();
            registerusername = txtusername.Text;
        }
    }
}
