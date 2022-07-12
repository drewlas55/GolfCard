using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GolfCard.Data
{
	public class Hole
	{
		[Key]
		public int Id { get; set; }
		public int Number { get; set; }
		public int Par { get; set; }
		public int Length { get; set; }
		[ForeignKey("Course")]
		public int CourseID { get; set; }

		public Hole(int Number, int CourseID)
        {
			this.Number = Number;
			this.CourseID = CourseID;
        }

		public Hole() { }
	}
}
