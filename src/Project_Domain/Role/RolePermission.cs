namespace Project_Domain.Role;

public class RolePermission
{
	public int RolePermissionId { get; set; }
	public int RoleId { get; set; }
	public int PermissionId { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public Role Role { get; set; }
	public Permission Permission { get; set; }

	#endregion
}