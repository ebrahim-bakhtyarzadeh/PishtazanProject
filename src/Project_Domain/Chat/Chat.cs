namespace Project_Domain.Chat;

public class Chat
{
	public string ChatId { get; set; }
	public string? SenderId { get; set; }
	public string? ReceiverId { get; set; }
	public string? LastMessage { get; set; }
	public DateTime CreatedAt { get; set; }
	public DateTime UpdatedAt { get; set; }
	public bool SenderIsTyping { get; set; }
	public bool ReceiverIsTyping { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public User.User? Sender { get; set; }
	public User.User? Receiver { get; set; }
	public ICollection<ChatMessage> ChatMessages { get; set; }

	#endregion
}