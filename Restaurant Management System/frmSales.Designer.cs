﻿namespace Restaurant_Management_System
{
    partial class frmSales
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            this.Label13 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Button7 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtSaleQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiscountPer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.Label19 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtTaxAmt = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txtTaxPer = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.NewRecord = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.txtCurrencyID = new System.Windows.Forms.TextBox();
            this.txtHotelID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BackColor = System.Drawing.Color.PeachPuff;
            this.Label13.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(38, 16);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(60, 22);
            this.Label13.TabIndex = 96;
            this.Label13.Text = "Billing";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.cmbProductName);
            this.GroupBox1.Controls.Add(this.txtTotalAmount);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Button7);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.txtSaleQty);
            this.GroupBox1.Controls.Add(this.txtPrice);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Location = new System.Drawing.Point(37, 184);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(651, 147);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Product Details";
            // 
            // cmbProductName
            // 
            this.cmbProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(138, 25);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(401, 25);
            this.cmbProductName.TabIndex = 0;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(138, 103);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(132, 24);
            this.txtTotalAmount.TabIndex = 3;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(295, 67);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(56, 17);
            this.Label11.TabIndex = 89;
            this.Label11.Text = "Quantity";
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.Location = new System.Drawing.Point(558, 27);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(87, 23);
            this.Button7.TabIndex = 4;
            this.Button7.Text = "&Add To Cart";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(26, 27);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(87, 17);
            this.Label5.TabIndex = 74;
            this.Label5.Text = "Product Name";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(26, 64);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(61, 17);
            this.Label12.TabIndex = 87;
            this.Label12.Text = "Unit Price";
            // 
            // txtSaleQty
            // 
            this.txtSaleQty.Location = new System.Drawing.Point(370, 64);
            this.txtSaleQty.Name = "txtSaleQty";
            this.txtSaleQty.Size = new System.Drawing.Size(89, 24);
            this.txtSaleQty.TabIndex = 2;
            this.txtSaleQty.TextChanged += new System.EventHandler(this.txtSaleQty_TextChanged);
            this.txtSaleQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaleQty_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(138, 64);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(89, 24);
            this.txtPrice.TabIndex = 1;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(26, 103);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(85, 17);
            this.Label10.TabIndex = 76;
            this.Label10.Text = "Total Amount";
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.columnHeader6,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
            this.ListView1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(37, 344);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(651, 320);
            this.ListView1.TabIndex = 108;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Product ID";
            this.columnHeader6.Width = 80;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Product Name";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 270;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Unit Price";
            this.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader3.Width = 90;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Qty.";
            this.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader4.Width = 85;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Total Amount";
            this.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader5.Width = 120;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.txtDiscountAmount);
            this.Panel2.Controls.Add(this.label17);
            this.Panel2.Controls.Add(this.txtDiscountPer);
            this.Panel2.Controls.Add(this.label8);
            this.Panel2.Controls.Add(this.txtChange);
            this.Panel2.Controls.Add(this.txtCash);
            this.Panel2.Controls.Add(this.Label19);
            this.Panel2.Controls.Add(this.payment);
            this.Panel2.Controls.Add(this.txtTotal);
            this.Panel2.Controls.Add(this.Label16);
            this.Panel2.Controls.Add(this.txtTaxAmt);
            this.Panel2.Controls.Add(this.Label24);
            this.Panel2.Controls.Add(this.txtTaxPer);
            this.Panel2.Controls.Add(this.Label15);
            this.Panel2.Controls.Add(this.txtSubTotal);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Location = new System.Drawing.Point(697, 403);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(315, 226);
            this.Panel2.TabIndex = 109;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Location = new System.Drawing.Point(220, 85);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(80, 24);
            this.txtDiscountAmount.TabIndex = 7;
            this.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(174, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 21);
            this.label17.TabIndex = 101;
            this.label17.Text = "%";
            // 
            // txtDiscountPer
            // 
            this.txtDiscountPer.Location = new System.Drawing.Point(116, 86);
            this.txtDiscountPer.Name = "txtDiscountPer";
            this.txtDiscountPer.Size = new System.Drawing.Size(52, 24);
            this.txtDiscountPer.TabIndex = 1;
            this.txtDiscountPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountPer.TextChanged += new System.EventHandler(this.txtDiscountPer_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 99;
            this.label8.Text = "Discount";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(116, 186);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(81, 24);
            this.txtChange.TabIndex = 8;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCash
            // 
            this.txtCash.Location = new System.Drawing.Point(116, 153);
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(81, 24);
            this.txtCash.TabIndex = 2;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCash.TextChanged += new System.EventHandler(this.txtTotalPayment_TextChanged);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCash_KeyPress);
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.Location = new System.Drawing.Point(19, 186);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(50, 17);
            this.Label19.TabIndex = 96;
            this.Label19.Text = "Change";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(19, 154);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(35, 17);
            this.payment.TabIndex = 95;
            this.payment.Text = "Cash";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(116, 120);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(81, 24);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(19, 120);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(75, 17);
            this.Label16.TabIndex = 94;
            this.Label16.Text = "Grand Total";
            // 
            // txtTaxAmt
            // 
            this.txtTaxAmt.Location = new System.Drawing.Point(220, 50);
            this.txtTaxAmt.Name = "txtTaxAmt";
            this.txtTaxAmt.ReadOnly = true;
            this.txtTaxAmt.Size = new System.Drawing.Size(80, 24);
            this.txtTaxAmt.TabIndex = 6;
            this.txtTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.Transparent;
            this.Label24.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.Color.Black;
            this.Label24.Location = new System.Drawing.Point(174, 50);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(23, 21);
            this.Label24.TabIndex = 92;
            this.Label24.Text = "%";
            // 
            // txtTaxPer
            // 
            this.txtTaxPer.Location = new System.Drawing.Point(116, 51);
            this.txtTaxPer.Name = "txtTaxPer";
            this.txtTaxPer.Size = new System.Drawing.Size(52, 24);
            this.txtTaxPer.TabIndex = 0;
            this.txtTaxPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxPer.TextChanged += new System.EventHandler(this.txtTaxPer_TextChanged);
            this.txtTaxPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxPer_KeyPress);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(20, 54);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(55, 17);
            this.Label15.TabIndex = 90;
            this.Label15.Text = "VAT+ST";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(116, 17);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(184, 24);
            this.txtSubTotal.TabIndex = 5;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(19, 19);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(61, 17);
            this.Label14.TabIndex = 77;
            this.Label14.Text = "Sub Total";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Location = new System.Drawing.Point(697, 344);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtRemarks.Size = new System.Drawing.Size(317, 53);
            this.txtRemarks.TabIndex = 118;
            this.txtRemarks.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(694, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 119;
            this.label7.Text = "Remarks";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(694, 635);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 29);
            this.btnRemove.TabIndex = 110;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(786, 635);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(99, 29);
            this.btnPrint.TabIndex = 111;
            this.btnPrint.Text = "&Print Invoice";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.btnGetData);
            this.Panel1.Controls.Add(this.btnUpdate);
            this.Panel1.Controls.Add(this.NewRecord);
            this.Panel1.Controls.Add(this.Delete);
            this.Panel1.Controls.Add(this.Save);
            this.Panel1.Location = new System.Drawing.Point(704, 39);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(112, 195);
            this.Panel1.TabIndex = 112;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(14, 149);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(84, 29);
            this.btnGetData.TabIndex = 101;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(14, 113);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 29);
            this.btnUpdate.TabIndex = 100;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // NewRecord
            // 
            this.NewRecord.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRecord.Location = new System.Drawing.Point(14, 8);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(84, 29);
            this.NewRecord.TabIndex = 0;
            this.NewRecord.Text = "&New";
            this.NewRecord.UseVisualStyleBackColor = true;
            this.NewRecord.Click += new System.EventHandler(this.NewRecord_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(14, 78);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(84, 29);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "&Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(14, 43);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(84, 29);
            this.Save.TabIndex = 1;
            this.Save.Text = "&Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(439, 12);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 24);
            this.txtProductID.TabIndex = 114;
            this.txtProductID.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(335, 12);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.Size = new System.Drawing.Size(100, 24);
            this.txtBillID.TabIndex = 120;
            this.txtBillID.Visible = false;
            // 
            // txtCurrencyID
            // 
            this.txtCurrencyID.Location = new System.Drawing.Point(651, 9);
            this.txtCurrencyID.Name = "txtCurrencyID";
            this.txtCurrencyID.Size = new System.Drawing.Size(100, 24);
            this.txtCurrencyID.TabIndex = 121;
            this.txtCurrencyID.Visible = false;
            // 
            // txtHotelID
            // 
            this.txtHotelID.Location = new System.Drawing.Point(545, 12);
            this.txtHotelID.Name = "txtHotelID";
            this.txtHotelID.Size = new System.Drawing.Size(100, 24);
            this.txtHotelID.TabIndex = 122;
            this.txtHotelID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmbCurrency);
            this.groupBox2.Controls.Add(this.Label6);
            this.groupBox2.Controls.Add(this.txtBillNo);
            this.groupBox2.Controls.Add(this.dtpBillDate);
            this.groupBox2.Controls.Add(this.Label4);
            this.groupBox2.Controls.Add(this.Label3);
            this.groupBox2.Location = new System.Drawing.Point(37, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 134);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bill Info";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCurrency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(138, 92);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(120, 25);
            this.cmbCurrency.TabIndex = 2;
            this.cmbCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(26, 92);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(59, 17);
            this.Label6.TabIndex = 130;
            this.Label6.Text = "Currency";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(138, 23);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.ReadOnly = true;
            this.txtBillNo.Size = new System.Drawing.Size(120, 24);
            this.txtBillNo.TabIndex = 0;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CustomFormat = "dd/MMM/yyyy";
            this.dtpBillDate.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillDate.Location = new System.Drawing.Point(138, 57);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(120, 24);
            this.dtpBillDate.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(26, 26);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 17);
            this.Label4.TabIndex = 127;
            this.Label4.Text = "Bill No.";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(26, 57);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(54, 17);
            this.Label3.TabIndex = 128;
            this.Label3.Text = "Bill Date";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Restaurant_Management_System.Properties.Resources._0088181331020_Color_Sky_Blue_SW_60X601;
            this.ClientSize = new System.Drawing.Size(1024, 676);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtHotelID);
            this.Controls.Add(this.txtCurrencyID);
            this.Controls.Add(this.txtBillID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label13);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtTotalAmount;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button Button7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtSaleQty;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader3;
        internal System.Windows.Forms.ColumnHeader ColumnHeader4;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox txtChange;
        internal System.Windows.Forms.TextBox txtCash;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label payment;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtTaxAmt;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txtTaxPer;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtSubTotal;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button NewRecord;
        internal System.Windows.Forms.Button Delete;
        internal System.Windows.Forms.Button Save;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        public System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.RichTextBox txtRemarks;
        public System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.TextBox txtDiscountAmount;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox txtDiscountPer;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Button btnGetData;
        public System.Windows.Forms.TextBox txtBillID;
        public System.Windows.Forms.TextBox txtCurrencyID;
        public System.Windows.Forms.TextBox txtHotelID;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.ComboBox cmbCurrency;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtBillNo;
        internal System.Windows.Forms.DateTimePicker dtpBillDate;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
    }
}