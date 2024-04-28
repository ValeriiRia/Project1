using Students.Common.Models;

namespace Students.Interfaces;

public interface IDatabaseService
{

    #region Subject

    Task<List<Subject>> GetOllSubjectsAsync();

    Task<Subject?> GetSubjectAsync(int? id);

    Task<Subject?> GetSubjectWithStudentsAsync(int? id);

    Task CreateSubjectAsync(Subject subject, int[] subjectIdDst);

    Task UpdateSubjectAsync(Subject subject, int[] subjectIdDst);

    Task DeleteSubjectAsync(int id);

    bool SubjectExists(int id);

    List<Subject> GetChosenSubjects(int? id);

    List<Subject> GetAvailableSubjects(int? id);

    List<StudentSubject> GetStudentSubjects(int? id);


    #endregion

    #region Lecture Hall 

    Task<LectureHall?> GetLectureHallAsync(int? Id);

    Task<IList<LectureHall>> GetOllLectureHallAsync();

    Task<LectureHall?> GetLectureHallWithSubjectsAsync(int? id);
    Task<LectureHall> CreateLectureHallAsync(int id, string name, int capacity, int[] subjectIdDst);

    Task UpdateLectureHallAsync(LectureHall lectureHall, int[] subjectIdDst);

    Task DeleteLectureHall(int id);

    bool LectureHallExists(int id);

    #endregion

    #region Book
    Task<Book?> GetBookAsync(int? Id);

    Task<IList<Book>> GetOllBookAsync();

    Task CreateBookAsync(Book lectureHall);

    Task UpdateBookAsync(Book lectureHall);

    Task DeleteBookAsync(int id);

    bool BookExists(int id);

    #endregion

    #region Student

    Student? DisplayStudent(int? id);

    Task<IList<Student>> GetOllStudentsAsync();

    Task<Student?> GetStudentAsync(int? id);

    Task<Student?> GetStudentWithSubjectsAsync(int? id);

    Task<bool> CreateStudentAsync(int id, string name, int age, string major, int[] subjectIdDst);

    Task<bool> DeleteStudentAsync(int? id);

    bool EditStudent(int id, string name, int age, string major, int[] subjectIdDst);

    bool StudentExists(int id);

    #endregion

    #region Lecturer

    Task<List<Lecturer>> GetOllLecturersAsync();

    Task<Lecturer?> GetLecturerAsync(int? id);

    Task<Lecturer?> GetLecturerWithSubjectsAsync(int? id);

    Task <Lecturer> CreateLecturerAsync(Lecturer subject, int[] subjectIdDst);

    Task UpdateLecturerAsync(Lecturer subject, int[] subjectIdDst);

    Task<bool> DeleteLecturerAsync(int id);

    bool LecturerExists(int id);


    #endregion
}
