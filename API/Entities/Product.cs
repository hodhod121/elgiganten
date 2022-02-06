using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Storage_Space { get; set; }       
        public string Description { get; set; }
        public string All_Features { get; set; }
        public long Price { get; set; }
        public string PictureUrl_1 { get; set; }
        public string PictureUrl_2 { get; set; }
        public string PictureUrl_3 { get; set; }
        public string PictureUrl_4 { get; set; }
        public string PictureUrl_5 { get; set; }
        public string PictureUrl_6 { get; set; }
        public string PictureUrl_7 { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public int QuantityInStock { get; set; }
        public string specifications { get; set; }
        public string All_Specifications { get; set; }
        public string Size { get; set; }
        public string Video { get; set; }

    }
}
