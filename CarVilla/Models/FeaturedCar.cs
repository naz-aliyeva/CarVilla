namespace CarVilla.Models;

public class FeaturedCar : BaseModel
{
	public string ImgUrl { get; set; }	
	public string Model { get; set; }	
	public string Name { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public double Price { get; set; }
	
}
