using System;

namespace HRApplicantSystem.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        // Role: Applicant, HR Staff, HR Manager, Admin
        public string Role { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Helper
        public bool IsHR => Role == "HR Staff" || Role == "HR Manager" || Role == "Admin";
        public bool IsAdmin => Role == "Admin";
        public bool CanMakeFinalDecision => Role == "Admin" || Role == "HR Manager";
    }

    public class StatusHistory
    {
        public int HistoryID { get; set; }
        public int ApplicationID { get; set; }
        public int ChangedByUserID { get; set; }

        public string PreviousStatus { get; set; }
        public string NewStatus { get; set; }
        public string Remarks { get; set; }

        public DateTime ChangedAt { get; set; }

        // Joined / display fields
        public string ChangedByName { get; set; }
    }

    public class AuditLog
    {
        public int LogID { get; set; }
        public int UserID { get; set; }

        public string Action { get; set; }          // e.g. "Submitted Application"
        public string TableAffected { get; set; }   // e.g. "Applications"
        public int? RecordID { get; set; }          // ID of the affected record
        public string Details { get; set; }         // extra info / JSON snapshot

        public DateTime LoggedAt { get; set; }

        // Joined / display fields
        public string UserEmail { get; set; }
        public string UserRole { get; set; }
    }
}

