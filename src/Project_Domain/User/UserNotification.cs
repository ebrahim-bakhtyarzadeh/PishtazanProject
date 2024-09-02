namespace Project_Domain.User;

public class UserNotification
{
	public string UserNotificationId { get; set; }
	public string UserId { get; set; }
	public string PersianTitle { get; set; }
	public string EnglishTitle { get; set; }
	public string ArabicTitle { get; set; }
	public string SwedishTitle { get; set; }
	public string PersianText { get; set; }
	public string EnglishText { get; set; }
	public string ArabicText { get; set; }
	public string SwedishText { get; set; }
	public DateTime CreateDate { get; set; }
	public bool IsRead { get; set; }
	public bool IsSendWithPush { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public User User { get; set; }

	#endregion
}