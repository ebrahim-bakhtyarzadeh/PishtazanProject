namespace Project_Domain.Story;

public class Story
{
	public string StoryId { get; set; }
	public string UserId { get; set; }
	public DateTime CreatedAt { get; set; }
	public string? ImageName { get; set; }
	public string? VideoName { get; set; }
	public string? Caption { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public User.User User { get; set; }
	public ICollection<StoryComment> StoryComments { get; set; }
	public ICollection<StoryLike> StoryLikes { get; set; }
	public ICollection<StoryVisit> StoryVisits { get; set; }

	#endregion
}