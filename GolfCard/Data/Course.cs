using System.ComponentModel.DataAnnotations;

namespace GolfCard.Data
{
	public class Course
	{
		[Required]
		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(100)]
		public string Name { get; set; }
		public bool Complete { get; set; } = false;

		public string Url
		{
			get
			{
				return "course/" + this.Id;
			}
		}

		public Course(string name)
		{
			Name = name;
		}
	}
}
