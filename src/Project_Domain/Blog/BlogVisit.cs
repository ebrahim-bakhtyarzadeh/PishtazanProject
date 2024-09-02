namespace Project_Domain.Blog;

public class BlogVisit
{
	public string BlogVisitId { get; set; }
	public int BlogId { get; set; }
	public string UserId { get; set; }
	public DateTime FirstVisitedAt { get; set; }
	public DateTime LastVisitedAt { get; set; }
	public int Count { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public Blog Blog { get; set; }
	public User.User User { get; set; }

	#endregion
}