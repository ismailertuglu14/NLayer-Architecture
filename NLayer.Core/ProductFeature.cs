using System;
namespace NLayer.Core
{
	public class ProductFeature
	{

		public int Id { get; set; }
		public string Color { get; set; }
		public int Height { get; set; }
		public int Width { get; set; }

		public Product Product { get; set; }//Navigation Property
		public int ProductId { get; set; }//Foreign Key
	}
}

