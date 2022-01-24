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
    public partial class frmUserProfilee : Form
    {
        public frmUserProfilee()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEditProfail_Load(object sender, EventArgs e)
        {
            txtFirstN.Text = frmLogin.CurentUser.FirstName;
            txtLastN.Text = frmLogin.CurentUser.LastName;
            txtUserN.Text = frmLogin.CurentUser.Username;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtPasswordN.Text==frmLogin.CurentUser.Password)
            {
                frmLogin.CurentUser.UserId = frmLogin.CurentUser.UserId;
                frmLogin.CurentUser.FirstName = txtFirstN.Text;
                frmLogin.CurentUser.LastName = txtLastN.Text;
                frmLogin.CurentUser.Username = txtUserN.Text;
                frmLogin.CurentUser.Password = txtNewPasswordN.Text;
                UsersDAL.UpdateUser(frmLogin.CurentUser);
                MessageBox.Show(frmLogin.CurentUser.Username+frmLogin.CurentUser.Password);
            }
            else { MessageBox.Show("Wrong password",frmLogin.CurentUser.Password);
                txtFirstN.Text = frmLogin.CurentUser.FirstName;
                txtLastN.Text = frmLogin.CurentUser.LastName;
                txtUserN.Text = frmLogin.CurentUser.Username;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            frmDeleteUser frm = new frmDeleteUser();
            frm.ShowDialog();
        }

        private void txtFirstN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtLastN_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
