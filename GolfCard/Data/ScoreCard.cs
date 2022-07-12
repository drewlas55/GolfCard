namespace GolfCard.Data
{
	public class ScoreCard
	{
		public DateTime Date { get; set; }

		public Course Course { get; set; }

		public List<int> Score { get; set; }

		public ScoreCard(DateTime date, Course course)
		{
			Date = date;
			Course = course;
			Score = new List<int>();
		}
	}
}
