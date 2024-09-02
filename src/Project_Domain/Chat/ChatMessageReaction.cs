using Project_Domain.Public;

namespace Project_Domain.Chat;

public class ChatMessageReaction
{
	public string ChatMessageReactionId { get; set; }
	public string ChatMessageId { get; set; }
	public string ReactionId { get; set; }
	public string UserId { get; set; }
	public DateTime ReactedAt { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public ChatMessage ChatMessage { get; set; }
	public Reaction Reaction { get; set; }
	public User.User User { get; set; }

	#endregion
}