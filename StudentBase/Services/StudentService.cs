namespace StudentBase.Services;

public class StudentService : IStudentService
{
    private readonly StudentBaseDbContext dbContext;

    public StudentService(StudentBaseDbContext dbContext)
	{
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<Student>> GetAll()
    {
        var students = await dbContext.Students.ToListAsync();
        return students;
    }
}
