using System;

namespace HRApplicantSystem.Models
{
    public class Applicant
    {
        public int ApplicantID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string ZipCode { get; set; }
        public string School { get; set; }
        public string Degree { get; set; }
        public string YearGrad { get; set; }
        public string Skills { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Duration { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
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
