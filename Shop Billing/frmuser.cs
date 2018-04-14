using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Billing
{
    public partial class frmuser : Form
    {
       BL.user_bl userbl = new BL.user_bl();
       BL.usermodel User = new BL.usermodel();
       public int indexRow;
       public int nSelectCelluserid;
       message_box.messageboxtype ms = new message_box.messageboxtype();
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
            rdbAdmin.Checked = true;
            txtName.Focus();
            btnEdit.Enabled = false;
            grid_view_show_user_records();
            btnDelete.Enabled = false;
            pbUserImagebox.Image = global::Shop_Billing.Properties.Resources.adduser;
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
            lblRowsCount.Text = Convert.ToString(dgvUser.RowCount);
        }
        /// <summary>
        /// to add the details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                bool isresult;
                isresult = Validate();
                if (isresult)
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
                    if (btn.Text == "Add")
                    {
                        btnEdit.Enabled = false;
                        string strmessage = userbl.insertdetails(User);
                        if (strmessage == "Success")
                        {
                            ms.CallMessageBox("The User Details has been saved successfully..", "Information", "Information");
                            clear();
                        }
                        else
                            ms.CallMessageBox(strmessage + "\nPlease Call system Administrator.", "Error", "error");
                    }
                    else if (btn.Text == "Edit")
                    {
                        User.UserID = nSelectCelluserid;
                        string strmessage = userbl.UpdateUserDetails(User);
                        if (strmessage == "Updated")
                        {
                            ms.CallMessageBox("The User Details has been Updated successfully..", "Information", "information");
                            pbUserImagebox.Image = global::Shop_Billing.Properties.Resources.adduser;
                            btnAdd.Enabled = true;
                            btnEdit.Enabled = false;
                            clear();
                        }
                        else
                            ms.CallMessageBox(strmessage + "\nPlease Call system Administrator.", "Error", "error");
                    }
                    dgvUser.Update();
                    dgvUser.Refresh();
                    grid_view_show_user_records();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nPlease Call system Administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool Validate()
        {
            if (txtName.Text == "")
            {
                ms.CallMessageBox("Please enter the Member Name.", "Missing", "ex");
                txtName.Focus();
                return false;
            }
            else if (!Regex.Match(txtName.Text, "^[a-zA-Z .]*$").Success)
            {
                ms.CallMessageBox("Please enter the Vaild Name.", "Error", "error");
                txtName.Focus();
                return false;
            }
            else if (txtMobileNo.Text == "")
            {
                ms.CallMessageBox("Please enter the Mobile No.", "Missing", "ex");
                txtMobileNo.Focus();
                return false;
            }
            else if (txtMobileNo.Text.Length != 10)
            {
                ms.CallMessageBox("Please enter Vaild Mobile No.", "Error", "error");
                txtMobileNo.Focus();
                return false;
            }
            else if (txtUserName.Text == "")
            {
                ms.CallMessageBox("Please enter the User Name.", "Missing", "ex");
                txtUserName.Focus();
                return false;
            }
            else if (txtPassword.Text == "")
            {
                ms.CallMessageBox("Please enter the Password.", "Missing", "ex");
                txtPassword.Focus();
                return false;
            }
            else if (txtRetypePassword.Text == "")
            {
                ms.CallMessageBox("Please enter the Re-type Password.", "Missing", "ex");
                txtRetypePassword.Focus();
                return false;
            }
            else if (txtPassword.Text != txtRetypePassword.Text)
            {
                ms.CallMessageBox("Mismatched Re-type Password.", "Error", "error");
                txtPassword.Focus();
                txtRetypePassword.Text = "";
                return false;
            }
            else
            {
                DataTable dtusername = userbl.AlreadyExistsUsername(txtUserName.Text);
                if (dtusername != null && dtusername.Rows.Count > 0)
                {
                    if (txtUserName.Text == dtusername.Rows[0][0].ToString())
                    {
                        ms.CallMessageBox("Already Exists this user name please enter another one.", "Already Exists", "ex");
                        txtUserName.Focus();
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                pbUserImagebox.Image = global::Shop_Billing.Properties.Resources.edit_user;
                indexRow = e.RowIndex;
                DataGridViewRow row = dgvUser.Rows[indexRow];
                nSelectCelluserid = Convert.ToInt32(row.Cells[0].Value.ToString());
                txtName.Text = row.Cells[1].Value.ToString();
                txtMobileNo.Text = row.Cells[2].Value.ToString();
                txtUserName.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "Admin")
                    rdbAdmin.Checked = true;
                else
                    rdbUser.Checked = true;
               
            }
            catch
            {
            }
          
        }
        /// <summary>
        /// 
        /// </summary>
        public void clear()
        {
            txtName.Text = "";
            txtMobileNo.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtRetypePassword.Text = "";
            rdbAdmin.Checked = true;
            nSelectCelluserid = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to delete?", "Delete Conformation", MessageBoxButtons.YesNo,
        MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                string strmessage = userbl.DeleteUserDetailsByuserId(nSelectCelluserid);
                if (strmessage == "Deleted")
                {
                    ms.CallMessageBox("The User Details has been Deleted successfully..", "Information", "information");
                   
                }
                else
                    ms.CallMessageBox(strmessage + "\nPlease Call system Administrator.", "Error", "error");
            }
            
                pbUserImagebox.Image = global::Shop_Billing.Properties.Resources.adduser;
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                grid_view_show_user_records();
                clear();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
