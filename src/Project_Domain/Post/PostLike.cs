namespace Project_Domain.Post;

public class PostLike
{
	public string PostLikeId { get; set; }
	public string PostId { get; set; }
	public string UserId { get; set; }
	public DateTime LikedAt { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public Post Post { get; set; }
	public User.User User { get; set; }

	#endregion
}