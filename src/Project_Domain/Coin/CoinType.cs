namespace Project_Domain.Coin;

public class CoinType
{
	public int CoinTypeId { get; set; }
	public string PersianTitle { get; set; }
	public string EnglishTitle { get; set; }
	public string ArabicTitle { get; set; }
	public string SwedishTitle { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public List<Coin> Coins { get; set; }

	#endregion
}