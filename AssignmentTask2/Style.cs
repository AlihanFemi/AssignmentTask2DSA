using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask2
{
    public class Style
    {
        private readonly static string seperator = "|";
        private static int autoID = 0;
        int ID;
        string Type;
        string Cut;
        string Color;
        string Fabric;
        string Brand;
        double BasePrice;
        Dictionary<string, double> SizePriceSurcharges;

        public Style(string typeParam, string cutParam, string colorParam, string fabricParam, string brandParam, double priceParam)
        {
            this.ID = autoID;
            this.Type = typeParam;
            this.Cut = cutParam;
            this.Color = colorParam;
            this.Fabric = fabricParam;
            this.Brand = brandParam;
            this.BasePrice = priceParam;
            this.SizePriceSurcharges = new Dictionary<string, double>();
            Style.autoID++;
        }
        public static Style StyleFactory(string line)
        {
            string[] items = line.Split(Style.seperator);
            Style.autoID = int.Parse(items[0]);
            string typeParam = items[1];
            string cutParam = items[2];
            string colorParam = items[3];
            string fabricParam = items[4];
            string brandParam = items[5];
            double priceParam = double.Parse(items[6]);
            Style cloth = new Style(typeParam, cutParam, colorParam, fabricParam, brandParam, priceParam);
            if (String.IsNullOrEmpty(items[7]))
                return cloth;
            else
            {
                string[] surcharges = items[7].Split(",");
                foreach (string surcharge in surcharges)
                {
                    if(String.IsNullOrEmpty(surcharge))
                        break;
                    string[] size_price = surcharge.Split("-");
                    string size = size_price[0];
                    double price = double.Parse(size_price[1]);
                    cloth.AddSurcharge(size, price);
                }
                return cloth;
            }
        }
        public void AddSurcharge(string size, double price)
        {
            if (this.SizePriceSurcharges.ContainsKey(size.ToUpper()))
                throw new ArgumentException("This size already exists!");

            this.SizePriceSurcharges.Add(size.ToUpper(), price);
        }
        public void ModifySurcharge(string size, double newPrice)
        {
            if (!this.SizePriceSurcharges.ContainsKey(size.ToUpper()))
                throw new ArgumentException("This size doesn't exist!");

            this.SizePriceSurcharges[size.ToUpper()] = newPrice;
        }
        public void RemoveSurcharge(string size)
        {
            if (!this.SizePriceSurcharges.ContainsKey(size.ToUpper()))
                throw new ArgumentException("This size doesn't exist!");

            this.SizePriceSurcharges.Remove(size.ToUpper());
        }
        public double CalculatePrice(string? size = null)
        {
            if (size != null && !this.SizePriceSurcharges.ContainsKey(size))
                throw new ArgumentException("This size doesn't exist!");
            if (size == null)
                return this.BasePrice;

            return this.BasePrice + this.SizePriceSurcharges[size.ToUpper()];
        }
        private string SurchargeStringToSave()
        {
            string str = "";
            foreach(var item in this.SizePriceSurcharges)
            {
                str += $"{item.Key}-{item.Value},";
            }
            return str;
        }
        public string StringToSave()
        {
            return $"{this.ID}{Style.seperator}{this.Type}{Style.seperator}{this.Cut}{Style.seperator}{this.Color}" +
                $"{Style.seperator}{this.Fabric}{Style.seperator}{this.Brand}{Style.seperator}{this.BasePrice}" +
                $"{Style.seperator}{this.SurchargeStringToSave()}";
        }
        public int GetID()
        {
            return this.ID;
        }
        public string GetType()
        {
            return this.Type;
        }
        public string GetCut()
        {
            return this.Cut;
        }
        public string GetColor()
        {
            return this.Color;
        }
        public string GetFabric()
        {
            return this.Fabric;
        }
        public string GetBrand()
        {
            return this.Brand;
        }
        public void Update(string typeParam, string cutParam, string colorParam,
            string fabricParam, string brandParam, double basePriceParam)
        {
            this.Type = typeParam;
            this.Cut = cutParam;
            this.Color = colorParam;
            this.Fabric = fabricParam;
            this.Brand = brandParam;
            this.BasePrice = basePriceParam;
        }
    }
}
