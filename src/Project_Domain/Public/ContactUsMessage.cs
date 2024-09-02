namespace Project_Domain.Public;

public class ContactUsMessage
{
	public string ContactUsMessageId { get; set; }
	public string FullName { get; set; }
	public string? Email { get; set; }
	public string? PhoneNumber { get; set; }
	public string Subject { get; set; }
	public string Message { get; set; }
	public DateTime SentDate { get; set; }
	public bool IsRead { get; set; }
	public bool IsDelete { get; set; }
}