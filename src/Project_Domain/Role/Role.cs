using Project_Domain.User;

namespace Project_Domain.Role;

public class Role
{
	public int RoleId { get; set; }
	public string PersianTitle { get; set; }
	public string EnglishTitle { get; set; }
	public string ArabicTitle { get; set; }
	public string SwedishTitle { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public ICollection<UserRole> UserRoles { get; set; }
	public ICollection<RolePermission> RolePermissions { get; set; }

	#endregion
}