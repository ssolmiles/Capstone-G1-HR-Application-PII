using System;

namespace HRApplicantSystem.Models
{
    public class Applicant
    {
        public int ApplicantID { get; set; }
        public int UserID { get; set; }

        // Personal Info
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public string Nationality { get; set; }

        // Address
        public string Street { get; set; }
        public string Barangay { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string ZipCode { get; set; }

        // Contact
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Education (most recent)
        public string SchoolName { get; set; }
        public string Degree { get; set; }
        public string FieldOfStudy { get; set; }
        public int? GraduationYear { get; set; }

        // Skills & Work Experience (stored as text or JSON string)
        public string Skills { get; set; }
        public string WorkExperience { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Computed / display helper
        public string FullName => $"{FirstName} {MiddleName} {LastName}".Replace("  ", " ").Trim();
    }

    public class Application
    {
        public int ApplicationID { get; set; }
        public int ApplicantID { get; set; }
        public int JobVacancyID { get; set; }

        // Status: Draft, Submitted, Under Review, Screened, Interview Scheduled,
        //         Interview Done, Passed, Failed, Hired, Rejected
        public string Status { get; set; }

        public bool IsDraft { get; set; }
        public bool IsLocked { get; set; }         // locked by HR for review

        public DateTime? SubmittedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Joined / display fields (populated by queries, not stored in DB)
        public string JobTitle { get; set; }
        public string DepartmentName { get; set; }
        public string ApplicantFullName { get; set; }
    }

    public class ApplicantDocument
    {
        public int DocumentID { get; set; }
        public int ApplicantID { get; set; }

        // Type: Resume, ID, Transcript, Certificate, Other
        public string DocumentType { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }        // Azure Blob URL or local path
        public string Remarks { get; set; }

        // Status: Submitted, Missing, Rejected
        public string Status { get; set; }

        public DateTime UploadedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
