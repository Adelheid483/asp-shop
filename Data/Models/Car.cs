namespace asp_shop.Data.Models
{
    public class Car
    {
        // variables
        public int id { set; get; }
        public string name { set; get; }
        public string shortDescription { set; get; }
        public string longDescription { set; get; }
        public string img { set; get; } // url
        public ushort price { set; get; } // only for positive values
        public bool isFavorite { set; get; }
        public bool available { set; get; }
        public int categoryID { set; get; } // assigning to a specific only ONE category (id in Category class)
        public virtual Category Category { set; get; } // creating object based on Category class

    }
}