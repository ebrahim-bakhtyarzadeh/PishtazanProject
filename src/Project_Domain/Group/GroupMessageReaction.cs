using Project_Domain.Public;

namespace Project_Domain.Group;

public class GroupMessageReaction
{
	public string GroupMessageReactionId { get; set; }
	public string GroupMessageId { get; set; }
	public string ReactionId { get; set; }
	public string UserId { get; set; }
	public DateTime ReactedAt { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public GroupMessage GroupMessage { get; set; }
	public Reaction Reaction { get; set; }
	public User.User User { get; set; }

	#endregion
}