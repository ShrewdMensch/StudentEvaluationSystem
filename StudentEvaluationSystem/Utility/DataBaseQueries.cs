using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentEvaluationSystem.Data;
using StudentEvaluationSystem.Models;
using StudentEvaluationSystem.Models.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEvaluationSystem.Utility
{
    public class DataBaseQueries
    {
        private readonly ApplicationDbContext _context;

        public DataBaseQueries(ApplicationDbContext context)
        {
            _context = context;
        }


        /*****
         *** Subjects Queries
         *****/
         public IEnumerable<Subject> GetSubjectsByTeacherId(int id)
        {
            var subjects = _context.Subjects
                .Include(s=>s.SubjectType)
                .Include(s=>s.Teacher)
                .Where(s=>s.TeacherId == id);

            return subjects;
        }

        public Subject GetSubject(int subjectId)
        {
            return _context.Subjects.Find(subjectId);
        }

        /*****
         *** Teacher Queries
         *****/
        public Teacher GetTeacher(string id)
        {
            var teacher = _context.Teachers
                .Find(id);

            return teacher;
        }
        public Teacher GetTeacherByUserId(string id)
        {
            var teachers = _context.Teachers
                .SingleOrDefault(t=>t.UserId == id);

            return teachers;
        }

        /*****
         *** Classes Table Queries
         *****/
        public Class GetClass(int classId)
        {
            var academicClass = _context.Classes.Find(classId);
            return academicClass;
        }

        public List<Class> GetTeacherClass(int teacherId)
        {
            var academicClasses = (from myclass in _context.Classes
                                 join teacher in _context.ClassTeachers
                                 on myclass.Id equals teacher.ClassId
                                 where teacher.Id == teacherId
                                 select myclass)
                                 .Include(c=>c.Category)
                                 .ToList();

            return academicClasses;
        }
        public List<Class> GetAllClasses()
        {
            var academicClass = _context.Classes
                .Include(c=>c.Category)
                .ToList();
            return academicClass;
        }
        public List<ClassDropDownItem> GetAvailableClasses()
        {
            return _context.Classes
                .Include(c=>c.Category)
                .Select(c => new ClassDropDownItem()
            {
                Name = c.Name + " - " + c.Category.Name,
                Id = c.Id
            }).ToList();
        }

        public List<Class> GetClassesOfferingSubject(int subjectId)
        {
            var subjectTypeId = _context.Subjects.Find(subjectId)?.SubjectTypeId;

            var classessOfferingSubject = _context.Classes
                .Where(c => c.CategoryId == subjectTypeId)
                .Include(c=>c.Category)
                .ToList();

            if(subjectTypeId == Constant.SeniorClass_FK)
            {
                classessOfferingSubject = (from c in _context.Classes
                                           where c.CategoryId != Constant.JuniorClass_FK
                                           orderby c.Name select c)
                                           .Include(c => c.Category)
                                           .ToList();
            }

            return classessOfferingSubject;
        }
        
        /*****
         *** Session/Terms Table Queries
         *****/
         public bool IsCurrentSessionTermSet()
        {
            return _context.SessionTerms.Any(s => s.IsCurrent == true);
        }

        public SessionTerm GetCurrentSessionTerm()
        {
            return _context.SessionTerms.Single(s => s.IsCurrent == true);
        }

         public SessionTerm GetSessionTerm(int sessionTermId)
        {
            return _context.SessionTerms
                .Include(s=>s.Session)
                .Include(s=>s.Term)
                .Single(s => s.Id == sessionTermId);
        }

         public List<SelectListItem> GetSessionTermBySessionId(int sessionId)
        {
            var sessionTerms = _context.SessionTerms
                .Include(c=>c.Term)
                .Where(s => s.SessionId == sessionId)
                .Select(c=> new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Term.Name.ToString()
                })
                .ToList();

            return sessionTerms;
        }

        public Session GetSessionBySessionTermId(int sessionTermId)
        {
            return GetSessionTerm(sessionTermId).Session;
        }

        public Term GetTermBySessionTermId(int sessionTermId)
        {
            return GetSessionTerm(sessionTermId).Term;
        }

        public List<SessionTerm> GetAllSessionTerms()
        {
            return _context.SessionTerms
                .Include(s=>s.Session)
                .Include(s=>s.Term)
                .ToList();
        }
        public List<Session> GetAllSessions()
        {
            return _context.Sessions
                .ToList();
        }
        
        /*****
         *** Students Table Queries
         *****/
         public List<Student> GetStudentsCurrentlyInClass(int classId)
        {
            var students = _context.Students.Where(s => s.CurrentClassId == classId
                                             && s.Graduated == false)
                                            .Include(s=>s.CurrentClass)
                                            .Include(s=>s.ClassOfEntry)
                                            .ToList();

            return students;
        }

        public List<Student> GetAllCurrentStudents()
        {
            var students = _context.Students.Where(s=>s.Graduated == false)
                                            .Include(s=>s.CurrentClass)
                                            .Include(s=>s.ClassOfEntry)
                                            .ToList();

            return students;
        }
        public List<Student> GetAllGraduatedStudents()
        {
            var students = _context.Students.Where(s=>s.Graduated == true)
                                            .Include(s=>s.CurrentClass)
                                            .Include(s=>s.ClassOfEntry)
                                            .ToList();

            return students;
        }

        public List<Student> GetAllStudentsInClass(int classId)
        {
            var students = _context.Students
                                            .Where(s=>s.CurrentClassId == classId
                                            && s.Graduated == false)
                                            .Include(s=>s.CurrentClass)
                                            .Include(s=>s.ClassOfEntry)
                                            .ToList();

            return students;
        }
        public List<Student> GetAllNonPromotedStudentsInClass(int classId)
        {
            var students = _context.Students
                                            .Where(s=>s.CurrentClassId == classId
                                            && s.Promoted == false
                                            && s.Graduated == false)
                                            .Include(s=>s.CurrentClass)
                                            .Include(s=>s.ClassOfEntry)
                                            .ToList();

            return students;
        }

         public List<Student> GetStudentsWithResultByClassBySessionTerm(int classId, int sessionTermId)
        {
            var students =(from student in GetAllCurrentStudents()
                           join result in _context.Results
                           on student.Id equals result.StudentId
                           where result.SessionTermId == sessionTermId 
                           && result.ClassId == classId
                           select student)
                           .Distinct()
                           .ToList();

            return students;
        }


        public List<Student> GetStudentsCurrentlyInClassWithoutSubjectResultUploadedForSessionTerm
            (int classId, int subjectId, int sessionTermId)
        {
            var students = GetStudentsCurrentlyInClass(classId)
                           .Except(GetStudentsWithSubjectResultUploadedForSessionTerm
                           (subjectId, sessionTermId))
                           .ToList();

            return students;
        }


         public List<Student> GetStudentsWithSubjectResultUploadedForSessionTerm
            (int subjectId, int sessionTermId)
        {
            var students = (from student in GetAllCurrentStudents()
                            join result in _context.Results
                            on student.Id equals result.StudentId
                            where result.SessionTermId == sessionTermId && 
                            result.SubjectId == subjectId
                            select student
                            )
                            .ToList();

            return students;
        }

        public bool DoesStudentExist(int studentId)
        {
            return _context.Students.Any(s => s.Id == studentId);
        }

        public Student GetStudent(int studentId)
        {
            var student = _context.Students
                .Include(c=>c.CurrentClass)
                .Include(c=>c.ClassOfEntry)
                .Single(c=>c.Id==studentId);
            return student;
        }

        public Student GetStudentByUserId(string id)
        {
            var students = _context.Students
                .SingleOrDefault(t => t.UserId == id);

            return students;
        }


        /*****
         *** Results Table Queries
         *****/

        public async Task AddResultToDataBase(Result result)
        {
           await _context.Results.AddAsync(result);

            await _context.SaveChangesAsync();
        }

        public List<Result> GetResultsWithStudentByClassBySessionTerm(int studentId, int classId, int sessionTermId)
        {
            var results =  (from result in _context.Results
                            where result.SessionTermId == sessionTermId
                            && result.StudentId == studentId
                            && result.ClassId == classId
                            select result
                            )
                .Include(r => r.Student)
                .Include(r => r.Subject)
                .Include(r => r.Class)
                .Include(r => r.SessionTerm)
                .Include(r => r.SessionTerm.Term)
                .Include(r => r.SessionTerm.Session)
                .ToList();

            return results;
        }
        public List<Result> GetStudentResultsByClassBySessionTerm(int studentId, int classId, int sessionTermId)
        {
            var results =  (from result in _context.Results
                            where result.SessionTermId == sessionTermId
                            && result.StudentId == studentId
                            && result.ClassId == classId
                            select result
                            )
                .ToList();

            return results;
        }

        public List<Result> GetResultsByStudentIdBySessionTermId(int studentId,int sessionTermId)
        {
            var results =(from result in _context.Results
                          where result.SessionTermId == sessionTermId 
                          && result.StudentId == studentId
                          select result
                            )
                .Include(r => r.Student)
                .Include(r => r.Subject)
                .Include(r => r.Class)
                .Include(r => r.SessionTerm)
                .Include(r => r.SessionTerm.Term)
                .Include(r => r.SessionTerm.Session)
                .ToList();

            return results;
        }
        public IEnumerable<IGrouping<int,Result>> GetResultsByStudentIdBySessionId(int studentId,int sessionId)
        {
            var results = 
                (from result in _context.Results
                 join term in _context.SessionTerms
                 on result.SessionTermId equals term.Id
                           where term.SessionId == sessionId
                           && result.StudentId == studentId
                           select result
                           )
               .Include(r => r.Student)
               .Include(r => r.Subject)
               .Include(r => r.Class)
               .Include(r => r.SessionTerm)
               .Include(r => r.SessionTerm.Term)
               .Include(r => r.SessionTerm.Session)
               .ToList()
               .GroupBy(r=>r.SessionTermId);


            return results;
        }




    }
}
