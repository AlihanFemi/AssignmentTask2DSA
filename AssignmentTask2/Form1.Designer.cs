namespace AssignmentTask2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewWareHouse = new DataGridView();
            idColumn = new DataGridViewTextBoxColumn();
            typeColumn = new DataGridViewTextBoxColumn();
            cutColumn = new DataGridViewTextBoxColumn();
            colorColumn = new DataGridViewTextBoxColumn();
            brandColumn = new DataGridViewTextBoxColumn();
            basePriceColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtBoxID = new TextBox();
            txtBoxType = new TextBox();
            txtBoxCut = new TextBox();
            txtBoxColor = new TextBox();
            txtBoxPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAddStyle = new Button();
            groupBox1 = new GroupBox();
            btnNew = new Button();
            label9 = new Label();
            txtBoxBrand = new TextBox();
            txtBoxFabric = new TextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            btnAddSurcharge = new Button();
            txtBoxSurchargePrice = new TextBox();
            txtBoxSurchargeSize = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            comboBoxSort = new ComboBox();
            btnSort = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWareHouse).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewWareHouse
            // 
            dataGridViewWareHouse.AllowUserToAddRows = false;
            dataGridViewWareHouse.AllowUserToDeleteRows = false;
            dataGridViewWareHouse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWareHouse.Columns.AddRange(new DataGridViewColumn[] { idColumn, typeColumn, cutColumn, colorColumn, brandColumn, basePriceColumn });
            dataGridViewWareHouse.Location = new Point(259, 12);
            dataGridViewWareHouse.Name = "dataGridViewWareHouse";
            dataGridViewWareHouse.ReadOnly = true;
            dataGridViewWareHouse.Size = new Size(642, 495);
            dataGridViewWareHouse.TabIndex = 0;
            dataGridViewWareHouse.CellClick += dataGridViewWareHouse_CellClick;
            // 
            // idColumn
            // 
            idColumn.HeaderText = "ID";
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            typeColumn.HeaderText = "Type";
            typeColumn.Name = "typeColumn";
            typeColumn.ReadOnly = true;
            // 
            // cutColumn
            // 
            cutColumn.HeaderText = "Cut";
            cutColumn.Name = "cutColumn";
            cutColumn.ReadOnly = true;
            // 
            // colorColumn
            // 
            colorColumn.HeaderText = "Color";
            colorColumn.Name = "colorColumn";
            colorColumn.ReadOnly = true;
            // 
            // brandColumn
            // 
            brandColumn.HeaderText = "Brand";
            brandColumn.Name = "brandColumn";
            brandColumn.ReadOnly = true;
            // 
            // basePriceColumn
            // 
            basePriceColumn.HeaderText = "Normal Price";
            basePriceColumn.Name = "basePriceColumn";
            basePriceColumn.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // txtBoxID
            // 
            txtBoxID.Enabled = false;
            txtBoxID.Location = new Point(67, 22);
            txtBoxID.Name = "txtBoxID";
            txtBoxID.Size = new Size(100, 23);
            txtBoxID.TabIndex = 2;
            // 
            // txtBoxType
            // 
            txtBoxType.Location = new Point(67, 51);
            txtBoxType.Name = "txtBoxType";
            txtBoxType.Size = new Size(100, 23);
            txtBoxType.TabIndex = 3;
            // 
            // txtBoxCut
            // 
            txtBoxCut.Location = new Point(67, 80);
            txtBoxCut.Name = "txtBoxCut";
            txtBoxCut.Size = new Size(100, 23);
            txtBoxCut.TabIndex = 4;
            // 
            // txtBoxColor
            // 
            txtBoxColor.Location = new Point(67, 109);
            txtBoxColor.Name = "txtBoxColor";
            txtBoxColor.Size = new Size(100, 23);
            txtBoxColor.TabIndex = 5;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(67, 195);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(100, 23);
            txtBoxPrice.TabIndex = 6;
            txtBoxPrice.KeyPress += ValidateNum;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 59);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 7;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 88);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 8;
            label3.Text = "Cut";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 117);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 203);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 10;
            label5.Text = "Price";
            // 
            // btnAddStyle
            // 
            btnAddStyle.Location = new Point(67, 224);
            btnAddStyle.Name = "btnAddStyle";
            btnAddStyle.Size = new Size(100, 23);
            btnAddStyle.TabIndex = 11;
            btnAddStyle.Text = "Save";
            btnAddStyle.UseVisualStyleBackColor = true;
            btnAddStyle.Click += btnAddStyle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtBoxBrand);
            groupBox1.Controls.Add(txtBoxFabric);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtBoxID);
            groupBox1.Controls.Add(btnAddStyle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBoxType);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBoxCut);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBoxColor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBoxPrice);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 292);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Style";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(67, 253);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(100, 23);
            btnNew.TabIndex = 16;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 176);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 15;
            label9.Text = "Brand";
            // 
            // txtBoxBrand
            // 
            txtBoxBrand.Location = new Point(67, 168);
            txtBoxBrand.Name = "txtBoxBrand";
            txtBoxBrand.Size = new Size(100, 23);
            txtBoxBrand.TabIndex = 15;
            // 
            // txtBoxFabric
            // 
            txtBoxFabric.Location = new Point(67, 139);
            txtBoxFabric.Name = "txtBoxFabric";
            txtBoxFabric.Size = new Size(100, 23);
            txtBoxFabric.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 147);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 14;
            label8.Text = "Fabric";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAddSurcharge);
            groupBox2.Controls.Add(txtBoxSurchargePrice);
            groupBox2.Controls.Add(txtBoxSurchargeSize);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 310);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(224, 105);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Surcharge";
            // 
            // btnAddSurcharge
            // 
            btnAddSurcharge.Location = new Point(87, 73);
            btnAddSurcharge.Name = "btnAddSurcharge";
            btnAddSurcharge.Size = new Size(100, 23);
            btnAddSurcharge.TabIndex = 14;
            btnAddSurcharge.Text = "Save";
            btnAddSurcharge.UseVisualStyleBackColor = true;
            btnAddSurcharge.Click += btnAddSurcharge_Click;
            // 
            // txtBoxSurchargePrice
            // 
            txtBoxSurchargePrice.Location = new Point(87, 44);
            txtBoxSurchargePrice.Name = "txtBoxSurchargePrice";
            txtBoxSurchargePrice.Size = new Size(100, 23);
            txtBoxSurchargePrice.TabIndex = 14;
            txtBoxSurchargePrice.KeyPress += ValidateNum;
            // 
            // txtBoxSurchargeSize
            // 
            txtBoxSurchargeSize.Location = new Point(87, 16);
            txtBoxSurchargeSize.Name = "txtBoxSurchargeSize";
            txtBoxSurchargeSize.Size = new Size(100, 23);
            txtBoxSurchargeSize.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 47);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 14;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 19);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 14;
            label6.Text = "Size";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBoxSort);
            groupBox3.Controls.Add(btnSort);
            groupBox3.Location = new Point(15, 415);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(221, 100);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sort";
            // 
            // comboBoxSort
            // 
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "Type", "Color", "Price" });
            comboBoxSort.Location = new Point(40, 22);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(121, 23);
            comboBoxSort.TabIndex = 15;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(40, 69);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(121, 23);
            btnSort.TabIndex = 15;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 519);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewWareHouse);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridViewWareHouse).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewWareHouse;
        private Label label1;
        private TextBox txtBoxID;
        private TextBox txtBoxType;
        private TextBox txtBoxCut;
        private TextBox txtBoxColor;
        private TextBox txtBoxPrice;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAddStyle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnAddSurcharge;
        private TextBox txtBoxSurchargePrice;
        private TextBox txtBoxSurchargeSize;
        private Label label7;
        private Label label6;
        private TextBox txtBoxFabric;
        private Label label8;
        private Label label9;
        private TextBox txtBoxBrand;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn typeColumn;
        private DataGridViewTextBoxColumn cutColumn;
        private DataGridViewTextBoxColumn colorColumn;
        private DataGridViewTextBoxColumn brandColumn;
        private DataGridViewTextBoxColumn basePriceColumn;
        private GroupBox groupBox3;
        private Button btnSort;
        private ComboBox comboBoxSort;
        private Button btnNew;
    }
}
