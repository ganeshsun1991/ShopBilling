namespace Shop_Billing
{
    partial class frmBilling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbOtherProduct = new System.Windows.Forms.RadioButton();
            this.rdbMobile = new System.Windows.Forms.RadioButton();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.ddProductSelect = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtActualAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQunatity = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIMEINO = new System.Windows.Forms.TextBox();
            this.lblIMEINO = new System.Windows.Forms.Label();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMEINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoofQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsum = new System.Windows.Forms.TextBox();
            this.dgvBillingPayment = new System.Windows.Forms.DataGridView();
            this.dvProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvIMEINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvActualAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvNoofQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvDiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBillPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillingPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbOtherProduct
            // 
            this.rdbOtherProduct.AutoSize = true;
            this.rdbOtherProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOtherProduct.Location = new System.Drawing.Point(310, 75);
            this.rdbOtherProduct.Name = "rdbOtherProduct";
            this.rdbOtherProduct.Size = new System.Drawing.Size(107, 20);
            this.rdbOtherProduct.TabIndex = 15;
            this.rdbOtherProduct.TabStop = true;
            this.rdbOtherProduct.Text = "Other Product";
            this.rdbOtherProduct.UseVisualStyleBackColor = true;
            // 
            // rdbMobile
            // 
            this.rdbMobile.AutoSize = true;
            this.rdbMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMobile.Location = new System.Drawing.Point(203, 75);
            this.rdbMobile.Name = "rdbMobile";
            this.rdbMobile.Size = new System.Drawing.Size(67, 20);
            this.rdbMobile.TabIndex = 14;
            this.rdbMobile.TabStop = true;
            this.rdbMobile.Text = "Mobile";
            this.rdbMobile.UseVisualStyleBackColor = true;
            this.rdbMobile.CheckedChanged += new System.EventHandler(this.rdbMobile_CheckedChanged);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(33, 75);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(91, 19);
            this.lblProductType.TabIndex = 16;
            this.lblProductType.Text = "Product Type";
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductDetails.Location = new System.Drawing.Point(368, 21);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(131, 20);
            this.lblProductDetails.TabIndex = 17;
            this.lblProductDetails.Text = "Billing Payment";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(33, 117);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(98, 19);
            this.lblProductName.TabIndex = 18;
            this.lblProductName.Text = "Product Name";
            // 
            // ddProductSelect
            // 
            this.ddProductSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddProductSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddProductSelect.Location = new System.Drawing.Point(203, 117);
            this.ddProductSelect.Name = "ddProductSelect";
            this.ddProductSelect.Size = new System.Drawing.Size(214, 24);
            this.ddProductSelect.TabIndex = 19;
            this.ddProductSelect.SelectedIndexChanged += new System.EventHandler(this.ddProductSelect_SelectedIndexChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(33, 157);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(99, 19);
            this.lblAmount.TabIndex = 20;
            this.lblAmount.Text = "Actual Amount";
            // 
            // txtActualAmount
            // 
            this.txtActualAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualAmount.Location = new System.Drawing.Point(203, 156);
            this.txtActualAmount.Name = "txtActualAmount";
            this.txtActualAmount.ReadOnly = true;
            this.txtActualAmount.Size = new System.Drawing.Size(214, 22);
            this.txtActualAmount.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "No of Quantity";
            // 
            // txtQunatity
            // 
            this.txtQunatity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQunatity.Location = new System.Drawing.Point(203, 196);
            this.txtQunatity.Name = "txtQunatity";
            this.txtQunatity.Size = new System.Drawing.Size(214, 22);
            this.txtQunatity.TabIndex = 23;
            this.txtQunatity.TextChanged += new System.EventHandler(this.txtQunatity_TextChanged);
            this.txtQunatity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQunatity_KeyPress);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(203, 237);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(214, 22);
            this.txtTotalAmount.TabIndex = 25;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(33, 239);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(90, 19);
            this.lblTotalAmount.TabIndex = 24;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Location = new System.Drawing.Point(489, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 31);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Location = new System.Drawing.Point(399, 278);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 31);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(579, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 29;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(309, 278);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(84, 31);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Location = new System.Drawing.Point(219, 278);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 31);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(464, 120);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(109, 19);
            this.lblCustomerName.TabIndex = 32;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(465, 160);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(81, 19);
            this.lblContactNo.TabIndex = 33;
            this.lblContactNo.Text = "Contact No";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(597, 159);
            this.txtContactNo.MaxLength = 10;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(214, 22);
            this.txtContactNo.TabIndex = 34;
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQunatity_KeyPress);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(599, 117);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(214, 22);
            this.txtCustomerName.TabIndex = 35;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountAmount.Location = new System.Drawing.Point(597, 195);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.Size = new System.Drawing.Size(216, 22);
            this.txtDiscountAmount.TabIndex = 36;
            this.txtDiscountAmount.TextChanged += new System.EventHandler(this.txtQunatity_TextChanged);
            this.txtDiscountAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQunatity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Discount Amount";
            // 
            // txtIMEINO
            // 
            this.txtIMEINO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMEINO.Location = new System.Drawing.Point(599, 77);
            this.txtIMEINO.Name = "txtIMEINO";
            this.txtIMEINO.Size = new System.Drawing.Size(214, 22);
            this.txtIMEINO.TabIndex = 39;
            this.txtIMEINO.Visible = false;
            // 
            // lblIMEINO
            // 
            this.lblIMEINO.AutoSize = true;
            this.lblIMEINO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMEINO.Location = new System.Drawing.Point(465, 78);
            this.lblIMEINO.Name = "lblIMEINO";
            this.lblIMEINO.Size = new System.Drawing.Size(70, 19);
            this.lblIMEINO.TabIndex = 38;
            this.lblIMEINO.Text = "IMEI NO";
            this.lblIMEINO.Visible = false;
            // 
            // ProductType
            // 
            this.ProductType.HeaderText = "ProductType";
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            this.ProductType.Width = 136;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 135;
            // 
            // IMEINO
            // 
            this.IMEINO.HeaderText = "IMEI NO";
            this.IMEINO.Name = "IMEINO";
            this.IMEINO.Visible = false;
            // 
            // ActualAmount
            // 
            this.ActualAmount.HeaderText = "Actual Amount";
            this.ActualAmount.Name = "ActualAmount";
            this.ActualAmount.ReadOnly = true;
            this.ActualAmount.Width = 136;
            // 
            // NoofQuantity
            // 
            this.NoofQuantity.HeaderText = "No of Quantity";
            this.NoofQuantity.Name = "NoofQuantity";
            this.NoofQuantity.ReadOnly = true;
            this.NoofQuantity.Width = 135;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.HeaderText = "Discount Amount";
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.Width = 136;
            // 
            // txtsum
            // 
            this.txtsum.Location = new System.Drawing.Point(844, 618);
            this.txtsum.Name = "txtsum";
            this.txtsum.Size = new System.Drawing.Size(100, 20);
            this.txtsum.TabIndex = 40;
            // 
            // dgvBillingPayment
            // 
            this.dgvBillingPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillingPayment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBillingPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillingPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvProductType,
            this.dvProductName,
            this.dvIMEINO,
            this.dvActualAmount,
            this.dvNoofQuantity,
            this.dvDiscountAmount,
            this.dvTotalAmount});
            this.dgvBillingPayment.Location = new System.Drawing.Point(12, 333);
            this.dgvBillingPayment.Name = "dgvBillingPayment";
            this.dgvBillingPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillingPayment.Size = new System.Drawing.Size(932, 270);
            this.dgvBillingPayment.TabIndex = 41;
            this.dgvBillingPayment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillingPayment_CellClick);
            // 
            // dvProductType
            // 
            this.dvProductType.HeaderText = "Product Type";
            this.dvProductType.Name = "dvProductType";
            // 
            // dvProductName
            // 
            this.dvProductName.HeaderText = "Product Name";
            this.dvProductName.Name = "dvProductName";
            // 
            // dvIMEINO
            // 
            this.dvIMEINO.HeaderText = "IMEI NO";
            this.dvIMEINO.Name = "dvIMEINO";
            // 
            // dvActualAmount
            // 
            this.dvActualAmount.HeaderText = "Actual Amount";
            this.dvActualAmount.Name = "dvActualAmount";
            // 
            // dvNoofQuantity
            // 
            this.dvNoofQuantity.HeaderText = "No of Quantity";
            this.dvNoofQuantity.Name = "dvNoofQuantity";
            // 
            // dvDiscountAmount
            // 
            this.dvDiscountAmount.HeaderText = "Discount Amount";
            this.dvDiscountAmount.Name = "dvDiscountAmount";
            // 
            // dvTotalAmount
            // 
            this.dvTotalAmount.HeaderText = "Total Amount";
            this.dvTotalAmount.Name = "dvTotalAmount";
            // 
            // BtnBillPay
            // 
            this.BtnBillPay.Location = new System.Drawing.Point(399, 612);
            this.BtnBillPay.Name = "BtnBillPay";
            this.BtnBillPay.Size = new System.Drawing.Size(93, 31);
            this.BtnBillPay.TabIndex = 42;
            this.BtnBillPay.Text = "Print";
            this.BtnBillPay.UseVisualStyleBackColor = true;
            this.BtnBillPay.Click += new System.EventHandler(this.BtnBillPay_Click);
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 661);
            this.Controls.Add(this.BtnBillPay);
            this.Controls.Add(this.dgvBillingPayment);
            this.Controls.Add(this.txtsum);
            this.Controls.Add(this.txtIMEINO);
            this.Controls.Add(this.lblIMEINO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiscountAmount);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txtQunatity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActualAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.ddProductSelect);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.rdbOtherProduct);
            this.Controls.Add(this.rdbMobile);
            this.Controls.Add(this.lblProductType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBilling";
            this.Load += new System.EventHandler(this.frmBilling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillingPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbOtherProduct;
        private System.Windows.Forms.RadioButton rdbMobile;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox ddProductSelect;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtActualAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQunatity;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIMEINO;
        private System.Windows.Forms.Label lblIMEINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMEINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoofQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmount;
        private System.Windows.Forms.TextBox txtsum;
        private System.Windows.Forms.DataGridView dgvBillingPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvIMEINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvActualAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvNoofQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvDiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvTotalAmount;
        private System.Windows.Forms.Button BtnBillPay;
    }
}