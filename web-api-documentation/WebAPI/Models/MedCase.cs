namespace WebAPI.Models
{
    public class MedCase
    {
        public Guid TenantId { get; set; }

        public required Guid MedCaseKey { get; set; }

        public int MacAddress { get; set; }

        public string? CaseType { get; set; }

        public string? Status { get; set; }

        public string? LastOmni { get; set; }

        public string? PatientId { get; set; }

        public Guid? MedPointDockKey { get; set; }

        public DateTimeOffset LastChanged { get; set; }
    }
}
