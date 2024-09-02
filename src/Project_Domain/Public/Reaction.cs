using Project_Domain.Chat;
using Project_Domain.Group;

namespace Project_Domain.Public;

public class Reaction
{
	public string ReactionId { get; set; }
	public string Name { get; set; }
	public string? IconName { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public ICollection<ChatMessageReaction> ChatMessageReactions { get; set; }
	public ICollection<GroupMessageReaction> GroupMessageReactions { get; set; }

	#endregion
}