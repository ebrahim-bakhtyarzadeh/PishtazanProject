namespace Project_Domain.User;

public class UserRole
{
	public string UserRoleId { get; set; }
	public string UserId { get; set; }
	public int RoleId { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public User User { get; set; }
	public Role.Role Role { get; set; }

	#endregion
}