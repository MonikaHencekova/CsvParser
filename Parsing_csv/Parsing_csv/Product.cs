using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_csv
{
    public enum size_system { UK }
    public enum gender { Femme, Homme, Unisex }
    public enum age_group { Adult, Kids }

    class Product
    {
        public long ID { get; set ; }
        public string Title { get; set; }
        public string Despcirption { get; set; }
        public double Price { get; set; }
        public double Sale_price { get; set; }
        public bool Availability { get; set; }
        public string Color { get; set; }
        public size_system Size_system { get; set; }
        public gender Gender { get; set; }
        public age_group Age_group { get; set; }
        public double Display_ads_value { get; set; }
    }
}
