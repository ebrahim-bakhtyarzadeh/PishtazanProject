namespace Project_Domain.Group;

public class GroupRole
{
	public int GroupRoleId { get; set; }
	public string PersianTitle { get; set; }
	public string EnglishTitle { get; set; }
	public string ArabicTitle { get; set; }
	public string SwedishTitle { get; set; }
	public string Description { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public ICollection<GroupMember> GroupMembers { get; set; }

	#endregion
}