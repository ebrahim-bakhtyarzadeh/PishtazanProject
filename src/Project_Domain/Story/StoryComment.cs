using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Domain.Story;

public class StoryComment
{
	public string StoryCommentId { get; set; }
	public string? ParentId { get; set; }
	public string StoryId { get; set; }
	public string UserId { get; set; }
	public string CommentText { get; set; }
	public DateTime CreatedAt { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	[ForeignKey("ParentId")]
	public ICollection<StoryComment> StoryComments { get; set; }
	public Story Story { get; set; }
	public User.User User { get; set; }

	#endregion
}