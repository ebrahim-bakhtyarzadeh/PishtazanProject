namespace Project_Domain.Story;

public class StoryVisit
{
	public string StoryVisitId { get; set; }
	public string StoryId { get; set; }
	public string UserId { get; set; }
	public DateTime FirstVisitedAt { get; set; }
	public DateTime LastVisitedAt { get; set; }
	public int Count { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public Story Story { get; set; }
	public User.User User { get; set; }

	#endregion
}