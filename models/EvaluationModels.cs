using System;

namespace HRApplicantSystem.Models
{
    public class ScreeningResult
    {
        public int ScreeningID { get; set; }
        public int ApplicationID { get; set; }
        public int ReviewedByUserID { get; set; }

        // Result: Qualified, Not Qualified
        public string Result { get; set; }
        public string Remarks { get; set; }

        public DateTime ScreenedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Joined / display fields
        public string ApplicantFullName { get; set; }
        public string JobTitle { get; set; }
        public string ReviewedByName { get; set; }
    }

    public class InterviewSchedule
    {
        public int ScheduleID { get; set; }
        public int ApplicationID { get; set; }
        public int AssignedInterviewerUserID { get; set; }
        public int InterviewTypeID { get; set; }

        public DateTime InterviewDate { get; set; }
        public TimeSpan InterviewTime { get; set; }

        // Mode: Online, On-site
        public string Mode { get; set; }
        public string Location { get; set; }        // room or meeting link

        // Status: Scheduled, Completed, Cancelled
        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Joined / display fields
        public string ApplicantFullName { get; set; }
        public string JobTitle { get; set; }
        public string InterviewerName { get; set; }
        public string InterviewTypeName { get; set; }
    }

    public class InterviewEvaluation
    {
        public int EvaluationID { get; set; }
        public int ScheduleID { get; set; }
        public int ApplicationID { get; set; }
        public int EvaluatedByUserID { get; set; }
        public int AssessmentTypeID { get; set; }

        public decimal Score { get; set; }
        public string Remarks { get; set; }
        public string Recommendation { get; set; }

        // Result: Pass, Fail
        public string Result { get; set; }

        public DateTime EvaluatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Joined / display fields
        public string ApplicantFullName { get; set; }
        public string JobTitle { get; set; }
        public string EvaluatedByName { get; set; }
        public string AssessmentTypeName { get; set; }
    }

    public class HiringDecision
    {
        public int DecisionID { get; set; }
        public int ApplicationID { get; set; }
        public int DecidedByUserID { get; set; }    // Admin or HR Manager only

        // Decision: Hired, Rejected
        public string Decision { get; set; }
        public string FinalRemarks { get; set; }

        public DateTime DecidedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Joined / display fields
        public string ApplicantFullName { get; set; }
        public string JobTitle { get; set; }
        public string DecidedByName { get; set; }
    }
}
