using Project_Domain.User;

namespace Project_Domain.Post;

public class Post
{
	public string PostId { get; set; }
	public string UserId { get; set; }
	public string? ImageName { get; set; }
	public string? VideoName { get; set; }
	public string? Caption { get; set; }
	public DateTime CreatedAt { get; set; }
	public DateTime? UpdatedAt { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public User.User User { get; set; }
	public ICollection<PostComment> PostComments { get; set; }
	public ICollection<PostLike> PostLikes { get; set; }
	public ICollection<PostVisit> PostVisits { get; set; }
	public ICollection<UserSavedPost> UserSavedPosts { get; set; }

	#endregion
}