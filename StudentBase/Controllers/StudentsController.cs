namespace StudentBase.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IStudentService studentService;

    public StudentsController(IStudentService studentService)
	{
        this.studentService = studentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllStudents()
    {
        var students = await studentService.GetAll();
        return Ok(students);
    }
}
