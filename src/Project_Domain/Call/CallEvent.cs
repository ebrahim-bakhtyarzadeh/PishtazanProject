namespace Project_Domain.Call;

public class CallEvent
{
	public string CallEventId { get; set; }
	public string CallSessionId { get; set; }
	public string UserId { get; set; }
	public string EventType { get; set; } // مثل "Ring", "Answer", "End"
	public DateTime EventTime { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public CallSession CallSession { get; set; }
	public User.User User { get; set; }

	#endregion
}