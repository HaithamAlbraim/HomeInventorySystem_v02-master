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
using HomeInventorySystem_v01.Entities;

namespace HomeInventorySystem_v01.GUI
{
    public partial class frmMyInventory : Form
    {
        public frmMyInventory()
        {
            InitializeComponent();
        }

        private void frmMyInventory_Load(object sender, EventArgs e)
        {
            cbItems.ValueMember = "ItemId";
            cbItems.DisplayMember = "ItemName";
            cbItems.DataSource = ItemsDAL.GetAllItems(frmLogin.CurentUser);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item currentItem = ItemsDAL.GetItemById(int.Parse(cbItems.SelectedValue.ToString()),frmLogin.CurentUser );
            currentItem.Quantity += int.Parse(txtQuantity.Text);
            ItemsDAL.UpdateItem(currentItem);
            ClearForm();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Item currentItem = ItemsDAL.GetItemById(int.Parse(cbItems.SelectedValue.ToString()), frmLogin.CurentUser);
            if (currentItem.Quantity > int.Parse(txtQuantity.Text))
            {
                currentItem.Quantity -= int.Parse(txtQuantity.Text);
                ItemsDAL.UpdateItem(currentItem);
                ClearForm();
            }
            else
            {
                ClearForm();
                MessageBox.Show("You dont have this quantity");
            }
    
        }
        private void ClearForm()
        {
            
            txtQuantity.Text = "";

         
        }
    }
}
