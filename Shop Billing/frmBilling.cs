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
    public partial class frmBilling : Form
    {
        public frmBilling()
        {
            InitializeComponent();
        }
        public int indexRow = 0;
        BL.Billing_bl billbl = new BL.Billing_bl();
        message_box.messageboxtype ms = new message_box.messageboxtype();

        private void frmBilling_Load(object sender, EventArgs e)
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void rdbMobile_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                DataTable dt=null;
                DataRow dr;
                if (rb.Checked)
                {
                    dt = billbl.GetMobileProductRecords("Mobile");
                    lblIMEINO.Visible = true;
                    txtIMEINO.Visible = true;
                }
                else
                {
                    dt = billbl.GetMobileProductRecords("Other Product");
                    lblIMEINO.Visible = false;
                    txtIMEINO.Visible = false;
                }
                
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Product--" };
                dt.Rows.InsertAt(dr, 0);

                ddProductSelect.ValueMember = "PRODUCT_ID";
                ddProductSelect.DisplayMember = "PRODUCT_NAME";
                ddProductSelect.DataSource = dt;
                clear();
            }
        }
        public void clear()
        {
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            txtActualAmount.Text = "0";
            txtQunatity.Text = "";
            txtTotalAmount.Text = "0";
            txtDiscountAmount.Text = "";
            txtIMEINO.Text = "";
            ddProductSelect.SelectedIndex = 0;
            indexRow = 0;
            btnAdd.Enabled = true;
        }
        public void totalamount()
        {
            decimal sum = 0;
            for (int i = 0; i < dgvBillingPayment.Rows.Count; i++)
            {
                sum += Convert.ToDecimal(dgvBillingPayment.Rows[i].Cells[6].Value);
            }
            txtsum.Text = sum.ToString(); 
        }

        private void ddProductSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ddProductSelect.SelectedValue);
            if (id != 0)
            {
                DataTable dt = null;
                dt = billbl.AmountGetbyProductId(id);
                 string amounttrim = dt.Rows[0][0].ToString();
                txtActualAmount.Text = amounttrim.Remove(amounttrim.Length - 2);
                txtQunatity.Text = "";
               
            }
        }

        private void txtQunatity_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                decimal nqunatity = Convert.ToDecimal(txtQunatity.Text);
                decimal nactualamount = Convert.ToDecimal(txtActualAmount.Text);
                decimal ntotalAmount = (nqunatity * nactualamount);
                if (txtDiscountAmount.Text != "")
                {
                    if (Convert.ToDecimal(txtDiscountAmount.Text) <= ntotalAmount)
                        txtTotalAmount.Text = Convert.ToString(ntotalAmount - (Convert.ToDecimal(txtDiscountAmount.Text)));
                    else
                    {
                        ms.CallMessageBox("Please enter the Discount Amount Less than the Total Amount.", "Missing", "ex");
                        txtTotalAmount.Text = Convert.ToString(ntotalAmount);
                        txtDiscountAmount.Focus();
                        txtDiscountAmount.Text = "0";
                    }
                }
                else
                    txtTotalAmount.Text = Convert.ToString(ntotalAmount);
            }
            catch (Exception)
            {
               
                if (txtQunatity.Text == "")
                {
                    
                    txtTotalAmount.Text = "0";
                }
            }
            //txtTotalAmount.Text = Convert.ToString((Convert.ToInt32(txtQunatity.Text)) * (Convert.ToInt32(txtActualAmount.Text)));
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    int row = 0;
                    dgvBillingPayment.Rows.Add();
                    row = dgvBillingPayment.Rows.Count - 2;
                    if (rdbMobile.Checked)
                        dgvBillingPayment["dvProductType", row].Value = rdbMobile.Text;
                    else
                        dgvBillingPayment["dvProductType", row].Value = rdbOtherProduct.Text;
                    dgvBillingPayment["dvProductName", row].Value = ddProductSelect.Text;
                    dgvBillingPayment["dvIMEINO", row].Value = txtIMEINO.Text;
                    dgvBillingPayment["dvActualAmount", row].Value = txtActualAmount.Text;
                    if (txtDiscountAmount.Text == "")
                        txtDiscountAmount.Text = "0";
                    dgvBillingPayment["dvNoofQuantity", row].Value = txtQunatity.Text;
                    dgvBillingPayment["dvDiscountAmount", row].Value = txtDiscountAmount.Text;
                    dgvBillingPayment["dvTotalAmount", row].Value = txtTotalAmount.Text;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    totalamount();
                    clear();
                }
            }
            catch
            {

            }
        }

      
        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (this.dgvBillingPayment.SelectedRows.Count > 0)
            {

                dgvBillingPayment.Rows.RemoveAt(this.dgvBillingPayment.SelectedRows[0].Index);
                totalamount();
               clear();

            }
        }

        private void dgvBillingPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == dgvBillingPayment.NewRowIndex || e.RowIndex < 0)
                    return;
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                indexRow = e.RowIndex;
                DataGridViewRow row = dgvBillingPayment.Rows[indexRow];
                if (row.Cells[0].Value.ToString() == "Mobile")
                    rdbMobile.Checked = true;
                else
                    rdbOtherProduct.Checked = true;
                ddProductSelect.Text = row.Cells[1].Value.ToString();
                txtIMEINO.Text = row.Cells[2].Value.ToString();
                txtActualAmount.Text = row.Cells[3].Value.ToString();
                txtQunatity.Text = row.Cells[4].Value.ToString();
                if (txtDiscountAmount.Text == "")
                    txtDiscountAmount.Text = "0";
                txtDiscountAmount.Text = row.Cells[5].Value.ToString();
                txtTotalAmount.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contact Admin:"+ex.ToString());
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdbMobile.Checked = true;
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvBillingPayment.Rows[indexRow];
                if (row.Cells[0].Value.ToString() == "Mobile")
                    rdbMobile.Checked = true;
                else
                    rdbOtherProduct.Checked = true;
                row.Cells[1].Value = ddProductSelect.Text;
                row.Cells[2].Value = txtIMEINO.Text;
                row.Cells[3].Value = txtActualAmount.Text;
                row.Cells[4].Value = txtQunatity.Text;
                row.Cells[5].Value = txtDiscountAmount.Text;
                row.Cells[6].Value = txtTotalAmount.Text;
                totalamount();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Contact Admin:"+ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQunatity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public bool validate()
        {
            if ((txtIMEINO.Text == "")&&(rdbMobile.Checked))
            {
                //if (rdbMobile.Checked)
                //{
                     ms.CallMessageBox("Please enter IMEI NO.", "Missing", "ex");
                     txtIMEINO.Focus();
                    return false;
                //}
            }
            else if (ddProductSelect.SelectedIndex == 0)
            {
                ms.CallMessageBox("Please select the product name.", "Missing", "ex");
                ddProductSelect.Focus();
                return false;
            }
            else if (txtQunatity.Text== "")
            {
                ms.CallMessageBox("Please enter the no of quantity.", "Missing", "ex");
                txtQunatity.Focus();
                return false;
            }
            return true;
        }


        //bill pay and db stored bill
        private void BtnBillPay_Click(object sender, EventArgs e)
        {

            string data = "";
            for (int rows = 0; rows < dgvBillingPayment.Rows.Count-1; rows++)
            {
                DataGridViewRow row = dgvBillingPayment.Rows[rows];
                //if (row.Cells[0].Value.ToString() == "Mobile")
                //    rdbMobile.Checked = true;
                //else
                //    rdbOtherProduct.Checked = true;
                //row.Cells[1].Value = ddProductSelect.Text;
                //row.Cells[2].Value = txtIMEINO.Text;
                //row.Cells[3].Value = txtActualAmount.Text;
                //row.Cells[4].Value = txtQunatity.Text;
                //row.Cells[5].Value = txtDiscountAmount.Text;
                //row.Cells[6].Value = txtTotalAmount.Text;
                data = data+",(" +"'"+ row.Cells[0].Value.ToString() +"'"+ "," +"'"+ row.Cells[1].Value.ToString() +"'"+ "," + row.Cells[2].Value.ToString()
                  + "," + row.Cells[3].Value.ToString() + "," + row.Cells[4].Value.ToString() + "," + row.Cells[5].Value.ToString() + "," + row.Cells[6].Value.ToString()+")";
            }
            string strQry = data.TrimStart(',');
        }
       
    }
}
