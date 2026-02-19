namespace HealthClinicApp.Utilities;

public static class Constants
{
    public const string ConnectionStringKey = "ConnectionStrings:DefaultConnection";
    
    // Appointment Statuses
    public const string StatusScheduled = "SCHEDULED";
    public const string StatusCompleted = "COMPLETED";
    public const string StatusCancelled = "CANCELLED";
    
    // Payment Statuses
    public const string PaymentStatusPaid = "PAID";
    public const string PaymentStatusUnpaid = "UNPAID";
    
    // Payment Modes
    public const string PaymentModeCash = "CASH";
    public const string PaymentModeCard = "CARD";
    public const string PaymentModeOnline = "ONLINE";
}

