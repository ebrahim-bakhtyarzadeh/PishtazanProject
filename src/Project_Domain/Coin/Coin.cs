namespace Project_Domain.Coin;

public class Coin
{
	public string CoinId { get; set; }
	public int CoinTypeId { get; set; }
	public string UserId { get; set; }
	public int Count { get; set; }
	public DateTime CreateDate { get; set; }
	public string PersianDescription { get; set; }
	public string EnglishDescription { get; set; }
	public string ArabicDescription { get; set; }
	public string SwedishDescription { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public CoinType CoinType { get; set; }
	public User.User User { get; set; }

	#endregion
}