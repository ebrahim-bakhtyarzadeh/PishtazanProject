namespace Project_Domain.Post;

public class PostVisit
{
	public string PostVisitId { get; set; }
	public string PostId { get; set; }
	public string UserId { get; set; }
	public DateTime FirstVisitedAt { get; set; }
	public DateTime LastVisitedAt { get; set; }
	public int Count { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public Post Post { get; set; }
	public User.User User { get; set; }

	#endregion
}