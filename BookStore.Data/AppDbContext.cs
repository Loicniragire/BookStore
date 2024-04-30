namespace Books.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasKey(b => b.Id);

		modelBuilder.Entity<Book>()
			.HasOne(b => b.Publisher)
			.WithMany(p => p.Books)
			.HasForeignKey(b => b.PublisherId);

		modelBuilder.Entity<Book>()
			.HasOne(b => b.Subject)
			.WithMany(s => s.Books)
			.HasForeignKey(b => b.SubjectId);

        modelBuilder.Entity<Author>()
            .HasKey(a => a.Id);

        modelBuilder.Entity<BookAuthor>()
            .HasKey(ba => new { ba.BookId, ba.AuthorId });

        modelBuilder.Entity<Subject>()
            .HasKey(s => s.Id);

		modelBuilder.Entity<Subject>()
			.HasMany(s => s.Books)
			.WithOne(b => b.Subject)
			.HasForeignKey(b => b.SubjectId);

        modelBuilder.Entity<Publisher>()
            .HasKey(p => p.Id);

        modelBuilder.Entity<Review>()
			.HasOne(r => r.Book)
			.WithMany(b => b.Reviews)
			.HasForeignKey(r => r.BookId);

		modelBuilder.Entity<Review>()
			.HasOne(r => r.User)
			.WithMany(u => u.Reviews)
			.HasForeignKey(r => r.UserId);

		modelBuilder.Entity<Review>()
			.HasKey(r => r.Id);

        modelBuilder.Entity<User>()
            .HasKey(u => u.Id);

		modelBuilder.Entity<User>()
			.HasMany(u => u.Reviews)
			.WithOne(r => r.User)
			.HasForeignKey(r => r.UserId);



    }
}

