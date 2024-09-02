namespace Project_Domain.Wallet;

public class WalletType
{
	public int WalletTypeId { get; set; }
	public string PersianTitle { get; set; }
	public string EnglishTitle { get; set; }
	public string ArabicTitle { get; set; }
	public string SwedishTitle { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public ICollection<Wallet> Wallets { get; set; }

	#endregion
}