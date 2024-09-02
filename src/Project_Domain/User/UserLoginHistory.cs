namespace Project_Domain.User;

public class UserLoginHistory
{
	public string UserLoginHistoryId { get; set; }
	public string UserId { get; set; }
	public string? UserIp { get; set; }
	public string? Brand { get; set; }
	public string? DeviceName { get; set; }
	public string? DeviceYearClass { get; set; }
	public string? ModelName { get; set; }
	public string? OsBuildFingerprint { get; set; }
	public string? OsBuildId { get; set; }
	public DateTime CreateDate { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public User User { get; set; }

	#endregion
}