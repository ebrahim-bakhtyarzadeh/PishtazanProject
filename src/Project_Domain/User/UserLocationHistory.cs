namespace Project_Domain.User;

public class UserLocationHistory
{
	public string UserLocationHistoryId { get; set; }
	public string UserId { get; set; }
	public double Latitude { get; set; }
	public double Longitude { get; set; }
	public DateTime CreateDate { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public User User { get; set; }

	#endregion
}