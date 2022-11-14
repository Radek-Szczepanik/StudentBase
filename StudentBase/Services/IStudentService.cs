namespace StudentBase.Services;

public interface IStudentService
{
    Task<IEnumerable<Student>> GetAll();
}
