using System;
namespace NLayer.Core
{
	public class Product: BaseEntity
	{
		
		public string Name { get; set; }
		public int Stock { get; set; }
		public decimal Price { get; set; }

		public Category Category { get; set; } // Navigation Property
		public int CategoryId { get; set; } // Foreign Key

		public ProductFeature ProductFeature { get; set; }
	}
}

