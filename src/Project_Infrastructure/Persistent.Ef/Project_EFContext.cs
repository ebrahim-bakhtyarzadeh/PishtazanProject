using Microsoft.EntityFrameworkCore;
using Project_Domain.Blog;
using Project_Domain.Call;
using Project_Domain.User;
using Project_Domain.Wallet;


namespace Project_Infrastructure.Persistent.Ef
{
	public class Project_EFContext:DbContext
     {
          public Project_EFContext(DbContextOptions<Project_EFContext> option) : base(option)
          {
     
          }
          public DbSet<Project_Domain.Blog.Blog> Blogs { get; set; }
          public DbSet<BlogComment> BlogComments { get; set; }
          public DbSet<BlogVisit> BlogVisits { get; set; }
          public DbSet<CallEvent> CallEvents { get; set; }
          public DbSet<CallSession> CallSessions { get; set; }
          public DbSet<Project_Domain.Chat.Chat> Chats{ get; set; }
          public DbSet<Project_Domain.Chat.ChatMessage> ChatMessages{ get; set; }
          public DbSet<Project_Domain.Chat.ChatMessageReaction> ChatMessageReactions{ get; set; }
          public DbSet<Project_Domain.Coin.Coin> Coins{ get; set; }
          public DbSet<Project_Domain.Coin.CoinType> CoinTypes{ get; set; }
          public DbSet<Project_Domain.Group.Group> Groups{ get; set; }
          public DbSet<Project_Domain.Group.GroupMember> GroupMembers{ get; set; }
          public DbSet<Project_Domain.Group.GroupMessage> GroupMessages{ get; set; }
          public DbSet<Project_Domain.Group.GroupMessageReaction> GroupMessageReactions{ get; set; }
          public DbSet<Project_Domain.Group.GroupRole> GroupRoles{ get; set; }
          public DbSet<Project_Domain.Post.Post> Posts{ get; set; }
          public DbSet<Project_Domain.Post.PostComment> PostComments{ get; set; }
          public DbSet<Project_Domain.Post.PostLike> PostLikes{ get; set; }
          public DbSet<Project_Domain.Post.PostVisit> PostVisits{ get; set; }
          public DbSet<Project_Domain.Public.ContactUsMessage> ContactUsMessages { get; set; }
          public DbSet<Project_Domain.Public.Gender>Genders{ get; set; }
          public DbSet<Project_Domain.Public.Reaction> Reactions { get; set; }
          public DbSet<Project_Domain.Public.Setting> Settings { get; set; }
          public DbSet<Project_Domain.Public.Visit> Visits{ get; set; }
          public DbSet<Project_Domain.Role.Permission> Permissions{ get; set; }
          public DbSet<Project_Domain.Role.Role>Roles{ get; set; }
          public DbSet<Project_Domain.Role.RolePermission> RolePermissions { get; set; }
          public DbSet<Project_Domain.Story.Story> Stories { get; set; }
          public DbSet<Project_Domain.Story.StoryComment> StoryComments{ get; set; }
          public DbSet<Project_Domain.Story.StoryLike> StoryLikes{ get; set; }
          public DbSet<Project_Domain.Story.StoryVisit> StoryVisits { get; set; }
          public DbSet<Project_Domain.User.User> Users  { get; set; }
          public DbSet<Project_Domain.User.UserBlock> UserBlocks  { get; set; }
          public DbSet<Project_Domain.User.UserFollower> UserFollowers { get; set; }
          public DbSet<Project_Domain.User.UserLocationHistory> UserLocationHistories { get; set; }
          public DbSet<Project_Domain.User.UserLoginHistory> UserLoginHistories{ get; set; }
          public DbSet<Project_Domain.User.UserNotification> UserNotifications { get; set; }
          public DbSet<Project_Domain.User.UserRole> UserRoles { get; set; }
          public DbSet<Project_Domain.User.UserSavedPost> UserSavedPosts{ get; set; }
          public DbSet<Project_Domain.Wallet.Wallet> Wallets { get; set; }
          public DbSet<Project_Domain.Wallet.WalletType> WalletTypes { get; set; }

          protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
            modelBuilder.Entity<User>().HasMany(user => user.Callers).WithOne(c=>c.Caller).HasForeignKey(c=>c.CallerId);
            modelBuilder.Entity<User>().HasMany(user => user.Receivers).WithOne(c => c.Receiver).HasForeignKey(c => c.ReceiverId);

            modelBuilder.Entity<User>().HasMany(user => user.SenderChats).WithOne(c => c.Sender).HasForeignKey(c => c.SenderId);
            modelBuilder.Entity<User>().HasMany(user => user.ReceiverChats).WithOne(c => c.Receiver).HasForeignKey(c => c.ReceiverId);

            modelBuilder.Entity<User>().HasMany(user => user.BlockedUsers).WithOne(c => c.BlockedUser).HasForeignKey(c => c.BlockedUserId);
            modelBuilder.Entity<User>().HasMany(user => user.UserBlocks).WithOne(c => c.User).HasForeignKey(c => c.UserId);

            modelBuilder.Entity<User>().HasMany(user => user.UserFollowers).WithOne(c => c.User).HasForeignKey(c => c.UserId);
            modelBuilder.Entity<User>().HasMany(user => user.FollowingUsers).WithOne(c => c.Follower).HasForeignKey(c => c.FollowerId);


            modelBuilder.Entity<User>().HasMany(c => c.BlogComments).WithOne(c=>c.User).HasForeignKey(c=>c.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(c => c.Blogs).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(c => c.Visits).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().HasMany(c => c.GroupMessageReactions).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(c => c.GroupMembers).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().HasMany(c => c.PostComments).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(c => c.PostLikes).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(c => c.Posts).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(c => c.PostVisits).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().HasMany(c => c.StoryVisits).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(c => c.Stories).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(c => c.StoryComments).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(c => c.StoryLikes).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().HasMany(c => c.ChatMessages).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User>().HasMany(c => c.ChatMessageReactions).WithOne(c => c.User).HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
         
            base.OnModelCreating(modelBuilder);
          }

          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
               base.OnConfiguring(optionsBuilder);
          }

          




     }
}
