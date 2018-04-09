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

namespace Shop_Billing
{
    public partial class frmuser : Form
    {
       BL.user_bl userbl = new BL.user_bl();
       BL.usermodel User = new BL.usermodel();
        public frmuser()
        {
            InitializeComponent();
        }
      
        /// <summary>
        /// form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmuser_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            grid_view_show_user_records();
           
        }
        /// <summary>
        /// to show grid view  user records
        /// </summary>
        public void grid_view_show_user_records()
        {
            dgvUser.DataSource = null;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = userbl.getuserrecords();
            dgvUser.DataSource = bSource;
            dgvUser.Columns[0].Visible = false;
            //dgvUser.D
            
        }
        /// <summary>
        /// to add the details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            User.Name = txtName.Text;
            User.Mobilenumber = txtMobileNo.Text;
            User.Username = txtUserName.Text;
            User.password = txtPassword.Text;
            if (rdbAdmin.Checked)
                User.UserRole = rdbAdmin.Text;
            else
                User.UserRole = rdbUser.Text;
            User.createdby = 1;
          string strmessage= userbl.insertdetails(User);
          MessageBox.Show(strmessage);
         
          dgvUser.Update();
          dgvUser.Refresh();
          grid_view_show_user_records();
        } 
    }
}
