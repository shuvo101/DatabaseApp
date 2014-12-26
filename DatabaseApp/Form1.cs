using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            //take input from Entry Form

            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;


            //Build Connection with new_databas in database
            string connectionString = @"SERVER = BITM-401-PC07\SQLEXPRESS; Database=UniversityDatabase;integrated Security = true";
            SqlConnection connection = new SqlConnection(connectionString);

                // ToString() DataRowBuilder a connection..
            

           // connection.ConnectionString = connectionString;

            string query = string.Format("INSERT INTO tStudent VALUES('{0}','{1}','{2}')", name, email, address);

                SqlCommand command = new SqlCommand(query,connection);

            //command.CommandText = query;
            //command.Connection = connection;
            connection.Open();

           int rowAffected = command.ExecuteNonQuery();

            connection.Close();
            
            if(rowAffected>0)
            {
                MessageBox.Show("Insert Successfully");
            }

            else
            {
                MessageBox.Show("Insert Failed");
            }





            // write SQL INSERTON Query for inserting into student table

            //Excute the query to the database


        }
    }
}
