namespace Project_Domain.Story;

public class StoryLike
{
	public string StoryLikeId { get; set; }
	public string StoryId { get; set; }
	public string UserId { get; set; }
	public DateTime LikedAt { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public Story Story { get; set; }
	public User.User User { get; set; }

	#endregion
}