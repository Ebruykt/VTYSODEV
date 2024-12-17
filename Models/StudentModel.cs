using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VTYSODEV.Models
{
    public class StudentModel
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public int Password { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int AdvisorID { get; set; }
        public string AdvisorName { get; set; } // Danışmanın adı
        public string EnrollmentDate { get; set; } // Kayıt Tarihi
    }
}