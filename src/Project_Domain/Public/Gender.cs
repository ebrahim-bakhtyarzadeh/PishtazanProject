namespace Project_Domain.Public;

public class Gender
{
	public int GenderId { get; set; }
	public string PersianTitle { get; set; }
	public string EnglishTitle { get; set; }
	public string ArabicTitle { get; set; }
	public string SwedishTitle { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public ICollection<User.User> Users { get; set; }

	#endregion
}