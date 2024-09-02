using Project_Domain.Post;

namespace Project_Domain.User;

public class UserSavedPost
{
	public string UserSavedPostId { get; set; }
	public string UserId { get; set; }
	public string PostId { get; set; }
	public DateTime CreateDate { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public User User { get; set; }
	public Post Post { get; set; }

	#endregion
}