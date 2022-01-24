using HomeInventorySystem_v01.DataAccessLayer;
using HomeInventorySystem_v01.Entities;
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

namespace HomeInventorySystem_v01.GUI
{
    
    public partial class frmLogin : Form
    {
        public static User CurentUser = new User();
        public int My { get; set; }


        /* private static string connectionString = "Data Source =localhost; " +
                "Initial Catalog = PersonalShopping; Integrated Security = True";

         private static readonly SqlConnection connection = new SqlConnection(connectionString);*/

        public frmLogin()
        {
           
        InitializeComponent();
             
    }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*SqlCommand command= new SqlCommand("select (UserId) from SystemUsers where UserName=@UserName and Password =@Password", connection);
            command.Parameters.AddWithValue("@UserName", txtUserNameL.Text);
            command.Parameters.AddWithValue("@Password", txtPasswordL.Text);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            //Connection open here   
            connection.Open();
            int i = command.ExecuteNonQuery();
            connection.Close();
            if (dt.Rows.Count > 0)*/
            /*UsersDAL.GetUserBYUserNamePass(txtUserNameL.Text, txtPasswordL.Text);*/
            /*CurentUser.Username = UsersDAL.GetUserBYUserNamePass(userName:txtUserNameL.Text,Password:txtPasswordL.Text).Username;*/
            /* CurentUser.Password = UsersDAL.GetUserBYUserNamePass(userName:txtUserNameL.Text,Password:txtPasswordL.Text).Password;*/
            /* CurentUser = UsersDAL.GetUserBYUserNamePass(userName:txtUserNameL.Text, Password:txtPasswordL.Text);*/
           
           
            UsersDAL.GetUserBYUserNamePass(userName:txtUserNameL.Text,Password:txtPasswordL.Text);
           
            CurentUser = UsersDAL.GetUserBYUserNamePass(userName:txtUserNameL.Text,Password:txtPasswordL.Text);
      

            if (txtUserNameL.Text==CurentUser.Username && txtPasswordL.Text==CurentUser.Password)
            {
                
                MessageBox.Show("Successfully loged in");
                My = CurentUser.UserId;
               




                    MessageBox.Show(CurentUser.UserId.ToString());

                //after successful it will redirect  to next page .  
                this.Close();
            }
           


            else
            {
                MessageBox.Show("Login Failed Try agin");
                txtUserNameL.Text = "";
                txtPasswordL.Text = "";

                
            }
           
            

        }
        
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            frmCreateUser frm = new frmCreateUser();
            frm.ShowDialog();
            
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserNameL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
