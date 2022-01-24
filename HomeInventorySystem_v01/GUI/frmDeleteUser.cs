using HomeInventorySystem_v01.DataAccessLayer;
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
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void txtPasswordD_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPasswordD.Text == frmLogin.CurentUser.Password)
            {
                UsersDAL.DeleteUser(frmLogin.CurentUser);
                Application.Exit();
            }
            else { MessageBox.Show("Invalid password");
                txtPasswordD.Text = "";
            }
        }

        private void frmDeleteUser_Load(object sender, EventArgs e)
        {

        }

        private void txtPasswordD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
