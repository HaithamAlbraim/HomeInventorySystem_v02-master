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
        

       

        public frmLogin()
        {
           
        InitializeComponent();
             
    }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            UsersDAL.GetUserBYUserNamePass(userName:txtUserNameL.Text,Password:txtPasswordL.Text);
           
            CurentUser = UsersDAL.GetUserBYUserNamePass(userName:txtUserNameL.Text,Password:txtPasswordL.Text);
      

            if (txtUserNameL.Text==CurentUser.Username && txtPasswordL.Text==CurentUser.Password)
            {
                
                MessageBox.Show("Successfully loged in");
              




                    MessageBox.Show(CurentUser.UserId.ToString());

              
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
