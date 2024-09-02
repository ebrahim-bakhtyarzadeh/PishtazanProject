namespace Project_Domain.Blog;

public class Blog
{
	public int BlogId { get; set; }
	public string UserId { get; set; }
	public string PersianTitle { get; set; }
	public string EnglishTitle { get; set; }
	public string ArabicTitle { get; set; }
	public string SwedishTitle { get; set; }
	public string PersianDescription { get; set; }
	public string EnglishDescription { get; set; }
	public string ArabicDescription { get; set; }
	public string SwedishDescription { get; set; }
	public string PersianKeywords { get; set; }
	public string EnglishKeywords { get; set; }
	public string ArabicKeywords { get; set; }
	public string SwedishKeywords { get; set; }
	public string PersianFullText { get; set; }
	public string EnglishFullText { get; set; }
	public string ArabicFullText { get; set; }
	public string SwedishFullText { get; set; }
	public string ImageName { get; set; }
	public DateTime CreateDate { get; set; }
	public bool IsActive { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public User.User User { get; set; }
	public ICollection<BlogComment> BlogComments { get; set; }
	public ICollection<BlogVisit> BlogVisits { get; set; }

	#endregion
}