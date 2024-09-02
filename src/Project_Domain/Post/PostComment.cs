using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Domain.Post;

public class PostComment
{
	public string PostCommentId { get; set; }
	public string? ParentId { get; set; }
	public string PostId { get; set; }
	public string UserId { get; set; }
	public string CommentText { get; set; }
	public DateTime CreatedAt { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	[ForeignKey("ParentId")]
	public ICollection<PostComment> PostComments { get; set; }
	public Post Post { get; set; }
	public User.User User { get; set; }

	#endregion
}