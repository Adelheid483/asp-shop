namespace asp_shop.Data.Models
{
    public class Car
    {
        // variables
        public int Id { set; get; }
        public string Name { set; get; }
        public string ShortDescription { set; get; }
        public string LongDescription { set; get; }
        public string Img { set; get; } // url
        public ushort Price { set; get; } // only for positive values
        public bool IsFavorite { set; get; }
        public bool Available { set; get; }
        public int CategoryIdCar { set; get; } // assigning to a specific only ONE category (id in Category class)
        public virtual Category Category { set; get; } // creating object based on Category class
    }
}