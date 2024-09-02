namespace Project_Domain.Group;

public class GroupMember
{
	public string GroupMemberId { get; set; }
	public string GroupId { get; set; }
	public string UserId { get; set; }
	public int GroupRoleId { get; set; }
	public DateTime JoinedAt { get; set; }
	public bool IsAccept { get; set; }
	public bool Mute { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public Group Group { get; set; }
	public User.User User { get; set; }
	public GroupRole GroupRole { get; set; }

	#endregion
}