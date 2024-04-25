
using ModelsInAsp.Models;

namespace ModelsInAsp.Repository
{
    class StudentRepo : IStudent
    {
        public List<StudentModel> GetAllStudents()
        {
            return DataSource();
        }

        public StudentModel GetStudentById(int id)
        {
            return DataSource().Where(x => x.RollNo == id).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {
            var students =new List<StudentModel>
            {
                new StudentModel{RollNo = 1,Name = "Raushan Tiwari", Standard = "MCA", Age = 22},
                new StudentModel{RollNo = 2,Name = "Ujjawal Tiwari", Standard = "B.Com", Age = 23},
                new StudentModel{RollNo = 3,Name = "Abhi Tiwari", Standard = "MCA", Age = 20},
                new StudentModel{RollNo = 4,Name = "Rohan", Standard = "MCA", Age = 22}
            };
            return students;
        }


    }
}