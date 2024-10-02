using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project_Infrastructure.Persistent.Ef.Blog
{
	internal class BlogConfiguration : IEntityTypeConfiguration<Project_Domain.Blog.Blog>
	{
		public void Configure(EntityTypeBuilder<Project_Domain.Blog.Blog> builder)
		{
			builder.ToTable("Blogs", "dbo");
			builder.HasKey(b => b.BlogId);

			//config titles
			builder.Property(x => x.ArabicTitle)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(x => x.PersianTitle)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(x => x.SwedishTitle)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(x => x.EnglishTitle)
				.IsRequired()
				.HasMaxLength(200);


			// config Descriptions 
			builder.Property(x => x.ArabicDescription)
				.IsRequired()
				.HasMaxLength(700);
			builder.Property(x => x.PersianDescription)
				.IsRequired()
				.HasMaxLength(700);
			builder.Property(x => x.SwedishDescription)
				.IsRequired()
				.HasMaxLength(700);
			builder.Property(x => x.EnglishDescription)
				.IsRequired()
				.HasMaxLength(700);


			// config full texts
			builder.Property(x => x.ArabicFullText)
				.IsRequired()
				.HasMaxLength(5000);
			builder.Property(x => x.PersianFullText)
				.IsRequired()
				.HasMaxLength(5000);
			builder.Property(x => x.SwedishFullText)
				.IsRequired()
				.HasMaxLength(5000);
			builder.Property(x => x.EnglishFullText)
				.IsRequired()
				.HasMaxLength(5000);

			builder.Property(c => c.CreateDate)
				.HasDefaultValue(DateTime.Now);
			builder.Property(c => c.IsActive)
				.HasDefaultValue();



			builder.OwnsMany(b => b.BlogComments, config =>
			{
				config.HasKey(c => c.BlogCommentId);
				config.Property(c => c.Text)
					.IsRequired()
					.HasMaxLength(1000);

				config.Property(c => c.CommentedDate)
					.IsRequired()
					.HasDefaultValue(DateTime.Now);
				config.Property(c => c.IsActive)
					.HasDefaultValue(true);
				config.OwnsOne(c => c.Blog);
				config.OwnsOne(c => c.User);
			});
			

		}
	}
}
