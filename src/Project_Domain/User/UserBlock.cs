namespace Project_Domain.User;

public class UserBlock
{
	public string UserBlockId { get; set; }
	public string? UserId { get; set; }
	public string? BlockedUserId { get; set; }
	public DateTime CreateDate { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public User? User { get; set; }
	public User? BlockedUser { get; set; }

	#endregion
}