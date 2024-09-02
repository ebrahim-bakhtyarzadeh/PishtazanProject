namespace Project_Domain.Group;

public class Group
{
	public string GroupId { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string AvatarName { get; set; }
	public DateTime CreatedAt { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public ICollection<GroupMember> GroupMembers { get; set; }
	public ICollection<GroupMessage> GroupMessages { get; set; }

	#endregion
}