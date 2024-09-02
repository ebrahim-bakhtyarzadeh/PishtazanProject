namespace Project_Domain.User;

public class UserFollower
{
	public string UserFollowerId { get; set; }
	public string? UserId { get; set; }
	public string? FollowerId { get; set; }
	public DateTime CreateDate { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public User? User { get; set; }
	public User? Follower { get; set; }

	#endregion
}