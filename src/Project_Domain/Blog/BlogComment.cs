namespace Project_Domain.Blog;

public class BlogComment
{
	public string BlogCommentId { get; set; }
	public int BlogId { get; set; }
	public string UserId { get; set; }
	public string Text { get; set; }
	public DateTime CommentedDate { get; set; }
	public bool IsActive { get; set; }

	#region Relations

	public Blog Blog { get; set; }
	public User.User User { get; set; }

	#endregion
}