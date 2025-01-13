using System.ComponentModel.DataAnnotations.Schema;

namespace Project_Domain.Call;

public class CallSession
{														  
	public string CallSessionId { get; set; }
	public string? CallerId { get; set; }
	public string? ReceiverId { get; set; }
	public DateTime StartTime { get; set; }
	public DateTime? EndTime { get; set; }
	public bool IsVideo { get; set; }
	public string Status { get; set; } // مثل "Started", "Ended", "Missed"
	public bool IsDelete { get; set; }

	#region Relations

	public ICollection<CallEvent> CallEvents { get; set; }
	[ForeignKey("CallerId")]
	public User.User? Caller { get; set; }
	[ForeignKey("ReceiverId")]
	public User.User? Receiver { get; set; }

	#endregion
}