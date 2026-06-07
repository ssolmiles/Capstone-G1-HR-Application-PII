using System;

namespace HRApplicantSystem.Models
{
    public class JobVacancy
    {
        public int JobVacancyID { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
        public int EmploymentTypeID { get; set; }

        public string JobTitle { get; set; }
        public string Description { get; set; }
        public string Qualifications { get; set; }
        public string RequiredDocuments { get; set; }   // comma-separated or JSON

        // Status: Open, Closed
        public string Status { get; set; }
        public bool IsOpen => Status == "Open";

        public DateTime PostedAt { get; set; }
        public DateTime? ClosedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Joined / display fields
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public string EmploymentTypeName { get; set; }
    }

    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
