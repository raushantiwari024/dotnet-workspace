using ModelsInAsp.Models;

namespace ModelsInAsp.Repository
{
    public interface IStudent
    {
        List<StudentModel> GetAllStudents();
        StudentModel GetStudentById(int id);
        
    }
}