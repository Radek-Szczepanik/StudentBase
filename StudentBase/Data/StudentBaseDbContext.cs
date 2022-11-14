namespace StudentBase.Data;

public class StudentBaseDbContext : DbContext
{
	public StudentBaseDbContext(DbContextOptions<StudentBaseDbContext> options) : base(options)
	{
	}

    public DbSet<Student> Students { get; set; }
}
