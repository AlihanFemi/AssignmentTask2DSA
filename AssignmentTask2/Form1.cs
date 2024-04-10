namespace AssignmentTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClothingShop.txtBoxID = txtBoxID;
            ClothingShop.txtBoxType = txtBoxType;
            ClothingShop.txtBoxCut = txtBoxCut;
            ClothingShop.txtBoxColor = txtBoxColor;
            ClothingShop.txtBoxFabric = txtBoxFabric;
            ClothingShop.txtBoxBrand = txtBoxBrand;
            ClothingShop.txtBoxBasePrice = txtBoxPrice;
            ClothingShop.txtBoxSurchargeSize = txtBoxSurchargeSize;
            ClothingShop.txtBoxSurchargePrice = txtBoxSurchargePrice;
            ClothingShop.dataGridViewWarehouse = dataGridViewWareHouse;
            ClothingShop.Init();
        }

        private void btnAddStyle_Click(object sender, EventArgs e)
        {
            string type = txtBoxType.Text;
            string cut = txtBoxCut.Text;
            string color = txtBoxColor.Text;
            string fabric = txtBoxFabric.Text;
            string brand = txtBoxBrand.Text;
            double basePrice = double.Parse(txtBoxPrice.Text);
            if (String.IsNullOrEmpty(txtBoxID.Text))
            {
                Style cloth = new Style(type, cut, color, fabric, brand, basePrice);
                ClothingShop.AddStyle(cloth);
                txtBoxID.Text = cloth.GetID().ToString();
            }
            else
            {
                int id = int.Parse(txtBoxID.Text);
                ClothingShop.ModifyStyle(id, type, cut, color, fabric, brand, basePrice);
            }
        }

        private void btnAddSurcharge_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBoxID.Text);
            string size = txtBoxSurchargeSize.Text;
            double price = double.Parse(txtBoxSurchargePrice.Text);

            ClothingShop.AddSurchargeByID(id, size, price);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClothingShop.SaveData();
        }

        private void dataGridViewWareHouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)(dataGridViewWareHouse.Rows[e.RowIndex].Cells[0].Value);
            ClothingShop.DisplayStyle(id);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBoxID.Text = "";
            txtBoxType.Text = "";
            txtBoxCut.Text = "";
            txtBoxColor.Text = "";
            txtBoxFabric.Text = "";
            txtBoxBrand.Text = "";
            txtBoxPrice.Text = "";
            txtBoxSurchargeSize.Text = "";
            txtBoxSurchargePrice.Text = "";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string option = comboBoxSort.Text;
            if (option == "Type")
                ClothingShop.SortByType();
            else if (option == "Color")
                ClothingShop.SortByColor();
            else if (option == "Price")
                ClothingShop.SortByPrice();
        }

        private void ValidateNum(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (Char.IsDigit(key) || Char.IsControl(key) || key == '.')
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
