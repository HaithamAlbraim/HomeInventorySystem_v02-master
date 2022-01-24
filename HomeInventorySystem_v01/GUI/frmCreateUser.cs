using HomeInventorySystem_v01.DataAccessLayer;
using HomeInventorySystem_v01.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeInventorySystem_v01.GUI
{
    public partial class frmCreateUser : Form
    {
        User currentUser = new User();
        public frmCreateUser()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            currentUser.FirstName = txtUserFName.Text;
            currentUser.LastName = txtUserLName.Text;
            currentUser.Username = txtUserNameC.Text;
            currentUser.Password = txtUserPasswordC.Text;

            UsersDAL.CreateUser(currentUser);
            this.Close();
        }

        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            
            txtUserFName.Focus();

        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
