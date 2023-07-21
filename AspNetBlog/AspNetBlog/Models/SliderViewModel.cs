using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.Models
{
	public class SliderViewModel
	{
		public string? Name { get; set; }
		public string? Title { get; set; }
		public string? ImageUrl { get; set; }
		public DateTime Date { get; set; }
	}
}
