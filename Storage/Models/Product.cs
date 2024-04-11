using System;
namespace Storage.Models
{
	public class Product
	{
        
        public int Id;
        public string Name;
        public int Price;
        public DateTime Orderdate;
        public string Category;
        public string Shelf;
        public int Count;
        public string Description;

        public Product(int Id, string Name, DateTime Orderdate, string Category, string Shelf, int Count, string Description)
		{
            this.Id = Id;
            this.Name = Name;
            this.Orderdate = Orderdate;
            this.Category = Category;
            this.Shelf = Shelf;
            this.Count = Count;
            this.Description = Description;
        }
	}
}

