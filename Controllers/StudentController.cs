using Microsoft.AspNetCore.Mvc;
using VTYSODEV.Models;

namespace VTYSODEV.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult List()
        {
            // Öğrenci ve akademisyen verilerinden oluşan liste
            var students = new List<StudentModel>
            {
                // Prof. Dr. Hamdi Tolga Kahraman (AdvisorID: 1)
                new StudentModel { StudentID = 10001, FirstName = "Ahmet", LastName = "Yılmaz", Email = "ahmet.yilmaz@ogr.ktu.edu.tr", AdvisorID = 1, AdvisorName = "Prof. Dr. Hamdi Tolga Kahraman", EnrollmentDate = "2023-09-01" },
                new StudentModel { StudentID = 10002, FirstName = "Mehmet", LastName = "Kaya", Email = "mehmet.kaya@ogr.ktu.edu.tr", AdvisorID = 1, AdvisorName = "Prof. Dr. Hamdi Tolga Kahraman", EnrollmentDate = "2023-09-01" },

                // Doç. Dr. Hacer Özyurt (AdvisorID: 2)
                new StudentModel { StudentID = 10005, FirstName = "Emre", LastName = "Arslan", Email = "emre.arslan@ogr.ktu.edu.tr", AdvisorID = 2, AdvisorName = "Doç. Dr. Hacer Özyurt", EnrollmentDate = "2023-09-01" },
                new StudentModel { StudentID = 10006, FirstName = "Elif", LastName = "Koç", Email = "elif.koc@ogr.ktu.edu.tr", AdvisorID = 2, AdvisorName = "Doç. Dr. Hacer Özyurt", EnrollmentDate = "2023-09-01" },

                // Dr. Öğr. Üyesi Eyüp Gedikli (AdvisorID: 3)
                new StudentModel { StudentID = 10009, FirstName = "Can", LastName = "Öztürk", Email = "can.ozturk@ogr.ktu.edu.tr", AdvisorID = 3, AdvisorName = "Dr. Öğr. Üyesi Eyüp Gedikli", EnrollmentDate = "2023-09-01" },
                new StudentModel { StudentID = 10010, FirstName = "Merve", LastName = "Aksoy", Email = "merve.aksoy@ogr.ktu.edu.tr", AdvisorID = 3, AdvisorName = "Dr. Öğr. Üyesi Eyüp Gedikli", EnrollmentDate = "2023-09-01" },
            };

            // View'e öğrencileri gönder
            return View(students);
        }
    }
}
