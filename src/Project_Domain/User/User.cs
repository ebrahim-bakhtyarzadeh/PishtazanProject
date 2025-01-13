using Project_Domain.Blog;
using Project_Domain.Call;
using Project_Domain.Chat;
using Project_Domain.Group;
using Project_Domain.Post;
using Project_Domain.Public;
using Project_Domain.Story;

namespace Project_Domain.User;

public class User
{
	public string UserId { get; set; }
	public string IdentificationCode { get; set; }
	public string InvitationCode { get; set; }
	public string Mobile { get; set; }
	public string Password { get; set; }
	public string? Email { get; set; }
	public string? FirstName { get; set; }
	public string? LastName { get; set; }
	public string? UserName { get; set; }
	public string AvatarName { get; set; }
	public string? Bio { get; set; }
	public string? Country { get; set; }
	public string? City { get; set; }
	public string? MaritalStatus { get; set; }
	public string? EducationLevel { get; set; }
	public string? Job { get; set; }
	public string? Religion { get; set; }
	public string? Languages { get; set; }
	public string? Hobbies { get; set; }
	public string? FavoriteSports { get; set; }
	public string? FavoriteMusic { get; set; }
	public string? FavoriteBooks { get; set; }
	public string? FavoriteMovies { get; set; }
	public string? FavoriteTvShows { get; set; }
	public string? RelationshipType { get; set; }
	public string? Interests { get; set; }
	public string? FacebookProfile { get; set; }
	public string? TwitterProfile { get; set; }
	public string? InstagramProfile { get; set; }
	public string? SelfieImageVerification { get; set; }
	public string? ExpoPushTokenNotification { get; set; }
	public int GenderId { get; set; }
	public int? HeightCm { get; set; }
	public int? WeightKg { get; set; }
	public int ConfirmationCode { get; set; }
	public double Latitude { get; set; }
	public double Longitude { get; set; }
	public DateTime DateOfBirth { get; set; }
	public DateTime RegisterDate { get; set; }
	public DateTime LastActiveDate { get; set; }
	public DateTime ExpirePinDate { get; set; }
	public bool IsSmoker { get; set; }
	public bool IsDrinker { get; set; }
	public bool WantsChildren { get; set; }
	public bool ShowDistance { get; set; }
	public bool IsOnline { get; set; }
	public bool EnablePushNotifications { get; set; }
	public bool HaveBlueTick { get; set; }
	public bool IsDelete { get; set; }

	#region Relations

	public Gender Gender { get; set; }					
	public ICollection<UserBlock>? UserBlocks { get; set; }
	public ICollection<UserBlock>? BlockedUsers { get; set; }
	public ICollection<UserFollower>? UserFollowers { get; set; }
	public ICollection<UserFollower>? FollowingUsers { get; set; }
	public ICollection<UserLocationHistory> UserLocationHistories { get; set; }
	public ICollection<UserLoginHistory> UserLoginHistories { get; set; }
	public ICollection<UserNotification> UserNotifications { get; set; }
	public ICollection<UserRole> UserRoles { get; set; }
	public ICollection<UserSavedPost> UserSavedPosts { get; set; }
	public ICollection<Wallet.Wallet> Wallets { get; set; }
	public ICollection<Story.Story> Stories { get; set; }
	public ICollection<StoryComment> StoryComments { get; set; }
	public ICollection<StoryLike> StoryLikes { get; set; }
	public ICollection<StoryVisit> StoryVisits { get; set; }
	public ICollection<Visit> Visits { get; set; }
	public ICollection<Post.Post> Posts { get; set; }
	public ICollection<PostComment> PostComments { get; set; }
	public ICollection<PostLike> PostLikes { get; set; }
	public ICollection<PostVisit> PostVisits { get; set; }
	public ICollection<GroupMember> GroupMembers { get; set; }
	public ICollection<GroupMessage> GroupMessages { get; set; }
	public ICollection<GroupMessageReaction> GroupMessageReactions { get; set; }
	public ICollection<Coin.Coin> Coins { get; set; }
	public ICollection<Chat.Chat>? SenderChats { get; set; }
	public ICollection<Chat.Chat>? ReceiverChats { get; set; }
	public ICollection<ChatMessage> ChatMessages { get; set; }
	public ICollection<ChatMessageReaction> ChatMessageReactions { get; set; }
	public ICollection<BlogComment> BlogComments { get; set; }
	public ICollection<BlogVisit> BlogVisits { get; set; }
	public ICollection<Blog.Blog> Blogs { get; set; }
	public ICollection<CallSession>? Callers { get; set; }
	public ICollection<CallSession>? Receivers { get; set; }
	public ICollection<CallEvent> CallEvents { get; set; }

	#endregion
}