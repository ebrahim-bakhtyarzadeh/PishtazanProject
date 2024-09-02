using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Domain.Role;

public class Permission
{
	public int PermissionId { get; set; }
	public int? ParentId { get; set; }
	public string Title { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	[ForeignKey("ParentId")]
	public ICollection<Permission> Permissions { get; set; }
	public ICollection<RolePermission> RolePermissions { get; set; }

	#endregion
}