using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Domain.Chat;

public class ChatMessage
{
	public string ChatMessageId { get; set; }
	public string? ParentId { get; set; }
	public string ChatId { get; set; }
	public string UserId { get; set; }
	public string? ImageName { get; set; }
	public string? VideoName { get; set; }
	public string? VoiceName { get; set; }
	public string? Text { get; set; }
	public DateTime SentAt { get; set; }
	public bool IsRead { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	[ForeignKey("ParentId")]
	public ICollection<ChatMessage> ChatMessages { get; set; }
	public Chat Chat { get; set; }
	public User.User User { get; set; }

	public ICollection<ChatMessageReaction> ChatMessageReactions { get; set; }

	#endregion
}