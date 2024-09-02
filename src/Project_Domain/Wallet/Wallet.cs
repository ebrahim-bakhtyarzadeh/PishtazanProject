using Project_Domain.User;

namespace Project_Domain.Wallet;

public class Wallet
{
	public string WalletId { get; set; }
	public int WalletTypeId { get; set; }
	public string UserId { get; set; }
	public decimal Amount { get; set; }
	public DateTime CreateDate { get; set; }
	public string EnglishDescription { get; set; }
	public string PersianDescription { get; set; }
	public string SwedishDescription { get; set; }
	public string ArabicDescription { get; set; }
	public string? TrackingCode { get; set; }
	public bool IsPay { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public WalletType WalletType { get; set; }
	public User User { get; set; }

	#endregion
}