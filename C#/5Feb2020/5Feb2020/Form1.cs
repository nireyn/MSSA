using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _5Feb2020
{
    public partial class formPetCareDB : Form
    {
        public formPetCareDB()
        {
            InitializeComponent();
        }

        private void formPetCareDB_Load(object sender, EventArgs e)
        {

        }
        public string conString = "Data Source=MS-070889384353\\SQLEXPRESS;Initial Catalog=PetCareServices;Integrated Security=True";
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(conString))
            {
                sqlcon.Open();
                SqlCommand sqlCmd = new SqlCommand("ownerAdd", sqlcon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Lastname", txtLastname.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Notes", txtNotes.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Ownerid", txtOwnerid.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Entry Successful");
                Clear();
            }
        }
        void Clear()
        {
            txtFirstname.Text = txtLastname.Text = txtEmail.Text = txtMobile.Text = txtNotes.Text = "";
        }
    }
}
