using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Domain.Group;

public class GroupMessage
{
	public string GroupMessageId { get; set; }
	public string? ParentId { get; set; }
	public string GroupId { get; set; }
	public string UserId { get; set; }
	public string? ImageName { get; set; }
	public string? VideoName { get; set; }
	public string? VoiceName { get; set; }
	public string? Text { get; set; }
	public DateTime SentAt { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	[ForeignKey("ParentId")]
	public ICollection<GroupMessage> GroupMessages { get; set; }
	public Group Group { get; set; }
	public User.User User { get; set; }
	public ICollection<GroupMessageReaction> GroupMessageReactions { get; set; }

	#endregion
}