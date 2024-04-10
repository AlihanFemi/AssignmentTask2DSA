using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask2
{
    public static class ClothingShop
    {
        private readonly static string FILEPATH = "C:/Users/DELL/Desktop/Code Related/Data S&A/AssignmentTask2/AssignmentTask2/styles.txt";
        private static Dictionary<int, Style> warehouse = new Dictionary<int, Style>();

        public static TextBox txtBoxID;
        public static TextBox txtBoxType;
        public static TextBox txtBoxCut;
        public static TextBox txtBoxColor;
        public static TextBox txtBoxFabric;
        public static TextBox txtBoxBrand;
        public static TextBox txtBoxBasePrice;

        public static TextBox txtBoxSurchargeSize;
        public static TextBox txtBoxSurchargePrice;

        public static DataGridView dataGridViewWarehouse;
        
        public static void Init()
        {
            ClothingShop.LoadData();
            ClothingShop.DisplayStyle(0);
        }

        private static void Show(Style cloth)
        {
            ClothingShop.dataGridViewWarehouse.Rows.Add(cloth.GetID(), cloth.GetType(), cloth.GetCut(), cloth.GetColor(),
                cloth.GetBrand(), cloth.CalculatePrice());
        }
        public static void AddStyle(Style cloth)
        {
            ClothingShop.warehouse.Add(cloth.GetID(), cloth);
            ClothingShop.Show(cloth);
            ClothingShop.DisplayStyle(cloth.GetID());
        }
        public static void ModifyStyle(int id, string type, string cut, string color, string fabric, string brand, double basePrice)
        {
            if (!ClothingShop.warehouse.ContainsKey(id))
                throw new ArgumentException("This style does not exist!");

            ClothingShop.warehouse[id].Update(type, cut, color, fabric, brand, basePrice);
            foreach(DataGridViewRow row in ClothingShop.dataGridViewWarehouse.Rows)
            {
                int value = (int)(row.Cells[0]).Value;
                if (value == id)
                {
                    row.SetValues(id, type, cut, color, brand, basePrice);
                    break;
                }
            }
        }
        public static void DeleteStyle(int id)
        {
            if (!ClothingShop.warehouse.ContainsKey(id))
                throw new ArgumentException("This style does not exist!");

            ClothingShop.warehouse.Remove(id);
        }
        public static Style GetStyle(int id)
        {
            if (!ClothingShop.warehouse.ContainsKey(id))
                throw new ArgumentException("This style does not exist!");

            return ClothingShop.warehouse[id];
        }
        public static void SaveData()
        {
            string[] lines = new string[ClothingShop.warehouse.Count];
            int i = 0;
            foreach (var item in ClothingShop.warehouse)
            {
                lines[i] = item.Value.StringToSave();
                i++;
            }
            File.WriteAllLines(ClothingShop.FILEPATH, lines);
        }
        private static void LoadData()
        {
            string[] lines = File.ReadAllLines(ClothingShop.FILEPATH);
            foreach (string line in lines)
            {
                Style cloth = Style.StyleFactory(line);
                ClothingShop.warehouse.Add(cloth.GetID(), cloth);
                ClothingShop.Show(cloth);
            }
        }
        public static void AddSurchargeByID(int id, string size, double price)
        {
            if (!ClothingShop.warehouse.ContainsKey(id))
                throw new ArgumentException("This style does not exist!");

            ClothingShop.warehouse[id].AddSurcharge(size, price);
        }
        public static void DisplayStyle(int id)
        {
            if (!ClothingShop.warehouse.ContainsKey(id))
                throw new ArgumentException("This style does not exist!");

            Style cloth = ClothingShop.warehouse[id];
            ClothingShop.txtBoxID.Text = id.ToString();
            ClothingShop.txtBoxType.Text = cloth.GetType();
            ClothingShop.txtBoxCut.Text = cloth.GetCut();
            ClothingShop.txtBoxColor.Text = cloth.GetColor();
            ClothingShop.txtBoxFabric.Text = cloth.GetFabric();
            ClothingShop.txtBoxBrand.Text = cloth.GetBrand();
            ClothingShop.txtBoxBasePrice.Text = cloth.CalculatePrice().ToString();
        }
        public static bool HasStyle(int id)
        {
            return ClothingShop.warehouse.ContainsKey(id);
        }

        /// <summary>
        ///  You cannot sort a Dictionary. So I sorted the dataGridView.
        /// </summary>
        public static void SortByType()
        {
            dataGridViewWarehouse.Rows.Clear();
            foreach(var item in ClothingShop.warehouse.OrderBy(x => x.Value.GetType()))
            {
                var value = item.Value;
                dataGridViewWarehouse.Rows.Add(value.GetID(), value.GetType(), value.GetCut(), value.GetColor(),
                    value.GetBrand(), value.CalculatePrice());
            }

        }
        public static void SortByColor()
        {
            dataGridViewWarehouse.Rows.Clear();
            foreach (var item in ClothingShop.warehouse.OrderBy(x => x.Value.GetColor()))
            {
                var value = item.Value;
                dataGridViewWarehouse.Rows.Add(value.GetID(), value.GetType(), value.GetCut(), value.GetColor(),
                    value.GetBrand(), value.CalculatePrice());
            }
        }
        public static void SortByPrice()
        {
            dataGridViewWarehouse.Rows.Clear();
            foreach(var item in ClothingShop.warehouse.OrderBy(x => x.Value.CalculatePrice()))
            {
                var value = item.Value;
                dataGridViewWarehouse.Rows.Add(value.GetID(), value.GetType(), value.GetCut(), value.GetColor(),
                    value.GetBrand(), value.CalculatePrice());
            }
        }
    }
}
