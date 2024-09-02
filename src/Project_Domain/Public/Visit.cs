namespace Project_Domain.Public;

public class Visit
{
	public string VisitId { get; set; }
	public string UserId { get; set; }
	public string? UserIp { get; set; }
	public string? Brand { get; set; }
	public string? DeviceName { get; set; }
	public string? DeviceYearClass { get; set; }
	public string? ModelName { get; set; }
	public string? OsBuildFingerprint { get; set; }
	public string? OsBuildId { get; set; }
	public int Count { get; set; }
	public DateTime FirstVisitedAt { get; set; }
	public DateTime LastVisitedAt { get; set; }

	#region Relations

	public User.User User { get; set; }

	#endregion
}