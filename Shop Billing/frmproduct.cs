using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Billing
{
    public partial class frmproduct : Form
    {
        public frmproduct()
        {
            InitializeComponent();
        }
        BL.product_bl productbl = new BL.product_bl();
        BL.productmodel Product = new BL.productmodel();
        public int indexRow;
        public int nSelectCellproductid;
        message_box.messageboxtype ms = new message_box.messageboxtype();

        private void frmproduct_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            GridviewShowProductRecords();
            rdbMobile.Enabled = true;
        }
        /// <summary>
        /// to show grid view  user records
        /// </summary>
        public void GridviewShowProductRecords()
        {
            dgvProduct.DataSource = null;
            BindingSource bSource = new BindingSource();
            bSource.DataSource = productbl.GetProductRecords();
            dgvProduct.DataSource = bSource;
            if (dgvProduct.Rows.Count > 0)
            {
                dgvProduct.Columns[0].Visible = false;
                dgvProduct.Columns[2].DefaultCellStyle.Format = "c";
               txtRowsCount.Text = Convert.ToString(dgvProduct.RowCount);
            }
            else
            {
                ms.CallMessageBox("There is no records.", "No records in Database", "ex");
            }
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
                    Product.ProductName = txtProductName.Text.Trim();
                    Product.Amount =Convert.ToDecimal(txtAmount.Text.Trim());
                    if (rdbMobile.Checked)
                        Product.ProductType = rdbMobile.Text;
                    else
                        Product.ProductType = rdbOtherProduct.Text;
                    //
                    Product.createdby = 1;
                    //
                    if (btn.Text == "Add")
                    {
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        string strmessage = productbl.InsertDetails(Product);
                        if (strmessage == "Success")
                        {
                            ms.CallMessageBox("The Product Details has been saved successfully..", "Information", "information");
                           clear();
                        }
                        else
                            ms.CallMessageBox(strmessage + "\nPlease Call system Administrator.", "Error", "error");
                    }
                    else if (btn.Text == "Update")
                    {
                        Product.ProductId = nSelectCellproductid;
                        string strmessage = productbl.UpdateProductDetails(Product);
                        if (strmessage == "Updated")
                        {
                            ms.CallMessageBox("The Product Details has been Updated successfully..", "Information", "information");
                            // pbUserImagebox.Image = global::Shop_Billing.Properties.Resources.adduser;
                            btnAdd.Enabled = true;
                            btnEdit.Enabled = false;
                            btnDelete.Enabled = false;
                            clear();
                        }
                        else
                            ms.CallMessageBox(strmessage + "\nPlease Call system Administrator.", "Error", "error");
                    }
                    dgvProduct.Update();
                    dgvProduct.Refresh();
                    GridviewShowProductRecords();
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
            if (txtProductName.Text == "")
            {
                ms.CallMessageBox("Please enter the Product Name.", "Missing", "ex");
                txtProductName.Focus();
                return false;
            }
            else if (txtAmount.Text == "")
            {
                ms.CallMessageBox("Please enter the Amount.", "Missing", "ex");
                txtAmount.Focus();
                return false;
            }
            else
            {

                DataTable dtusername = productbl.AlreadyExistsProductname(txtProductName.Text);
                if (dtusername != null && dtusername.Rows.Count > 0)
                {
                    if (txtProductName.Text == dtusername.Rows[0][0].ToString())
                    {
                        if (nSelectCellproductid != Convert.ToInt32(dtusername.Rows[0][1]))
                        {
                            ms.CallMessageBox("Already Exists this product name please enter another one.", "Already Exists", "ex");
                            txtProductName.Focus();
                            return false;
                        }
                        else
                return true;
                    }
            }
                else
                {
                    return true;
                }
            }
            return false;

        }
        public void clear()
        {
            txtProductName.Text = "";
            txtAmount.Text = "";
            rdbMobile.Enabled = true;
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                 // pbUserImagebox.Image = global::Shop_Billing.Properties.Resources.edit_user;
                indexRow = e.RowIndex;
                DataGridViewRow row = dgvProduct.Rows[indexRow];
                nSelectCellproductid = Convert.ToInt32(row.Cells[0].Value.ToString());
                txtProductName.Text = row.Cells[1].Value.ToString();
                string amounttrim = row.Cells[2].Value.ToString();
                txtAmount.Text = amounttrim.Remove(amounttrim.Length - 2);
                if (row.Cells[3].Value.ToString() == "Mobile")
                    rdbMobile.Checked = true;
                else
                    rdbOtherProduct.Checked = true;
            }
            catch
            {
            }
        }
        /// <summary>
        /// allow only numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you want to delete?", "Delete Conformation", MessageBoxButtons.YesNo,
       MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                string strmessage = productbl.DeleteProductDetailsByProductId(nSelectCellproductid);
                if (strmessage == "Deleted")
                {
                    ms.CallMessageBox("The Product Details has been Deleted successfully..", "Information", "information");

                }
                else
                    ms.CallMessageBox(strmessage + "\nPlease Call system Administrator.", "Error", "error");
            }

           // pbUserImagebox.Image = global::Shop_Billing.Properties.Resources.adduser;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            GridviewShowProductRecords();
           
            clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           // pbUserImagebox.Image = global::Shop_Billing.Properties.Resources.adduser;
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            GridviewShowProductRecords();
           
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
