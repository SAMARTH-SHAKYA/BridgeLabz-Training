namespace HealthClinicApp.Models;

public class AuditLog
{
    public int LogId { get; set; }
    public string TableName { get; set; } = string.Empty;
    public string Operation { get; set; } = string.Empty;
    public string ChangedBy { get; set; } = string.Empty;
    public DateTime ChangeTime { get; set; }
}

